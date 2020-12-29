using Microsoft.EntityFrameworkCore;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos;
using RestaurantApp.Domain.Services.Contracts;
using RestaurantApp.Infrastructure.Core;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Infrastructure.Repositories
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        public RestaurantRepository(RestaurantAppContext context)
            : base(context)
        {
        }

        public IList<Restaurant> GetAll()
        {
            return Query().ToList();
        }

        public Restaurant GetRestaurantById(int id)
        {
            return Query().FirstOrDefault(x => x.Id == id);
        }

        public IList<Restaurant> GetRestaurantByDistrict(string district)
        {
            return Query().Where(t => t.District.Equals(district)).ToList();
        }

        public IList<RestaurantIngredientsDto> GetIngredientListByDistrict(string district)
        {
            var query = Query();
            if (!string.IsNullOrEmpty(district))
            {
                query = query.Where(t => t.District.Equals(district));
            }

            return query.Include(t => t.RestaurantIngredients).Select(t => new RestaurantIngredientsDto
            {
                RestaurantName = t.Name,
                Ingredients = t.RestaurantIngredients.Select(i => new IngredientsDto
                {
                    Amount = i.Amount,
                    Ingredient = i.Ingredient.Name,
                    Date = i.Date
                }).ToList()
            }).ToList();
        }
    }
}
