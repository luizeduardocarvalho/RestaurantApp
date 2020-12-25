using Microsoft.EntityFrameworkCore;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Infrastructure.Repositories.Mappings;

namespace RestaurantApp.Infrastructure
{
    public class RestaurantAppContext : DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<RestaurantIngredient> RestaurantIngredients { get; set; }

        public RestaurantAppContext(DbContextOptions<RestaurantAppContext> options) :
            base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new RestaurantMap());
            modelBuilder.ApplyConfiguration(new IngredientMap());
            modelBuilder.ApplyConfiguration(new RestaurantIngredientMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
