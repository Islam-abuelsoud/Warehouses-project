using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouses
{
    public partial class BaseForm : Form
    {
        private Orders ordersForm;
        private CustomarForm customarsForm;

        private Products productsForm;
        //private Suppliers suppliersForm;
        private SuppliersForm suppliersForm;
        string falg = "";

        public BaseForm()
        {
            InitializeComponent();
        }

        private void OrderDashpordButton_Click(object sender, EventArgs e)
        {
            falg = "order";
            if (ordersForm != null && !ordersForm.IsDisposed)
            {
                ordersForm.Close(); // Close the existing instance
            }
            ordersForm = new Orders(); // Create a new instance
            ordersForm.MdiParent = this;
            ordersForm.Show();
        }

        private void OurCustomarsButton_Click(object sender, EventArgs e)
        {
            falg = "Cust";
            if (customarsForm != null && !customarsForm.IsDisposed)
            {
                customarsForm.Close(); // Close the existing instance
            }
            customarsForm = new CustomarForm(); // Create a new instance
            customarsForm.MdiParent = this;
            customarsForm.Show();
        }

        private void ProductsDashpordButton_Click(object sender, EventArgs e)
        {
            falg = "Product";
            if (productsForm != null && !productsForm.IsDisposed)
            {
                productsForm.Close(); // Close the existing instance
            }
            productsForm = new Products(); // Create a new instance
            productsForm.MdiParent = this;
            productsForm.Show();
        }

        public void OursuppliersButton_Click(object sender, EventArgs e)
        {
            falg = "supp";
            if (suppliersForm != null && !suppliersForm.IsDisposed)
            {
                suppliersForm.Close(); // Close the existing instance
            }
            suppliersForm = new SuppliersForm(); // Create a new instance
            suppliersForm.MdiParent = this;
            suppliersForm.Show();
        }

        private void SearchPar_TextChanged(object sender, EventArgs e)
        {
            switch (falg)
            {
                case "order":
                   
                    break;
                case "Cust":
                    
                    break;
                case "Product":
                   
                    break;
                case "supp":
                  
                default:

                    break;
            }
        }
    }
}
