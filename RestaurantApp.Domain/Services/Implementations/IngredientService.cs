using AutoMapper;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Ingredients;
using RestaurantApp.Domain.Services.Contracts;
using System;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Implementations
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository ingredientRepository;
        private readonly IMapper mapper;

        public IngredientService(IIngredientRepository ingredientRepository, IMapper mapper)
        {
            this.ingredientRepository = ingredientRepository;
            this.mapper = mapper;
        }

        public IList<GetIngredientsDto> GetAll()
        {
            return ingredientRepository.GetAll();
        }

        public Ingredient GetById(int id)
        {
            return ingredientRepository.GetIngredientById(id);
        }

        public Ingredient CreateIngredient(CreateIngredientDto ingredient)
        {
            if (ingredient is null)
            {
                throw new ArgumentNullException();
            }

            var newIngredient = new Ingredient(ingredient.Name);
            ingredientRepository.Insert(newIngredient);

            return newIngredient;
        }

        public GetIngredientsDto DeleteById(int id)
        {
            var ingredient = ingredientRepository.GetIngredientById(id);
            if(ingredient is null)
            {
                throw new Exception("Ingredient not found.");
            }

            ingredientRepository.Delete(ingredient);
            return mapper.Map<Ingredient, GetIngredientsDto>(ingredient);
        }
    }
}
