using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Repositories.Core;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IIngredientRepository : IRepository<Ingredient>
    {
        IList<Ingredient> GetAll();
        Ingredient GetIngredientById(int id);
    }
}
