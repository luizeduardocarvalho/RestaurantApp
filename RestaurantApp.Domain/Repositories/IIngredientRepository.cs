using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Ingredients;
using RestaurantApp.Domain.Repositories.Core;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IIngredientRepository : IRepository<Ingredient>
    {
        IList<GetIngredientsDto> GetAll();
        Ingredient GetIngredientById(int id);
    }
}
