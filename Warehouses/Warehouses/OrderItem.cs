using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouses
{
    internal class OrderItem
    {
        public int Id { get; set; }
        public string Disc { get; set; }
        public int Quantity { get; set; }
        public int Coust { get; set; }
        public Order order { get; set; }
        public Product product { get; set; }
    }
}
