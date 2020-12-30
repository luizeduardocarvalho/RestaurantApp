using AutoMapper;
using Microsoft.EntityFrameworkCore;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos;
using RestaurantApp.Domain.Entities.Dtos.Restaurants;
using RestaurantApp.Domain.Services.Contracts;
using RestaurantApp.Infrastructure.Core;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Infrastructure.Repositories
{
    public class RestaurantRepository : Repository<Restaurant>, IRestaurantRepository
    {
        private readonly IMapper mapper;

        public RestaurantRepository(RestaurantAppContext context, IMapper mapper)
            : base(context)
        {
            this.mapper = mapper;
        }

        public IList<GetRestaurantsDto> GetAll()
        {
            return Query().Select(t => mapper.Map<GetRestaurantsDto>(t)).ToList();
        }

        public Restaurant GetRestaurantById(int id)
        {
            return Query().FirstOrDefault(x => x.Id == id);
        }

        public IList<GetRestaurantsDto> GetRestaurantByDistrict(string district)
        {
            return Query().Where(t => t.District.Equals(district))
                          .Select(t => mapper.Map<GetRestaurantsDto>(t))
                          .ToList();
        }

        //public IList<GetRestaurantsRecipesDto> GetRestaurantsRecipes(int id)
        //{

        //}

        //public IList<RestaurantIngredientsDto> GetIngredientListByDistrict(string district)
        //{
        //    var query = Query();
        //    if (!string.IsNullOrEmpty(district))
        //    {
        //        query = query.Where(t => t.District.Equals(district));
        //    }

        //    return query.Include(t => t.RestaurantIngredients).Select(t => new RestaurantIngredientsDto
        //    {
        //        RestaurantName = t.Name,
        //        Ingredients = t.RestaurantIngredients.Select(i => new IngredientsDto
        //        {
        //            Amount = i.Amount,
        //            Ingredient = i.Ingredient.Name,
        //            Date = i.Date
        //        }).ToList()
        //    }).ToList();
        //}
    }
}
