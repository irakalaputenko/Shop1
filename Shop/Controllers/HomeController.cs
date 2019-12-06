using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
using Shop.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private IAllVegetables _vegetablesRep;
        
        public HomeController(IAllVegetables vegetablesRep)
        {
            _vegetablesRep = vegetablesRep;
        } 

        public ViewResult Index()
        {
            var homeVegetables = new HomeViewModel
            {
                favVegetables = _vegetablesRep.getFavVegetables
            };
            return View(homeVegetables);
        }
    }
}
