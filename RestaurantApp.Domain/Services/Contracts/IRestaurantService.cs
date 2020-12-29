using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IRestaurantService
    {
        IList<Restaurant> GetAll();
        Restaurant GetById(int id);
        IList<RestaurantIngredientsDto> GetIngredientList(string district);
        IList<Restaurant> GetRestaurantByDistrict(string district);
    }
}
