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
            Orders orders= new Orders();
            orders.MdiParent = this;
            orders.Show();
        }

        private void OurCustomarsButton_Click(object sender, EventArgs e)
        {
            Castomars castomars = new Castomars();
            castomars.MdiParent = this;
            castomars.Show();
        }

        private void ProductsDashpordButton_Click(object sender, EventArgs e)
        {
            Products products = new Products();
            products.MdiParent = this;
            products.Show();
        }

        private void OursuppliersButton_Click(object sender, EventArgs e)
        {
            Suppliers suppliers = new Suppliers();
            suppliers.MdiParent = this;
            suppliers.Show();
        }
    }
}
