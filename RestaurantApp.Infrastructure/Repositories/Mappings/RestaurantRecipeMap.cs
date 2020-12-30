using RestaurantApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace RestaurantApp.Infrastructure.Repositories.Mappings
{
    public sealed class RestaurantRecipeMap : IEntityTypeConfiguration<RestaurantRecipe>
    {
        public void Configure(EntityTypeBuilder<RestaurantRecipe> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(t => t.RestaurantId).HasColumnName("restaurant_id").IsRequired().HasColumnType("INT");
            builder.Property(t => t.RecipeId).HasColumnName("recipe_id").IsRequired().HasColumnType("INT");
            
            builder.HasKey(t => new { t.RestaurantId, t.RecipeId });
            builder.HasOne(t => t.Recipe).WithMany(t => t.RestaurantRecipes).HasForeignKey(t => t.RecipeId);
            builder.HasOne(t => t.Restaurant).WithMany(t => t.RestaurantRecipes).HasForeignKey(t => t.RestaurantId);
        }
    }
}
