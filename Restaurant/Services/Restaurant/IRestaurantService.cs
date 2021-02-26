using Restaurant.Repositories.Restaurant;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Services.Restaurant
{
    public interface IRestaurantService
    {
        public List<Models.Restaurant> GetRestaurant();
        public List<Models.Product> GetProductsforRestaurant(int IdRestaurant);
    }
}
