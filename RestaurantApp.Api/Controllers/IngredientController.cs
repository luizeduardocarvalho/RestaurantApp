using RestaurantApp.Domain.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Domain.Entities.Dtos.Ingredients;

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

        [HttpPost]
        public IActionResult CreateIngredient([FromBody] CreateIngredientDto newIngredient)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);  
            }

            var result = ingredientService.CreateIngredient(newIngredient);
            if(result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var result = ingredientService.DeleteById(id);
            return Ok(result);
        }
    }
}
