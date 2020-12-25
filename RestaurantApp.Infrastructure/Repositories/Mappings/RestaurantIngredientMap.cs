using RestaurantApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace RestaurantApp.Infrastructure.Repositories.Mappings
{
    public sealed class RestaurantIngredientMap : IEntityTypeConfiguration<RestaurantIngredient>
    {
        public void Configure(EntityTypeBuilder<RestaurantIngredient> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(t => t.RestaurantId).HasColumnName("restaurant_id").IsRequired().HasColumnType("INT");
            builder.Property(t => t.IngredientId).HasColumnName("ingredient_id").IsRequired().HasColumnType("INT");
            builder.Property(t => t.Amount).HasColumnName("amount").IsRequired().HasColumnType("NUMERIC");
            builder.Property(t => t.Date).HasColumnName("date").HasColumnType("DATE");
            
            builder.HasKey(t => new { t.RestaurantId, t.IngredientId });
            builder.HasOne(t => t.Ingredient).WithMany(t => t.RestaurantIngredients).HasForeignKey(t => t.IngredientId);
            builder.HasOne(t => t.Restaurant).WithMany(t => t.RestaurantIngredients).HasForeignKey(t => t.RestaurantId);
        }
    }
}
