using RestaurantApp.Domain.Entities;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IRestaurantIngredientService
    {
        IList<RestaurantIngredient> GetAll(int restaurantId);
    }
}
