using RestaurantApp.Domain.Entities.Core;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApp.Domain.Entities
{    
    [Table("restaurant_recipe")]
    public class RestaurantRecipe : IEntity
    {
        public int RestaurantId { get; set; }
        public Restaurant Restaurant { get; set; }
        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
    }
}
