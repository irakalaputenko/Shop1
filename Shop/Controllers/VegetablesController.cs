using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class VegetablesController : Controller{

        private readonly IAllVegetables _allVegetables;
        private readonly IVegetablesCategory _allCategories;

        public VegetablesController(IAllVegetables iAllVegetables, IVegetablesCategory iVegetablesCat)
        {
            _allVegetables = iAllVegetables;
            _allCategories = iVegetablesCat;
        }

        [Route("Vegetables/List")]
        [Route("Vegetables/List/{category}")]
        public ViewResult List(string category)
        {
            string _category = category;
            IEnumerable<Vegetables> vegetables = null;
            string vegetablesCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                vegetables = _allVegetables.Vegetables.OrderBy(i => i.id);
            } else
            {
                if(string.Equals("vegetables", category, StringComparison.OrdinalIgnoreCase))
                {
                    vegetables = _allVegetables.Vegetables.Where(i => i.Category.categoryName.Equals(" Vegetables")).OrderBy(i => i.id);
                    vegetablesCategory = _category;
                }
                else if (string.Equals("fruits", category, StringComparison.OrdinalIgnoreCase))
                    {
                        vegetables = _allVegetables.Vegetables.Where(i => i.Category.categoryName.Equals("Fruits")).OrderBy(i => i.id);
                        vegetablesCategory = _category;
                    }
                    else if (string.Equals("juice", category, StringComparison.OrdinalIgnoreCase))
                        {
                            vegetables = _allVegetables.Vegetables.Where(i => i.Category.categoryName.Equals("Juice")).OrderBy(i => i.id);
                            vegetablesCategory = _category;
                        }
                        else if (string.Equals("dried", category, StringComparison.OrdinalIgnoreCase))
                        {
                            vegetables = _allVegetables.Vegetables.Where(i => i.Category.categoryName.Equals("Dried")).OrderBy(i => i.id);
                            vegetablesCategory = _category;
                        }
                        
                    
                   

                   
               
            }
            var vegetablesObj = new VegetablesListViewModel
            {
                allVegetables = vegetables,
                vegetablessCategory = vegetablesCategory
            };

            ViewBag.Title = "Page with Goods";
            
            return View(vegetablesObj);
        }

    }
}
