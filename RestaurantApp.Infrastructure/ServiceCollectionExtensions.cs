using Microsoft.Extensions.DependencyInjection;
using RestaurantApp.Domain.Services.Contracts;
using RestaurantApp.Infrastructure.Repositories;

namespace RestaurantApp.Infrastructure
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
        {
            services.AddTransient<IRestaurantRepository, RestaurantRepository>();
            services.AddTransient<IIngredientRepository, IngredientRepository>();
            services.AddTransient<ISupermarketRepository, SupermarketRepository>();
            services.AddTransient<IRecipeRepository, RecipeRepository>();

            return services;
        }
    }
}
