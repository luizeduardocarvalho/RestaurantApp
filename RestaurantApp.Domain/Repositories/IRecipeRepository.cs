using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Recipes;
using RestaurantApp.Domain.Repositories.Core;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IRecipeRepository : IRepository<Recipe>
    {
        IList<GetRecipesDto> GetAll();
        Recipe GetRecipeById(int id);        
    }
}
