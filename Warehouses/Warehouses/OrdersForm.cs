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
        List<order_item> Items = new List<order_item>();

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
            List<string> comboBoxValues = new List<string> { "Sell", "Buy" };
            TypeComboBox.DataSource = comboBoxValues;
            List<string> xxx = new List<string> { "In progress", "Done" };
            StateComboBox.DataSource = xxx;

            //var data =[];
        }
        public void GetItems()
        {
            ItemsDataGridView.DataSource = "";
            ItemsDataGridView.DataSource = Items;
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
            if (ProdQuantityTextBox.Text != "")
            {
                p = int.Parse(ProdQuantityTextBox.Text);
            }
            var q = int.Parse(ProdpriceTextBox.Text);
            var x = q * p;
            total.Text = x.ToString();
        }

        private void Addlabel_Click(object sender, EventArgs e)
        {
            order_item newI = new order_item();
            newI.Product_Name = prodNameComboBox.SelectedItem.ToString();
            newI.Price = int.Parse(ProdpriceTextBox.Text);
            newI.Total_Cost = int.Parse(total.Text);
            newI.Quantity = int.Parse(ProdQuantityTextBox.Text);
            //newI.OrdersID = 
            Items.Add(newI);
            GetItems();
        }

        private void SaveOrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Date = DateTime.Now;
            order.State = StateComboBox.SelectedItem.ToString();
            //order.Customer_ID = 0;
            //order.Supplier_ID = 0;
            order.Quantity = 0;
            order.Total_cost = 0;
            order.Type = TypeComboBox.SelectedItem.ToString();
            context.Orders.Add(order);
            context.SaveChanges();
            foreach (var item in Items)
            {
                item.OrderID = order.ID;
            }
            context.order_item.AddRange(Items);
            context.SaveChanges();

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
