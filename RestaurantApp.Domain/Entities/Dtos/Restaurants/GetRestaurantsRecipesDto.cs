using RestaurantApp.Domain.Entities.Dtos.Recipes;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Entities.Dtos.Restaurants
{
    public class GetRestaurantsRecipesDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IReadOnlyCollection<GetRecipesDto> Recipes { get; set; }
    }
}
