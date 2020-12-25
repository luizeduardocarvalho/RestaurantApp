using RestaurantApp.Domain.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Api.Controllers
{
    [Route("api/[controller]")]
    public class RestaurantIngredientController : Controller
    {
        private readonly IRestaurantIngredientService restaurantIngredientService;

        public RestaurantIngredientController(IRestaurantIngredientService restaurantIngredientService)
        {
            this.restaurantIngredientService = restaurantIngredientService;
        }

        [HttpGet]
        public IActionResult GetAll([FromQuery] int restaurantId)
        {
            var result = restaurantIngredientService.GetAll(restaurantId);
            return Ok(result);
        }
    }
}
