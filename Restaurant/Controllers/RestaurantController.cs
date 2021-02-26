using Microsoft.AspNetCore.Mvc;
using Restaurant.Services.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Controllers
{
    [Route("api/restaurant")]
    public class RestaurantController : Controller
    {
        IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService)
        {
            _restaurantService = restaurantService;
        }

        [HttpGet]
        [Route("")]
        public IActionResult GetRestaurants()
        {
            if(_restaurantService.GetRestaurant().Count == 0)
            {
                return NoContent();
            }
            return Ok(_restaurantService.GetRestaurant());
        }

        [HttpGet]
        [Route("products/{idRestaurant}")]
        public IActionResult GetProductsForRestaurant(int idRestaurant)
        {
            if(_restaurantService.GetProductsforRestaurant(idRestaurant).Count() == 0)
            {
                return NoContent();
            }
            return Ok(_restaurantService.GetProductsforRestaurant(idRestaurant));
        }
    }
}
