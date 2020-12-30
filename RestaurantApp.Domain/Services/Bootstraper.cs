using AutoMapper;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Ingredients;
using RestaurantApp.Domain.Entities.Dtos.Restaurants;

namespace RestaurantApp.Domain.Services
{
    public class Bootstraper
    {
        public static IMapper MapperStartUp()
        {
            var mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Ingredient, GetIngredientsDto>().ReverseMap();
                cfg.CreateMap<Restaurant, GetRestaurantsDto>().ReverseMap();
            });

            return mapperConfiguration.CreateMapper();
        }
    }
}
