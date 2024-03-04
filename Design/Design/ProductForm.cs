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

    public partial class ProductForm : Form
    {
        // Initialize SQL connection
        Warehouses_CompanyEntities1 Db = new Warehouses_CompanyEntities1();
        private DataRow selectedRowData;
        public ProductForm()
        {
            InitializeComponent();
            //dataGridViewProducts.DataSource = Db.Products.ToList();
            dataGridViewProducts.DataSource = Db.Products.Select(p => new { p.ID, p.Name, p.Quantity, p.Price }).ToList();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            // Retrieve search criteria
            string nameSearch = ProductNameSearch.Text.Trim();

            decimal priceSearch;
            bool validPrice = decimal.TryParse(ProductPriceSearch.Text.Trim(), out priceSearch);

            // Filter products based on search criteria
            var filteredProducts = Db.Products.AsQueryable(); // Start with all products
            if (!string.IsNullOrEmpty(nameSearch))
            {
                filteredProducts = filteredProducts.Where(x => x.Name.Contains(nameSearch));
            }
            
            if (validPrice)
            {
                filteredProducts = filteredProducts.Where(x => x.Price == priceSearch);
            }

            // Display filtered products in dataGridViewProducts
            //dataGridViewProducts.DataSource = filteredProducts.ToList();
            dataGridViewProducts.DataSource = Db.Products.Select(p => new { p.ID, p.Name, p.Quantity, p.Price }).ToList();
        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
            dataGridViewProducts.DataSource = Db.Products.Select(p => new { p.ID, p.Name, p.Quantity, p.Price }).ToList();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewProducts.CurrentCell.RowIndex;

            // Retrieve the data from the selected row
            int ID = int.Parse(dataGridViewProducts.Rows[rowIndex].Cells["ID"].Value.ToString());
            string name = dataGridViewProducts.Rows[rowIndex].Cells["Name"].Value.ToString();
            decimal price = decimal.Parse(dataGridViewProducts.Rows[rowIndex].Cells["Price"].Value.ToString());
            int quantity = int.Parse(dataGridViewProducts.Rows[rowIndex].Cells["Quantity"].Value.ToString());

            //Open the Edit_Product form and pass the dataGridViewProducts control and the data
            Edit_Product edit_Product = new Edit_Product(dataGridViewProducts, ID, name, price, quantity);
            edit_Product.ShowDialog();
        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            // Open the Add_Product form
            Add_Product add_Product = new Add_Product(dataGridViewProducts);
            add_Product.ShowDialog();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            var ID = int.Parse(dataGridViewProducts.CurrentRow.Cells[0].Value.ToString());
            var product = Db.Products.Find(ID);

            // Check if there are any orders associated with the product
            //if (product.order_item.Any())
            //{
            //    MessageBox.Show("Cannot delete the product because it is associated with orders.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            // If there are no orders associated, proceed with deletion
            Db.Products.Remove(product);
            Db.SaveChanges();
            MessageBox.Show("Product deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //dataGridViewProducts.DataSource = Db.Products.ToList();
            dataGridViewProducts.DataSource = Db.Products.Select(p => new { p.ID, p.Name, p.Quantity, p.Price }).ToList();

        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
