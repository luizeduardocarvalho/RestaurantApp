using RestaurantApp.Domain.Entities;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IIngredientService
    {
        IList<Ingredient> GetAll();
        Ingredient GetById(int id);
    }
}
