﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Data.Models
{
    public class Vegetables
    {
        public int id { get; set; }

        public string name { get; set; }

        public string img { get; set; }

        public ushort price { get; set; }

        public bool isFavourite { get; set; }

        public bool available { get; set; }

        public int categoryID { get; set; }

        public virtual Category Category { get; set;}
    }
}
