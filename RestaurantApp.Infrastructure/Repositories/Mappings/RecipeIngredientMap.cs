using RestaurantApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace RestaurantApp.Infrastructure.Repositories.Mappings
{
    public sealed class RecipeIngredientMap : IEntityTypeConfiguration<RecipeIngredient>
    {
        public void Configure(EntityTypeBuilder<RecipeIngredient> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(t => t.RecipeId).HasColumnName("recipe_id").IsRequired().HasColumnType("INT");
            builder.Property(t => t.IngredientId).HasColumnName("ingredient_id").IsRequired().HasColumnType("INT");
            builder.Property(t => t.Amount).HasColumnName("amount").IsRequired().HasColumnType("INT");

            builder.HasKey(t => new { t.RecipeId, t.IngredientId});
            builder.HasOne(t => t.Recipe).WithMany(t => t.RecipeIngredients).HasForeignKey(t => t.RecipeId);
            builder.HasOne(t => t.Ingredient).WithMany(t => t.RecipeIngredients).HasForeignKey(t => t.IngredientId);
        }
    }
}
