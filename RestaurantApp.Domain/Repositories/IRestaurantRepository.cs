using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos;
using RestaurantApp.Domain.Repositories.Core;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        IList<Restaurant> GetAll();
        Restaurant GetRestaurantById(int id);
        IList<RestaurantIngredientsDto> GetIngredientListByDistrict(string district);
        IList<Restaurant> GetRestaurantByDistrict(string district);
    }
}
