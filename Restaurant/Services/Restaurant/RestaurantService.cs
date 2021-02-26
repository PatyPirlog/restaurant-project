using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.Models;
using Restaurant.Repositories.Restaurant;

namespace Restaurant.Services.Restaurant
{
 
    public class RestaurantService : IRestaurantService
    {
        public IRestaurantRepository _restaurantRepository;
        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public List<Product> GetProductsforRestaurant(int IdRestaurant)
        {
            return _restaurantRepository.GetProductsforRestaurant(IdRestaurant);
        }

        public List<Models.Restaurant> GetRestaurant()
        {
            return _restaurantRepository.GetRestaurant();
        }
    }
}
