using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcSpoon.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcSpoon.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using var context = new MvcSpoonContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcSpoonContext>>());
            
            if (context.Spoons.Any())
            {
                return;   
            }

            // Add a data into database
            context.Spoons.AddRange(
                new Spoons
                {
                    Type = "Coffee spoon",
                    Size = "12cm",
                    Price = 1.99M,
                    Material = "Stainless Steel.",
                    Use = "Use for eating liquild foods",
                    Rating = 4
                },

                new Spoons
                {
                    Type = "Dessert Spoon",
                    Size = "18.5cm",
                    Price = 2.49M,
                    Material = "Plasic, Wood",
                    Use = "It specialy use to eat ice-creem",
                    Rating = 3
                },

                new Spoons
                {
                    Type = "Soup Spoon",
                    Size = "17.5cm",
                    Price = 2.99M,
                    Material = "Palsic, Wood",
                    Use = "Use for eating liquild foods",
                    Rating = 4
                },

                new Spoons
                {
                    Type = "Serving Spoon",
                    Size = "20.5cm",
                    Price = 4.99M,
                    Material = "Stainless Steel",
                    Use = "Use to eat different type of food such as rice , vegitables",
                    Rating = 5
                },
                 new Spoons
                 {
                     Type = "Tea Spoon",
                     Size = "14cm",
                     Price = 1.49M,
                     Material = "Plastic, Stainless Steel",
                     Use = "Generaly use to masure Dry ingredients like sugar, salt and spices",
                     Rating = 3
                 },

                new Spoons
                {
                    Type = "Spork",
                    Size = "14cm",
                    Price = 2.99M,
                    Material = "Plastic, Stainless Steel",
                    Use = "Use to eat chinese cuisine",
                    Rating = 3
                },

                new Spoons
                {
                    Type = "Egg Spoon",
                    Size = "16cm",
                    Price = 1.49M,
                    Material = "Stainless Steel",
                    Use = "Mostly use to eat boil eggs",
                    Rating = 4
                },

                new Spoons
                {
                    Type = "Bar Spoon",
                    Size = "18cm",
                    Price = 7.99M,
                    Material = "Stainless Steel",
                    Use = "used in bartending for mixing and layering of both alcoholic and non-alcoholic mixed drinks",
                    Rating = 4
                },
                  new Spoons
                  {
                      Type = "Slotted Spoon",
                      Size = "24cm",
                      Price = 6.99M,
                      Material = "Stainless Steel, Wood",
                      Use = "Generaly used for drain a pasta or rice",
                      Rating = 4
                  },

                new Spoons
                {
                    Type = "Ladle Spoon",
                    Size = "24cm",
                    Price = 9.99M,
                    Material = "Stainless Steel",
                    Use = "Used for serving soup, stew, or sauce",
                    Rating = 5
                }
            );
            context.SaveChanges();
        }
    }
}
