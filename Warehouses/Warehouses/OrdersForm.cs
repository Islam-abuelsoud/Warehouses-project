using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouses
{
    public partial class OrdersForm : Form
    {
        public OrdersForm()
        {
            InitializeComponent();
            Warehouses_CompanyEntities context = new Warehouses_CompanyEntities();
            //var data = context.GetOrdersData();
        }

       /// product opj={} => table product =====
       /// 
       /// 
       /// 
       /// order opj={} => tale order
       /// order ID => make table 
       /// prod ID => make table
       /// 

    }
}
