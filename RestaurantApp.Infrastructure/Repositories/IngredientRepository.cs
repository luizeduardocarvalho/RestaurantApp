using AutoMapper;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Ingredients;
using RestaurantApp.Domain.Services.Contracts;
using RestaurantApp.Infrastructure.Core;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Infrastructure.Repositories
{
    public class IngredientRepository : Repository<Ingredient>, IIngredientRepository
    {
        private readonly IMapper mapper;

        public IngredientRepository(RestaurantAppContext context, IMapper mapper)
            : base(context)
        {
            this.mapper = mapper;
        }

        public IList<GetIngredientsDto> GetAll()
        {
            return Query().Select(t => mapper.Map<GetIngredientsDto>(t)).ToList();
        }

        public Ingredient GetIngredientById(int id)
        {
            return Query().FirstOrDefault(x => x.Id == id);
        }
    }
}
