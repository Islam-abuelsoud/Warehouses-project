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
        Warehouses_CompanyEntities context = new Warehouses_CompanyEntities();
        

        public OrdersForm()
        {
            InitializeComponent();
            //ProdQuantityTextBox.Text = "0";
            var productNames = context.Products.Select(x => x.Name).ToList();
            prodNameComboBox.DataSource = productNames;
            var CustomarsNames = context.Customers.Select(x => x.Name).ToList();
            CustoComboBox.DataSource = CustomarsNames;
            var SuppliersNames = context.Suppliers.Select(x => x.Name).ToList();
            SuppliersComboBox.DataSource = SuppliersNames;
            List<string> comboBoxValues = new List<string> { "sales", "purchases" };
            TypeComboBox.DataSource = comboBoxValues;
            List<string> xxx = new List<string> { "pending", "Done" };
            StateComboBox.DataSource = xxx;

            var data =[];
        }

        private void prodNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = prodNameComboBox.SelectedItem.ToString();
            var price = context.Products.Where(n => n.Name == selectedValue).Select(p => p.Price).FirstOrDefault();
            ProdpriceTextBox.Text = price.ToString();

        }

        private void ProdQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            float p = 1;
            if ( ProdQuantityTextBox.Text != "")
            {
                p = int.Parse(ProdQuantityTextBox.Text);
            }
            var q = int.Parse(ProdpriceTextBox.Text);
            var x = q * p;
            total.Text = x.ToString();
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
