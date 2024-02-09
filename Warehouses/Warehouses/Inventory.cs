using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouses
{
    internal class Inventory
    {
        public int Id { get; set; }
        public int ProductQ { get; set; }
        public int OrderQ { get; set; }
        public int OrderCost { get; set; }
        public string type { get; set; }
        public Order order { get; set; }
        public List<Product> products { get; set; }


    }
}
