using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantApp.Domain.Entities
{
    [Table("recipe_ingredient")]
    public class RecipeIngredient
    {
        public RecipeIngredient(int recipeId, int ingredientId, double amount)
        {
            RecipeId = recipeId;
            IngredientId = ingredientId;
            Amount = amount;
        }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
        public double Amount { get; set; }
    }
}
