using RestaurantApp.Domain.Services.Contracts;
using RestaurantApp.Domain.Services.Implementations;
using Microsoft.Extensions.DependencyInjection;

namespace RestaurantApp.Domain
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddDomainServices(this IServiceCollection services)
        {
            services.AddTransient<IRestaurantService, RestaurantService>();
            services.AddTransient<IIngredientService, IngredientService>();
            services.AddTransient<IRestaurantIngredientService, RestaurantIngredientService>();

            return services;
        }
    }
}
