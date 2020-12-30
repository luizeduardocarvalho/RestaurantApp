using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Supermarkets;
using RestaurantApp.Domain.Repositories.Core;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface ISupermarketRepository : IRepository<Supermarket>
    {
        IList<GetSupermarketsDto> GetAll();
        Supermarket GetSupermarketById(int id);
        IList<GetSupermarketsDto> GetSupermarketsByDistrict(string district);
    }
}
