﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouses
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public string Image { get; set; }
        public List<OrderItem> OrderItems { get; set; }
        public Inventory Inventory { get; set; }

    }
}