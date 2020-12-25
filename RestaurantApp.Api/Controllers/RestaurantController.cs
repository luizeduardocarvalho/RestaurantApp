﻿using RestaurantApp.Domain.Services.Contracts;
using Microsoft.AspNetCore.Mvc;

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

        [HttpGet("/ingredients")]        
        public IActionResult GetIngredientList()
        {
            var result = restaurantService.GetIngredientList();
            return Ok(result);
        }
    }
}
