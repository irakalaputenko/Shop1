using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class ShopCartItem
    {
        public int Id { get; set; }
        public Vegetables vegetables { get; set; }
        public int price { get; set; }

        public string ShopCartId { get; set; }
    }
}
