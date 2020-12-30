using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Domain.Entities.Dtos.Ingredients
{
    public class CreateIngredientDto
    {
        [Required]
        public string Name { get; set; }
    }
}
