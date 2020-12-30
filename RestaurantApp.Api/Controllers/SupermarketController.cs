using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Domain.Entities.Dtos.Supermarkets;
using RestaurantApp.Domain.Services.Contracts;

namespace RestaurantApp.Api.Controllers
{
    [Route("api/[controller]")]
    public class SupermarketController : Controller
    {
        private readonly ISupermarketService supermarketService;

        public SupermarketController(ISupermarketService supermarketService)
        {
            this.supermarketService = supermarketService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = supermarketService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = supermarketService.GetById(id);
            return Ok(result);
        }

        [HttpGet("district")]
        public IActionResult GetSupermarketByDistrict([FromQuery] string district)
        {
            var result = supermarketService.GetSupermarketByDistrict(district);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateRestaurant([FromBody] CreateSupermarketDto newSupermarket)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = supermarketService.CreateSupermarket(newSupermarket);
            if (result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var result = supermarketService.DeleteById(id);
            return Ok(result);
        }
    }
}
