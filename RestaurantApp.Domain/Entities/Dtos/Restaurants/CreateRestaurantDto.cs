using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Domain.Entities.Dtos.Restaurants
{
    public class CreateRestaurantDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string District { get; set; }
    }
}
