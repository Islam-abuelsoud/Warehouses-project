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
using Warehouses;

namespace Design
{
    public partial class SupplierForm : Form
    {
        Warehouses_CompanyEntities context = new Warehouses_CompanyEntities();
        public SupplierForm()
        {
            InitializeComponent();
        }
        //Create Function To View 
        public void geidView()
        {
            dataGridView1.DataSource = context.Suppliers.ToList();
        }

      
        private void showbtn_Click(object sender, EventArgs e)
        {
            //Get All Data From Supplier Table 
            geidView();

        }

        private void labelAddCus_Click(object sender, EventArgs e)
        {
            // Open the Add_Product form
            AddSupplier add_Product = new AddSupplier(dataGridView1);
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

                //Open the update_Supplier form and pass the dataGridView1 control and the data
                update_Supplier edit_Supplier = new update_Supplier(dataGridView1, ID, name, phone, email, address);
                edit_Supplier.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView.");
            }

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            var result = MessageBox.Show("Youer will delet", "warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (result == DialogResult.OK)
            {

                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var idResult = context.Suppliers.Find(id);
                context.Suppliers.Remove(idResult);

                context.SaveChanges();

                geidView();
                MessageBox.Show("Deleted Sucssefuly");

            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
