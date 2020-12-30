using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Domain.Entities.Dtos.Restaurants;
using RestaurantApp.Domain.Services.Contracts;

namespace RestaurantApp.Api.Controllers
{
    [Route("api/[controller]")]
    public class RestaurantController : Controller
    {
        private readonly IRestaurantService restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            this.restaurantService = restaurantService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = restaurantService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = restaurantService.GetById(id);
            return Ok(result);
        }

        [HttpGet("ingredients")]
        public IActionResult GetIngredientList([FromQuery] string district)
        {
            var result = restaurantService.GetIngredientList(district);
            return Ok(result);
        }

        [HttpGet("district")]
        public IActionResult GetRestaurantByDistrict([FromQuery] string district)
        {
            var result = restaurantService.GetRestaurantByDistrict(district);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateRestaurant([FromBody] CreateRestaurantDto newRestaurant)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = restaurantService.CreateRestaurant(newRestaurant);
            if (result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var result = restaurantService.DeleteById(id);
            return Ok(result);
        }
    }
}
