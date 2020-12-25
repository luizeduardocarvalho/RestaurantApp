using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Services.Contracts;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Implementations
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            this.ingredientRepository = ingredientRepository;
        }

        public IList<Ingredient> GetAll()
        {
            return ingredientRepository.GetAll();
        }

        public Ingredient GetById(int id)
        {
            return ingredientRepository.GetIngredientById(id);
        }
    }
}
