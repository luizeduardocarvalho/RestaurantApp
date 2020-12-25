using Microsoft.EntityFrameworkCore;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Services.Contracts;
using RestaurantApp.Infrastructure.Core;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Infrastructure.Repositories
{
    public class IngredientRepository : Repository<Ingredient>, IIngredientRepository
    {
        public IngredientRepository(RestaurantAppContext context)
            : base(context)
        {
        }

        public IList<Ingredient> GetAll()
        {
            return Query().ToList();
        }

        public Ingredient GetIngredientById(int id)
        {
            return Query().FirstOrDefault(x => x.Id == id);
        }
    }
}
