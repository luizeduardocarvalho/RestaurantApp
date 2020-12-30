using AutoMapper;
using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Supermarkets;
using RestaurantApp.Domain.Services.Contracts;
using RestaurantApp.Infrastructure.Core;
using System.Collections.Generic;
using System.Linq;

namespace RestaurantApp.Infrastructure.Repositories
{
    public class SupermarketRepository : Repository<Supermarket>, ISupermarketRepository
    {
        private readonly IMapper mapper;

        public SupermarketRepository(RestaurantAppContext context, IMapper mapper)
            : base(context)
        {
            this.mapper = mapper;
        }

        public IList<GetSupermarketsDto> GetAll()
        {
            return Query().Select(t => mapper.Map<GetSupermarketsDto>(t)).ToList();
        }

        public Supermarket GetSupermarketById(int id)
        {
            return Query().FirstOrDefault(x => x.Id == id);
        }

        public IList<GetSupermarketsDto> GetSupermarketsByDistrict(string district)
        {
            return Query().Where(t => t.District.Equals(district))
                          .Select(t => mapper.Map<GetSupermarketsDto>(t))
                          .ToList();
        }
    }
}
