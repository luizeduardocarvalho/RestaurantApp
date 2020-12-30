using RestaurantApp.Domain.Entities.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApp.Domain.Entities
{
    [Table("restaurants")]
    public class Restaurant : IEntity
    {
        public Restaurant(string name, string district)
        {
            Name = name;
            District = district;
        }
        
        public int Id { get; set; }        
        public string Name { get; set; }
        public string District { get; set; }
        public IReadOnlyCollection<RestaurantRecipe> RestaurantRecipes { get; set; }
    }
}
