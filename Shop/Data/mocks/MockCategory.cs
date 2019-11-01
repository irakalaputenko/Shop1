using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.mocks
{
    public class MockCategory : IVegetablesCategory
    {
        public IEnumerable<Category> AllCategories {
            get
            {
                return new List<Category>
                {
                    new Category {categoryName= " Vegetables", desc= "ppppppppppppppppp"},
                    new Category {categoryName= "Fruits", desc= "hhhhhhhhhhhhhhhhh"},
                    new Category {categoryName= "Juice", desc= "jjjjjjjjjjjjjjjj"},
                    new Category {categoryName= "Dried", desc= "ddddddddddddddddd"}

                };
            }
        
        }
    }
}
