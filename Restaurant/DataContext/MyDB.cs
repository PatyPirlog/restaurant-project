using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Restaurant.Models;

namespace Restaurant.DataContext 
{
    public class MyDB : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder OptionsBuilder)
        {
            var builder = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                                .AddJsonFile("appsettings.json");

            var configuration = builder.Build();
            OptionsBuilder.UseSqlServer(configuration["ConnectionStrings:UserConnection"]);
        }

        public DbSet<Models.Restaurant> Restaurant { get; set; }

        public DbSet<Product> Product {get; set;}

        public DbSet<ProductRestaurant> ProductRestaurant { get; set; }


}
}
