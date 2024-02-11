using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouses;

namespace Desktop_App
{
    public partial class Edit_Product : Form
    {
        // Initialize SQL connection
        private int ID;
        private DataGridView dataGridViewProducts;

        public Edit_Product(DataGridView dataGridViewProducts, int id, string name, string description, decimal price, int quantity)
        {
            InitializeComponent();

            // Assign the dataGridViewProducts control to a field
            this.dataGridViewProducts = dataGridViewProducts;
            ID = id;

            // Display the data in textboxes
            Nametxt.Text = name;
            Descriptiontxt.Text = description;
            Pricetxt.Text = price.ToString();
            Quantitytxt.Text = quantity.ToString();
        }
        private void Savebtn_Click(object sender, EventArgs e)
        {
            // Get the modified data from textboxes
            string newName = Nametxt.Text;
            string newDescription = Descriptiontxt.Text;
            decimal newPrice = decimal.Parse(Pricetxt.Text);
            int newQuantity = int.Parse(Quantitytxt.Text);

            // Update the corresponding row in the main form's DataGridView
            DataGridViewRow row = dataGridViewProducts.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["ID"].Value.ToString().Equals(ID.ToString()))
                .First();

            row.Cells["Name"].Value = newName;
            row.Cells["Description"].Value = newDescription;
            row.Cells["Price"].Value = (int)newPrice;
            row.Cells["Quantity"].Value = newQuantity;
            // Save changes to the database
            using (var context = new Warehouses_CompanyEntities())
            {
                int productId = int.Parse(row.Cells["ID"].Value.ToString());
                var product = context.Products.FirstOrDefault(p => p.ID == productId);
                if (product != null)
                {
                    product.Name = newName;
                    //product.Description = newDescription;
                    product.Price = (int)newPrice;
                    product.Quantity = newQuantity;
                    context.SaveChanges();
                }
            }

            // Close the Edit_Product form
            this.Close();
        }

    }
}
