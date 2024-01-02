﻿
using E_Commerce.Services.ProductAPI.Models;
using Microsoft.EntityFrameworkCore;
using static System.Net.Mime.MediaTypeNames;
using System.Xml.Linq;
namespace E_Commerce.Services.ProductAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Product> Products { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
    new Product
    {
        id = 1,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p1_img",
        new_price = 50.0,
        old_price = 80.5
    },
    new Product
    {
        id = 2,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p2_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 3,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p3_img",
        new_price = 60.0,
        old_price = 100.5
    },
    new Product
    {
        id = 4,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p4_img",
        new_price = 100.0,
        old_price = 150.0
    },
    new Product
    {
        id = 5,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p5_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 6,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p6_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 7,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p7_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 8,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p8_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 9,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p9_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 10,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p10_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 11,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p11_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 12,
        name = "Striped Flutter Sleeve Overlap Collar Peplum Hem Blouse",
        category = "women",
        image = "p12_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 13,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p13_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 14,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p14_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 15,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p15_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 16,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p16_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 17,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p17_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 18,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p18_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 19,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p19_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 20,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p20_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 21,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p21_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 22,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p22_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 23,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p23_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 24,
        name = "Men Green Solid Zippered Full-Zip Slim Fit Bomber Jacket",
        category = "men",
        image = "p24_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 25,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p25_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 26,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p26_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 27,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p27_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 28,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p28_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 29,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p29_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 30,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p30_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 31,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p31_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 32,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p32_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 33,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p33_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 34,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p34_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 35,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p35_img",
        new_price = 85.0,
        old_price = 120.5
    },
    new Product
    {
        id = 36,
        name = "Boys Orange Colourblocked Hooded Sweatshirt",
        category = "kid",
        image = "p36_img",
        new_price = 85.0,
        old_price = 120.5
    }
);

        }
    }
}
