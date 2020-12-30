using RestaurantApp.Domain.Entities;
using RestaurantApp.Domain.Entities.Dtos.Supermarkets;
using System.Collections.Generic;

namespace RestaurantApp.Domain.Services.Contracts
{
    public interface ISupermarketService
    {
        IList<GetSupermarketsDto> GetAll();
        Supermarket GetById(int id);
        IList<GetSupermarketsDto> GetSupermarketByDistrict(string district);
        Supermarket CreateSupermarket(CreateSupermarketDto supermarket);
        GetSupermarketsDto DeleteById(int id);
    }
}
