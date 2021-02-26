using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Repositories.Restaurant
{
   public interface IRestaurantRepository
    {
        public List<Models.Restaurant> GetRestaurant();
        public List<Models.Product> GetProductsforRestaurant(int IdRestaurant);
    }
}
