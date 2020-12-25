using RestaurantApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace RestaurantApp.Infrastructure.Repositories.Mappings
{
    public sealed class IngredientMap : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            if (builder == null)
            {
                throw new ArgumentNullException(nameof(builder));
            }

            builder.Property(t => t.Id).HasColumnName("id").IsRequired().HasColumnType("INT").ValueGeneratedOnAdd();
            builder.Property(t => t.Name).HasColumnName("name").IsRequired().HasColumnType("VARCHAR").HasMaxLength(100);

            builder.HasKey(t => t.Id);            
        }
    }
}
