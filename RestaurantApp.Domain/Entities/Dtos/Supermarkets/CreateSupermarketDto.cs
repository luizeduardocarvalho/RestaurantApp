using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Domain.Entities.Dtos.Supermarkets
{
    public class CreateSupermarketDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string District { get; set; }
    }
}
