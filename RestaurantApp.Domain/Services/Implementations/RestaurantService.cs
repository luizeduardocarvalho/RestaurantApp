using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos;
using RestaurantApp.Domain.Services.Contracts;
using System;
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

        public IList<RestaurantIngredientsDto> GetIngredientList(string district)
        {
            return restaurantRepository.GetIngredientListByDistrict(district);
        }

        public IList<Restaurant> GetRestaurantByDistrict(string district)
        {
            return restaurantRepository.GetRestaurantByDistrict(district);
        }

        public Restaurant CreateRestaurantDto(CreateRestaurantDto restaurant)
        {
            var newRestaurant = new Restaurant(restaurant.Name, restaurant.District);
            var result = restaurantRepository.Insert(newRestaurant);

            if(result)
            {
                return newRestaurant;
            }

            throw new InvalidOperationException();
        }
    }
}
