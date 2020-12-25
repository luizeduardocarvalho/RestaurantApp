using System;

namespace RestaurantApp.Domain.Entities.Dtos
{
    public class IngredientsDto
    {
        public string Ingredient { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
