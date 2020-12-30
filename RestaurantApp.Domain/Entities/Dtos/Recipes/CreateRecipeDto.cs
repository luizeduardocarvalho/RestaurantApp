using System.Collections.Generic;

namespace RestaurantApp.Domain.Entities.Dtos.Recipes
{
    public class CreateRecipeDto
    {
        public string Name { get; set; }
        public IList<IngredientsDto> Ingredients { get; set; }
    }
}
