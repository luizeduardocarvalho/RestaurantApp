using RestaurantApp.Domain.Entities.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApp.Domain.Entities
{
    [Table("restaurants")]
    public class Restaurant : IEntity
    {
        public Restaurant(string name)
        {
            Name = name;
        }
        
        public int Id { get; set; }        
        public string Name { get; set; }
        public IList<RestaurantIngredient> RestaurantIngredients { get; set; }
    }
}
