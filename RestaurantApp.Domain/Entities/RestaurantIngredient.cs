using RestaurantApp.Domain.Entities.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApp.Domain.Entities
{    
    [Table("restaurant_ingredient")]
    public class RestaurantIngredient : IEntity
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public double Amount { get; set; }
        public DateTime Date { get; set; }
    }
}
