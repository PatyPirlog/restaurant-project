using Restaurant.DataContext;
using Restaurant.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurant.Repositories.Restaurant
{
    public class RestaurantRepository : IRestaurantRepository
    {
        public MyDB db= new MyDB();

      public List<Models.Restaurant> GetRestaurant()
        {
            return db.Restaurant.ToList();
        }


        public List<Product> GetProductsforRestaurant(int IdRestaurant)
        {
            List<int> IdProducts = new List<int>();
            List<ProductRestaurant> IdProductRestaurant = db.ProductRestaurant.ToList();

            for (int i = 0; i < IdProductRestaurant.Count(); i++)
            {
                if (IdProductRestaurant[i].Id_Restaurant == IdRestaurant)
                {
                    IdProducts.Add(IdProductRestaurant[i].Id_Product);
                }
            }

            List<Product> Products = db.Product.ToList();
            List<Product> FinalProducts = new List<Product>();
            for (int i = 0; i < Products.Count(); i++)
            {
                for (int j = 0; j < IdProducts.Count(); j++)
                {
                    if (Products[i].Id == IdProducts[j])
                    {
                        FinalProducts.Add(Products[i]);
                    }
                }
            }

            return FinalProducts;
        }
    }
}
