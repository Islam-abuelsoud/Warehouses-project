using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    
    public partial class InventoryForm : Form
    {
        Warehouses_CompanyEntities1 context = new Warehouses_CompanyEntities1();
        public InventoryForm()
        {
            InitializeComponent();
            inventoryGride.DataSource = context.Products.Select(p => new { p.ID, p.Name, p.Quantity, p.Price }).ToList();
        }

        private void showQBtn_Click(object sender, EventArgs e)
        {
            inventoryGride.DataSource = context.Products.Select(p => new { p.Name, p.Quantity }).ToList();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Retrieve search criteria
            string nameSearch = searchText.Text.Trim();
            string typeSearch = searchText.Text.Trim();
            decimal priceSearch;
            bool validPrice = decimal.TryParse(searchText.Text.Trim(), out priceSearch);

            // Filter products based on search criteria

            var filteredProducts = context.Products.Select(p => new { p.ID, p.Name, p.Quantity, p.Price }).ToList().AsQueryable(); // Start with all products
            if (!string.IsNullOrEmpty(nameSearch))
            {
                filteredProducts = filteredProducts.Where(p => p.Name.Contains(nameSearch));
            }


            // Display filtered products in dataGridViewProducts
            inventoryGride.DataSource = filteredProducts.ToList();
        }

        private void InventoryForm_Load(object sender, EventArgs e)
        {

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {

        }

        private void resetbtn_Click(object sender, EventArgs e)
        {
            inventoryGride.DataSource = context.Products.Select(p => new { p.ID, p.Name, p.Quantity, p.Price }).ToList();
        }
    }
}
