using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Recipes;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IRecipeService
    {
        IList<GetRecipesDto> GetAll();
        Recipe GetById(int id);
        Recipe CreateRecipe(CreateRecipeDto recipe);
        GetRecipesDto DeleteById(int id);
    }
}
