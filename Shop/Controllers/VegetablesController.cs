using Microsoft.AspNetCore.Mvc;
using Shop.Data.interfaces;
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

        public ViewResult List()
        {
            ViewBag.Title = "Page with Vegetables";
            VegetablesListViewModel obj = new VegetablesListViewModel();
            obj.allVegetables = _allVegetables.Vegetables;
            obj.vegetablessCategory = "VEGETABLES";
            return View(obj);
        }

    }
}
