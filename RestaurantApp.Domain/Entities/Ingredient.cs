using RestaurantApp.Domain.Entities.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApp.Domain.Entities
{
    [Table("ingredients")]
    public class Ingredient : IEntity
    {
        public Ingredient(string name)
        {
            Name = name;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public IList<RestaurantIngredient> RestaurantIngredients { get; set; }
    }
}
