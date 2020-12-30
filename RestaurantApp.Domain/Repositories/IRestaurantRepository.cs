using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos;
using RestaurantApp.Domain.Entities.Dtos.Restaurants;
using RestaurantApp.Domain.Repositories.Core;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IRestaurantRepository : IRepository<Restaurant>
    {
        IList<GetRestaurantsDto> GetAll();
        Restaurant GetRestaurantById(int id);
        IList<RestaurantIngredientsDto> GetIngredientListByDistrict(string district);
        IList<GetRestaurantsDto> GetRestaurantByDistrict(string district);
    }
}
