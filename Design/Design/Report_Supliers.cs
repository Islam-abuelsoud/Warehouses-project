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
    public partial class Report_Supliers : Form
    {
        Warehouses_CompanyEntities1 context = new Warehouses_CompanyEntities1();
        bool check;
        public Report_Supliers()
        {
            InitializeComponent();
        }

        private void getDataBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Git All Suppliers 
                Grid1.DataSource = context.Suppliers.Select(s => new { s.ID, s.Name, s.Phone, s.Address, s.Email, s.Orders }).ToList();
                check = true;
            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the Suppliers: " + ex.Message);
            }

        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Retrieve search criteria
            string nameSearch = textSearch.Text.Trim();
            string typeSearch = textSearch.Text.Trim();
            decimal priceSearch;
            bool validPrice = decimal.TryParse(textSearch.Text.Trim(), out priceSearch);

            // Filter products based on search criteria
            var filteredProducts = context.Suppliers.AsQueryable(); // Start with all products
            if (!string.IsNullOrEmpty(nameSearch))
            {
                filteredProducts = filteredProducts.Where(x => x.Name.Contains(nameSearch));
            }


            // Display filtered products in dataGridViewProducts
            Grid1.DataSource = filteredProducts.ToList();
            check = true;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (check)
            {
                // When the print button is clicked, open the Print Form

                Report_Suppliers_View printForm = new Report_Suppliers_View();
                printForm.ShowDialog();

            }

            else
            {
                MessageBox.Show("Please Get Suppliers First");
            }
        }
    }
}
