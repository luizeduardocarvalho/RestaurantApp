using RestaurantApp.Domain.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace RestaurantApp.Api.Controllers
{
    [Route("api/[controller]")]
    public class IngredientController : Controller
    {
        private readonly IIngredientService ingredientService;

        public IngredientController(IIngredientService ingredientService)
        {
            this.ingredientService = ingredientService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = ingredientService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = ingredientService.GetById(id);
            return Ok(result);
        }
    }
}
