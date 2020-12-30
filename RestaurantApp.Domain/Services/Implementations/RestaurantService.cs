using AutoMapper;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos;
using RestaurantApp.Domain.Entities.Dtos.Restaurants;
using RestaurantApp.Domain.Services.Contracts;
using System;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Implementations
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository restaurantRepository;
        private readonly IMapper mapper;

        public RestaurantService(IRestaurantRepository restaurantRepository, IMapper mapper)
        {
            this.restaurantRepository = restaurantRepository;
            this.mapper = mapper;
        }

        public IList<GetRestaurantsDto> GetAll()
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

        public IList<GetRestaurantsDto> GetRestaurantByDistrict(string district)
        {
            return restaurantRepository.GetRestaurantByDistrict(district);
        }

        public Restaurant CreateRestaurant(CreateRestaurantDto restaurant)
        {
            var newRestaurant = new Restaurant(restaurant.Name, restaurant.District);
            var result = restaurantRepository.Insert(newRestaurant);

            if (result)
            {
                return newRestaurant;
            }

            throw new InvalidOperationException();
        }

        public GetRestaurantsDto DeleteById(int id)
        {
            var restaurant = restaurantRepository.GetRestaurantById(id);
            if (restaurant is null)
            {
                throw new Exception("Ingredient not found.");
            }

            restaurantRepository.Delete(restaurant);
            return mapper.Map<GetRestaurantsDto>(restaurant);
        }
    }
}
