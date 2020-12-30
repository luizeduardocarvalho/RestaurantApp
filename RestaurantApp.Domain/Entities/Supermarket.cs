using RestaurantApp.Domain.Entities.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApp.Domain.Entities
{
    [Table("supermarkets")]
    public class Supermarket : IEntity
    {
        public Supermarket(string name, string district)
        {
            Name = name;
            District = district;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string District { get; set; }
    }
}
