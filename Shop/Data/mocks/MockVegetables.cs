using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockVegetables : IAllVegetables
    {
        private readonly IVegetablesCategory _categoryVegetables= new MockCategory();
        public IEnumerable<Vegetables> Vegetables {
            get
            {
                return new List<Vegetables>
                {
                    new Vegetables{ 
                        name="Potato",
                        img="  /img/product-1.jpg",
                        price=20,
                        isFavourite=true,
                        available=true,
                        Category=_categoryVegetables.AllCategories.First()
                    },

                     new Vegetables{
                        name="Lemon",
                        img="/img/product-2.jpg",
                        price=40,
                        isFavourite=true,
                        available=true,
                        Category=_categoryVegetables.AllCategories.First()
                    },

                      new Vegetables{ 
                        name="Potato",
                        img="/img/product-3.jpg",
                        price=20,
                        isFavourite=true,
                        available=true,
                        Category=_categoryVegetables.AllCategories.Last()
                    }

                };
            }
        }
        public IEnumerable<Vegetables> getFavVegetables { get ; set; }

        public Vegetables getObjectVegetables(int vegetablesId)
        {
            throw new NotImplementedException();
        }
    }
}
