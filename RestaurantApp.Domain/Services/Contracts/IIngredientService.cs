using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Ingredients;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface IIngredientService
    {
        IList<GetIngredientsDto> GetAll();
        Ingredient GetById(int id);
        Ingredient CreateIngredient(CreateIngredientDto ingredient);
        GetIngredientsDto DeleteById(int id);
    }
}
