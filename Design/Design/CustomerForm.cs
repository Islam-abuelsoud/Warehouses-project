using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Design
{
    public partial class CustomerForm : Form
    {
        Warehouses_CompanyEntities1 context = new Warehouses_CompanyEntities1();
        public CustomerForm()
        {
            InitializeComponent();
        }
        //Create Function To View 
        public void geidView()
        {
            //dataGridView1.DataSource = context.Customers.ToList();
            dataGridView1.DataSource = context.Customers.Select(c => new { c.ID ,c.Name, c.Phone, c.Email, c.Address }).ToList();
        }

      
        //private void showbtn_Click(object sender, EventArgs e)
        //{
        //    //Get All Data From Customer Table 
        //    geidView();

        //}

        private void labelAddCus_Click(object sender, EventArgs e)
        {
            // Open the Add_Product form
            Add_Customer add_Product = new Add_Customer(dataGridView1);
            add_Product.ShowDialog();
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
          
            if (dataGridView1 != null && dataGridView1.CurrentCell != null)
            {
                int rowIndex = dataGridView1.CurrentCell.RowIndex;

                // Retrieve the data from the selected row
                int ID = int.Parse(dataGridView1.Rows[rowIndex].Cells["ID"].Value.ToString());
                string name = dataGridView1.Rows[rowIndex].Cells["Name"].Value.ToString();
                int phone;
                 int.TryParse(dataGridView1.Rows[rowIndex].Cells["phone"].Value.ToString(), out phone);
                string email = dataGridView1.Rows[rowIndex].Cells["Email"].Value.ToString();
                string address = dataGridView1.Rows[rowIndex].Cells["Address"].Value.ToString();

                //Open the update_Customer form and pass the dataGridView1 control and the data
                update_Customer edit_Customer = new update_Customer(dataGridView1, ID, name, phone, email, address);
                edit_Customer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("You will delete this Customer , Are You Sure ?", "warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {

                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var idResult = context.Customers.Find(id);
                context.Customers.Remove(idResult);
                context.SaveChanges();

                geidView();
                MessageBox.Show("Deleted Sucssefuly");

            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            // Retrieve search criteria
            string nameSearch = textSearch.Text.Trim();
            string typeSearch = textSearch.Text.Trim();
            decimal priceSearch;
            bool validPrice = decimal.TryParse(textSearch.Text.Trim(), out priceSearch);

            // Filter products based on search criteria
            var filteredProducts = context.Customers.AsQueryable(); // Start with all products
            if (!string.IsNullOrEmpty(nameSearch))
            {
                filteredProducts = filteredProducts.Where(x => x.Name.Contains(nameSearch));
            }


            // Display filtered products in dataGridViewProducts
            //dataGridView1.DataSource = filteredProducts.ToList();
            dataGridView1.DataSource = context.Customers.Select(c => new { c.Name, c.Phone, c.Email, c.Address }).ToList();

        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            geidView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Resetbtn_Click(object sender, EventArgs e)
        {
           
            dataGridView1.DataSource = context.Customers.Select(c => new { c.Name, c.Phone, c.Email, c.Address }).ToList();
        }

        private void textSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
