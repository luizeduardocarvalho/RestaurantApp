using Microsoft.AspNetCore.Mvc;
using RestaurantApp.Domain.Entities.Dtos.Recipes;
using RestaurantApp.Domain.Services.Contracts;

namespace RestaurantApp.Api.Controllers
{
    [Route("api/[controller]")]
    public class RecipeController : Controller
    {
        private readonly IRecipeService recipeService;

        public RecipeController(IRecipeService recipeService)
        {
            this.recipeService = recipeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var result = recipeService.GetAll();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var result = recipeService.GetById(id);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateRecipe([FromBody] CreateRecipeDto newRecipe)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var result = recipeService.CreateRecipe(newRecipe);
            if (result is null)
            {
                return NotFound();
            }

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteById(int id)
        {
            var result = recipeService.DeleteById(id);
            return Ok(result);
        }
    }
}
