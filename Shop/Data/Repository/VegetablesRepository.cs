using Microsoft.EntityFrameworkCore;
using Shop.Data.interfaces;
using Shop.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Repository
{
    public class VegetablesRepository : IAllVegetables
    {
        private readonly AppDBContent appDBContent;
        public VegetablesRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Vegetables> Vegetables => appDBContent.Vegetables.Include(c=> c.Category);

        public IEnumerable<Vegetables> getFavVegetables => appDBContent.Vegetables.Where(p => p.isFavourite).Include(c => c.Category);

        public Vegetables getObjectVegetables(int vegetablesId) => appDBContent.Vegetables.FirstOrDefault(p => p.id == vegetablesId);
    }
}
