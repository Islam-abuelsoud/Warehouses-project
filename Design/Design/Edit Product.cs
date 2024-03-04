using Guna.UI2.WinForms.Suite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Design
{
    public partial class Edit_Product : Form
    {
        Warehouses_CompanyEntities1 Db = new Warehouses_CompanyEntities1();
        // Initialize SQL connection
        private int ID;
        private DataGridView dataGridViewProducts;
        public Edit_Product(DataGridView dataGridViewProducts, int id, string name, decimal price, int quantity)
        {
            InitializeComponent();
            // Assign the dataGridViewProducts control to a field
            this.dataGridViewProducts = dataGridViewProducts;
            ID = id;

            // Display the data in textboxes
            Nametxt.Text = name;
            Pricetxt.Text = price.ToString();
            Quantitytxt.Text = quantity.ToString();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            // Get the modified data from textboxes
            string newName = Nametxt.Text;

            decimal newPrice = decimal.Parse(Pricetxt.Text);
            int newQuantity = int.Parse(Quantitytxt.Text);

            // Update the corresponding row in the main form's DataGridView
            DataGridViewRow row = dataGridViewProducts.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["ID"].Value.ToString().Equals(ID.ToString()))
                .First();

            row.Cells["Name"].Value = newName;
            row.Cells["Price"].Value = (int)newPrice;
            row.Cells["Quantity"].Value = newQuantity;
            // Save changes to the database
            using (var context = new Warehouses_CompanyEntities1())
            {
                int productId = int.Parse(row.Cells["ID"].Value.ToString());
                var product = context.Products.FirstOrDefault(p => p.ID == productId);
                if (product != null)
                {
                    product.Name = newName;

                    product.Price = (int)newPrice;
                    product.Quantity = newQuantity;
                    context.SaveChanges();
                    dataGridViewProducts.DataSource = Db.Products.Select(p => new { p.ID, p.Name, p.Quantity, p.Price }).ToList();
                }
            }

            //string newName = Nametxt.Text;
            //decimal newPrice = decimal.Parse(Pricetxt.Text);
            //int newQuantity = int.Parse(Quantitytxt.Text);

            //try
            //{
            //    // Update the corresponding row in the main form's DataGridView
            //    DataGridViewRow row = dataGridViewProducts.Rows
            //        .Cast<DataGridViewRow>()
            //        .Where(r => r.Cells["ID"].Value.ToString().Equals(ID.ToString()))
            //        .FirstOrDefault();

            //    if (row != null)
            //    {
            //        row.Cells["Name"].Value = newName;
            //        //row.Cells["Price"].Value = newPrice;
            //        row.Cells["Price"].Value = (int)newPrice;
            //        row.Cells["Quantity"].Value = newQuantity;
            //    }

            //    // Save changes to the database
            //    using (var context = new Warehouses_CompanyEntities1())
            //    {
            //        int productId = int.Parse(row.Cells["ID"].Value.ToString());
            //        var product = context.Products.FirstOrDefault(p => p.ID == productId);
            //        if (product != null)
            //        {
            //            product.Name = newName;
            //            //product.Price = newPrice;
            //            product.Price = (int)newPrice;
            //            product.Quantity = newQuantity;
            //            context.SaveChanges();
            //            //dataGridViewProducts.DataSource = Db.Products.Select(p => new { p.ID, p.Name, p.Quantity, p.Price }).ToList();
            //        }
            //    }

            //    // Display success message
            //    MessageBox.Show("Product information updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}
            //catch (Exception ex)
            //{
            //    // Display error message if an exception occurs
            //    MessageBox.Show("An error occurred while updating the product information: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            // Close the Edit_Product form
            this.Close();



        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
