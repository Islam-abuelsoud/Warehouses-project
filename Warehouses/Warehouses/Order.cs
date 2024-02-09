using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouses
{
    internal class Order
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public string State { get; set; }
        public Transaction transaction { get; set; }
        public Delivery delivery { get; set; }
        public Customar customar { get; set; }
        public Supplier supplier { get; set; }
        public List<OrderItem> Orderitems { get; set; }
        public List<Inventory> Inventorys { get; set; }


    }
}
