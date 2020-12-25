using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos;
using RestaurantApp.Domain.Services.Contracts;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Implementations
{
    public class RestaurantIngredientService : IRestaurantIngredientService
    {
        private readonly IRestaurantIngredientRepository restaurantIngredientRepository;

        public RestaurantIngredientService(IRestaurantIngredientRepository restaurantIngredientRepository)
        {
            this.restaurantIngredientRepository = restaurantIngredientRepository;
        }

        public IList<RestaurantIngredient> GetAll(int restaurantId)
        {
            return restaurantIngredientRepository.GetAll(restaurantId);
        }
    }
}
