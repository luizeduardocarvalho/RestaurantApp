using RestaurantApp.Domain.Entities.Dtos.Ingredients;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Entities.Dtos.Recipes
{
    public class GetRecipesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IReadOnlyCollection<GetIngredientsDto> Ingredients { get; set; }
    }
}
