using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Services.Contracts;
using RestaurantApp.Infrastructure.Core;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Infrastructure.Repositories
{
    public class RestaurantIngredientRepository : Repository<RestaurantIngredient>, IRestaurantIngredientRepository
    {
        public RestaurantIngredientRepository(RestaurantAppContext context)
            : base(context)
        {
        }

        public IList<RestaurantIngredient> GetAll(int restaurantId)
        {
            return Query().Where(t => t.RestaurantId == restaurantId).ToList();
        }
    }
}
