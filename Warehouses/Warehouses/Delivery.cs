using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouses
{
    internal class Delivery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public DateTime date { get; set; }
        public string State { get; set; }
        public Order order { get; set; }
    }
}
