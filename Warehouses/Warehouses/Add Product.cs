using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouses;

namespace Desktop_App
{
    public partial class Add_Product : Form
    {
        Warehouses_CompanyEntities Db = new Warehouses_CompanyEntities();
        private DataGridView dataGridViewProducts;

        public Add_Product(DataGridView dataGridViewProducts)
        {
            InitializeComponent();
            this.dataGridViewProducts = dataGridViewProducts;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            // Get the new product details from textboxes
            string name = Nametxt.Text;
            string description = Descriptiontxt.Text;
            int price;
            int quantity;

            // Check if Price text can be parsed to int
            if (!int.TryParse(Pricetxt.Text, out price))
            {
                // Display an error message or set a default price
                MessageBox.Show("Please enter a price for new product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            // Check if Quantity text can be parsed to int
            if (!int.TryParse(Quantitytxt.Text, out quantity))
            {
                // Display an error message or set a default quantity
                MessageBox.Show("Please enter a Qunatity for new product.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // Exit the method
            }

            try
            {
                // Add the new product to the database
                using (var context = new Warehouses_CompanyEntities())
                {
                    var newProduct = new Product
                    {
                        Name = name,
                         
                        Price = price, // Assuming Price in the database is int
                        Quantity = quantity
                    };
                    context.Products.Add(newProduct);
                    context.SaveChanges();
                }

                // Refresh the DataGridView to reflect the changes
                dataGridViewProducts.DataSource = Db.Products.ToList();

                // Close the Add_Product form
                this.Close();
            }
            catch (DbUpdateException ex)
            {
                // An error occurred while saving changes to the database
                MessageBox.Show("An error occurred while saving changes to the database: " + ex.InnerException.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
