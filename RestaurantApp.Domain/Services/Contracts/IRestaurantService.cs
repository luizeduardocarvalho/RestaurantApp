using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos;
using RestaurantApp.Domain.Entities.Dtos.Restaurants;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IRestaurantService
    {
        IList<GetRestaurantsDto> GetAll();
        Restaurant GetById(int id);
        IList<RestaurantIngredientsDto> GetIngredientList(string district);
        IList<GetRestaurantsDto> GetRestaurantByDistrict(string district);
        Restaurant CreateRestaurant(CreateRestaurantDto restaurant);
        GetRestaurantsDto DeleteById(int id);
    }
}
