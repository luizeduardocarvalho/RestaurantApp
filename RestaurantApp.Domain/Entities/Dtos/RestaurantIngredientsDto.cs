using System;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Entities.Dtos
{
    public class RestaurantIngredientsDto
    {
        public string RestaurantName { get; set; }
        public IList<IngredientsDto> Ingredients { get; set; }        
    }
}
