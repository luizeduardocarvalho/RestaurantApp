using Microsoft.EntityFrameworkCore;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Infrastructure.Repositories.Mappings;

namespace RestaurantApp.Infrastructure
{
    public class RestaurantAppContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Supermarket> Supermarkets { get; set; }
        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<RestaurantRecipe> RestaurantRecipes { get; set; }
        public DbSet<RecipeIngredient> RecipeIngredients { get; set; }

        public RestaurantAppContext(DbContextOptions<RestaurantAppContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RestaurantMap());
            modelBuilder.ApplyConfiguration(new IngredientMap());
            modelBuilder.ApplyConfiguration(new SupermarketMap());
            modelBuilder.ApplyConfiguration(new RecipeMap());
            modelBuilder.ApplyConfiguration(new RestaurantRecipeMap());
            modelBuilder.ApplyConfiguration(new RecipeIngredientMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
