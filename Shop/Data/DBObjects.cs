using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContent content)
        {
            if (!content.Category.Any())
                content.Category.AddRange(Categories.Select(c => c.Value));

            if (!content.Vegetables.Any())
            {
                 
               content.AddRange(
                    new Vegetables
                    {
                        name = "BELL PEPPER",
                        img = "/img/product-1.jpg",
                        price = 80,
                        isFavourite = true,
                        available = true,
                        Category = Categories["Vegetables"]
                    },

                     new Vegetables
                     {
                         name = "STRAWBERRY",
                         img = "/img/product-2.jpg",
                         price = 120,
                         isFavourite = true,
                         available = true,
                         Category = Categories["Fruits"]
                     },

                      new Vegetables
                      {
                          name = "Green Beans",
                          img = "/img/product-3.jpg",
                          price = 120,
                          isFavourite = true,
                          available = true,
                          Category = Categories["Vegetables"]
                      },

                      new Vegetables
                      {
                          name = "PURPLE CABBAGE",
                          img = "/img/product-4.jpg",
                          price = 120,
                          isFavourite = true,
                          available = true,
                          Category = Categories["Vegetables"]
                      },

                      new Vegetables
                      {
                          name = "Tomatoe",
                          img = "/img/product-5.jpg",
                          price = 40,
                          isFavourite = true,
                          available = true,
                          Category = Categories["Vegetables"]
                      },

                      new Vegetables
                      {
                          name = "Brocolli",
                          img = "/img/product-6.jpg",
                          price = 50,
                          isFavourite = true,
                          available = true,
                          Category = Categories["Vegetables"]
                      },

                      new Vegetables
                      {
                          name = "Carrots",
                          img = "/img/product-7.jpg",
                          price = 20,
                          isFavourite = true,
                          available = true,
                          Category = Categories["Vegetables"]
                      },
                       new Vegetables
                       {
                           name = "Fruit Juice",
                           img = "/img/product-8.jpg",
                           price = 60,
                           isFavourite = true,
                           available = true,
                           Category = Categories["Juice"]
                       }
                       
                    ) ;
            }

            content.SaveChanges();

        }

        public static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new Category[]
                    {
                        new Category { categoryName = " Vegetables", desc = "Fresh vegetables" },
                        new Category { categoryName = "Fruits", desc = "Fresh fruits" },
                        new Category { categoryName = "Juice", desc = "Fresh juice" },
                        new Category { categoryName = "Dried", desc = "Fresh dried" }
                    };
                    category = new Dictionary<string, Category>();
                    foreach (Category el in list)
                        category.Add(el.categoryName, el);
                }
                return category;
            }

        }
    }
}
