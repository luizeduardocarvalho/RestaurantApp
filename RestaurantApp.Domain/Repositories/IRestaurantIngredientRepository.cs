using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Repositories.Core;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IRestaurantIngredientRepository : IRepository<RestaurantIngredient>
    {
        IList<RestaurantIngredient> GetAll(int restaurantId);
    }
}
