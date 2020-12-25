FROM mcr.microsoft.com/dotnet/core/sdk:3.1 as build
WORKDIR /app

COPY *.sln .
COPY LibraryManager.Api/*.csproj ./LibraryManager.Api/
COPY LibraryManager.Domain/*.csproj ./LibraryManager.Domain/
COPY ./LibraryManager.Infrastructure/*.csproj ./LibraryManager.Infrastructure/

RUN dotnet restore

COPY LibraryManager.Api/. ./LibraryManager.Api/
COPY LibraryManager.Domain/. ./LibraryManager.Domain/
COPY LibraryManager.Infrastructure/. ./LibraryManager.Infrastructure/

WORKDIR /app
RUN dotnet publish -c Release -o out 

FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS runtime
COPY --from=build /app/out ./
CMD ASPNETCORE_URLS=http://*:$PORT dotnet LibraryManager.Api.dll