using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class OrderForm : Form
    {
        Warehouses_CompanyEntities1 context = new Warehouses_CompanyEntities1();
        List<order_item> Items = new List<order_item>();

        public OrderForm()
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
            dataGridView1.DataSource = "";
            //dataGridView1.DataSource = Items;
            dataGridView1.DataSource = Items.Select(e => new {e.ItemId , e.Product_Name, e.Price, e.Quantity, e.TotalCost, e.OrderID }).ToList();
        }
        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void Addlabel_Click(object sender, EventArgs e)
        {
            order_item newI = new order_item();
            newI.Product_Name = prodNameComboBox.SelectedItem.ToString();
            newI.Price = int.Parse(ProdpriceTextBox.Text);
            if (total.Text == "")
            {
                MessageBox.Show("U mast enter Quantity");
                return;
            }
            newI.Total_Cost = int.Parse(total.Text);
            newI.Quantity = int.Parse(ProdQuantityTextBox.Text);
            //newI.OrdersID = 
            var item = Items.FirstOrDefault(i => i.Product_Name == newI.Product_Name);
            if (item == null)
                Items.Add(newI);
            else
                item.Quantity += newI.Quantity;
            GetItems();
            clear();


        }

        private void UpdatesupBtn_Click(object sender, EventArgs e)
        {
            ////1 - Update Customer 
            //try
            //{

            //    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            //    //// Find the order_item with the corresponding ID in the Items list
            //    var upResult = Items.FirstOrDefault(x => x.ItemId == id);

            //    //string name = dataGridView1.CurrentRow.Cells["Product_Name"].Value.ToString();

            //    //// Find the order_item with the corresponding ID in the Items list
            //    //var upResult = Items.FirstOrDefault(x => x.Product_Name == name);

            //    if (upResult != null)
            //    {
            //        // Update the properties of the found order_item
            //        upResult.Product_Name = dataGridView1.CurrentRow.Cells["Product_Name"].Value.ToString();
            //        upResult.Price = int.Parse(dataGridView1.CurrentRow.Cells["Price"].Value.ToString());
            //        upResult.TotalCost = int.Parse(dataGridView1.CurrentRow.Cells["TotalCost"].Value.ToString());
            //        upResult.Quantity = int.Parse(dataGridView1.CurrentRow.Cells["Quantity"].Value.ToString());

            //        MessageBox.Show("Updated Successfully");
            //        GetItems();
            //    }
            //    else
            //    {
            //        MessageBox.Show("Item not found");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("An error occurred while Updating the customer: " + ex.Message);
            //}
        }

        private void Deletesup_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to delete this item?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.OK)
            {
                try
                {
                    int id = int.Parse(dataGridView1.CurrentRow.Cells["ItemId"].Value.ToString());

                    // Find the item with the matching ID in the Items list
                    var itemToDelete = Items.FirstOrDefault(x => x.ItemId == id);

                    //string productName = dataGridView1.CurrentRow.Cells["Product_Name"].Value.ToString();

                    //// Find the item with the matching ID in the Items list
                    //var itemToDelete = Items.FirstOrDefault(x => x.Product_Name == productName);

                    if (itemToDelete != null)
                    {
                        // Remove the item from the Items list
                        Items.Remove(itemToDelete);

                        // Refresh the DataGridView to reflect the changes
                        GetItems();

                        MessageBox.Show("Deleted successfully");

                    }
                    else
                    {
                        MessageBox.Show("Item not found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while deleting the item: " + ex.Message);
                }
            }
        }

        private void prodNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = prodNameComboBox.SelectedItem.ToString();
            var price = context.Products.Where(n => n.Name == selectedValue).Select(p => p.Price).FirstOrDefault();
            ProdpriceTextBox.Text = price.ToString();
        }

        private void ProdQuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            var prod = prodNameComboBox.Text;
            Product item = context.Products.Where(pr => pr.Name == prod).FirstOrDefault();
            var quan = item.Quantity;
            int lapq = 1;
            if (ProdQuantityTextBox.Text != "")
            {
                lapq = int.Parse(ProdQuantityTextBox.Text);
            }
            var lapp = int.Parse(ProdpriceTextBox.Text);
            if (TypeComboBox.Text == "Sell")
            {
                if (lapq > quan)
                {
                    MessageBox.Show($"Quantity is low U need to make some orders we have : {quan} items");
                    clear();
                    return;
                }
                Checker(item, lapq);
            }
            var x = lapp * lapq;
            total.Text = x.ToString();
        }
        public void Checker(Product product, int Quant)
        {
            var item = Items.FirstOrDefault(i => i.Product_Name == product.Name);
            if (item != null)
            {
                if (product.Quantity < (item.Quantity + Quant))
                {
                    MessageBox.Show($"Quantity is low U need to make some orders we have : {product.Quantity} items");
                    clear();
                    return;
                }
            }
        }

        private void SaveOrderButton_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            order.Date = DateTime.Now;
            order.State = StateComboBox.SelectedItem.ToString();
            order.Customer_ID = context.Customers.Where(c => c.Name == CustoComboBox.Text).Select(c => c.ID).FirstOrDefault();
            order.Supplier_ID = context.Suppliers.Where(s => s.Name == SuppliersComboBox.Text).Select(s => s.ID).FirstOrDefault();
            order.Quantity = Items.Count();
            //int tot = 0; 
            order.Total_cost = 0;
            foreach (var item in Items)
            {
                order.Total_cost += item.Total_Cost;
            }
            order.Type = TypeComboBox.SelectedItem.ToString();
            context.Orders.Add(order);
            context.SaveChanges();
            if (TypeComboBox.Text == "Sell")
            {
                foreach (var item in Items)
                {
                    item.OrderID = order.ID;
                    var xx = context.Products.Where(p => p.Name == item.Product_Name).FirstOrDefault();
                    xx.Quantity -= item.Quantity;
                }
            }
            else if (TypeComboBox.Text == "Buy")
            {
                foreach (var item in Items)
                {
                    item.OrderID = order.ID;
                    var xx = context.Products.Where(p => p.Name == item.Product_Name).FirstOrDefault();
                    xx.Quantity += item.Quantity;
                    xx.Price = item.Price;
                }
            }

            context.order_item.AddRange(Items);
            context.SaveChanges();
            MessageBox.Show("order saved");
            clear();
            Items.Clear();
            GetItems();

        }

        public void clear()
        {
            ProdQuantityTextBox.Text = "";
            total.Text = "";


        }

        private void TypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TypeComboBox.Text == "Sell")
            {
                label3.Hide();
                SuppliersComboBox.Hide();
                label2.Show();
                CustoComboBox.Show();
                ProdpriceTextBox.ReadOnly = true;
            }
            else
            {
                ProdpriceTextBox.ReadOnly = false;
                label2.Hide();
                CustoComboBox.Hide();
                label3.Show();
                SuppliersComboBox.Show();
            }
        }

        private void StateComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
