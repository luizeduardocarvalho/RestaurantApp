using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Ingredients;
using RestaurantApp.Domain.Entities.Dtos.Recipes;
using RestaurantApp.Domain.Services.Contracts;
using RestaurantApp.Infrastructure.Core;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Infrastructure.Repositories
{
    public class RecipeRepository : Repository<Recipe>, IRecipeRepository
    {
        private readonly IMapper mapper;

        public RecipeRepository(RestaurantAppContext context, IMapper mapper)
            : base(context)
        {
            this.mapper = mapper;
        }

        public IList<GetRecipesDto> GetAll()
        {
            return Query().Include(t => t.RecipeIngredients).Select(t => new GetRecipesDto
            {
                Id = t.Id,
                Name = t.Name,
                Ingredients = t.RecipeIngredients.Select(i => new GetIngredientsDto
                {
                    Id = i.Ingredient.Id,
                    Name = i.Ingredient.Name
                }).ToList()
            }).ToList();
        }

        public Recipe GetRecipeById(int id)
        {
            return Query().FirstOrDefault(x => x.Id == id);
        }
    }
}
