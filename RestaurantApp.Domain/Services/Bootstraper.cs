using AutoMapper;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Ingredients;

namespace RestaurantApp.Domain.Services
{
    public class Bootstraper
    {
        public static IMapper MapperStartUp()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Ingredient, GetIngredientsDto>().ReverseMap();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
