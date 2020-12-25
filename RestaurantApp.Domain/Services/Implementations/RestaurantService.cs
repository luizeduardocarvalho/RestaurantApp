using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos;
using RestaurantApp.Domain.Services.Contracts;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Implementations
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            this.restaurantRepository = restaurantRepository;
        }

        public IList<Restaurant> GetAll()
        {
            return restaurantRepository.GetAll();
        }

        public Restaurant GetById(int id)
        {
            return restaurantRepository.GetRestaurantById(id);
        }

        public IList<RestaurantIngredientsDto> GetIngredientList()
        {
            return restaurantRepository.GetIngredientList();
        }
    }
}
