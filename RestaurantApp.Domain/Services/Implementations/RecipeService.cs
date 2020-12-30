using AutoMapper;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Recipes;
using RestaurantApp.Domain.Services.Contracts;
using System;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Implementations
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository recipeRepository;
        private readonly IMapper mapper;        

        public RecipeService(IRecipeRepository recipeRepository, IMapper mapper)
        {
            this.recipeRepository = recipeRepository;
            this.mapper = mapper;            
        }

        public IList<GetRecipesDto> GetAll()
        {
            return recipeRepository.GetAll();
        }

        public Recipe GetById(int id)
        {
            return recipeRepository.GetRecipeById(id);
        }

        public Recipe CreateRecipe(CreateRecipeDto recipe)
        {
            var newRecipe = new Recipe(recipe.Name);    
            foreach (var ingredient in recipe.Ingredients)
            {                
                newRecipe.AddIngredient(ingredient.IngredientId, ingredient.Amount);
            }
            
            var result = recipeRepository.Insert(newRecipe);
            return result;
        }

        public GetRecipesDto DeleteById(int id)
        {
            var recipe = recipeRepository.GetRecipeById(id);
            if (recipe is null)
            {
                throw new Exception("Recipe not found.");
            }

            recipeRepository.Delete(recipe);
            return mapper.Map<GetRecipesDto>(recipe);
        }
    }
}
