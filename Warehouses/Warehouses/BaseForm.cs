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
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void OrderDashpordButton_Click(object sender, EventArgs e)
        {
            OrdersForm orders= new OrdersForm();
            orders.MdiParent = this;
            orders.Show();
        }

        private void OurCustomarsButton_Click(object sender, EventArgs e)
        {
            CustomarsForm castomars = new CustomarsForm();
            castomars.MdiParent = this;
            castomars.Show();
        }

        private void ProductsDashpordButton_Click(object sender, EventArgs e)
        {
            ProductsForm products = new ProductsForm();
            products.MdiParent = this;
            products.Show();
        }

        private void OursuppliersButton_Click(object sender, EventArgs e)
        {
            SuppliersForm suppliers = new SuppliersForm();
            suppliers.MdiParent = this;
            suppliers.Show();
        }
    }
}
