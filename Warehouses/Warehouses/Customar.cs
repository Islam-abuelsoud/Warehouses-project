﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouses
{
    internal class Customar
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<Order> Orders { get; set; }
    }
}
