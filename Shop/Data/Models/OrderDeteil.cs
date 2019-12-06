using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class OrderDeteil
    {

        public int id { get; set; }

        public int orderId { get; set; }

        public int vegetablesId { get; set; }

        public uint price { get; set; }

        public virtual Vegetables vegetables { get; set; }

        public virtual Order order { get; set; }


    }
}
