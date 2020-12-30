using AutoMapper;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Supermarkets;
using RestaurantApp.Domain.Services.Contracts;
using System;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Implementations
{
    public class SupermarketService : ISupermarketService
    {
        private readonly ISupermarketRepository supermarketRepository;
        private readonly IMapper mapper;

        public SupermarketService(ISupermarketRepository supermarketRepository, IMapper mapper)
        {
            this.supermarketRepository = supermarketRepository;
            this.mapper = mapper;
        }

        public IList<GetSupermarketsDto> GetAll()
        {
            return supermarketRepository.GetAll();
        }

        public Supermarket GetById(int id)
        {
            return supermarketRepository.GetSupermarketById(id);
        }

        public IList<GetSupermarketsDto> GetSupermarketByDistrict(string district)
        {
            return supermarketRepository.GetSupermarketsByDistrict(district);
        }

        public Supermarket CreateSupermarket(CreateSupermarketDto supermarket)
        {
            var newSupermarket = new Supermarket(supermarket.Name, supermarket.District);
            var result = supermarketRepository.Insert(newSupermarket);

            return result;
        }

        public GetSupermarketsDto DeleteById(int id)
        {
            var restaurant = supermarketRepository.GetSupermarketById(id);
            if (restaurant is null)
            {
                throw new Exception("Supermarket not found.");
            }

            supermarketRepository.Delete(restaurant);
            return mapper.Map<GetSupermarketsDto>(restaurant);
        }
    }
}
