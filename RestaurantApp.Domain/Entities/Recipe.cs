using RestaurantApp.Domain.Entities.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApp.Domain.Entities
{
    [Table("recipes")]
    public class Recipe : IEntity
    {
        public Recipe(string name)
        {
            Name = name;
            RecipeIngredients = new List<RecipeIngredient>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public IReadOnlyCollection<RestaurantRecipe> RestaurantRecipes { get; set; }
        public IList<RecipeIngredient> RecipeIngredients { get; set; }

        public void AddIngredient(int ingredientId, double amount)
        {
            RecipeIngredients.Add(new RecipeIngredient(this.Id, ingredientId, amount));
        }
    }
}
