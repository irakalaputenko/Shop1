using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.ViewModels
{
    public class VegetablesListViewModel
    {
        public IEnumerable<Vegetables> allVegetables { get; set; }
    
        public string vegetablessCategory { get; set; }
    }
}
