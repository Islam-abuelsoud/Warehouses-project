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
    public partial class Edit_Employee : Form
    {
        private int ID;
        private DataGridView dataGridViewEmployees;
        public Edit_Employee(DataGridView dataGridViewEmployees, int id, string name, string phone, string email, string type)
        {
            InitializeComponent();
            cmbType.Items.AddRange(new string[] { "manager", "stuff", "delivery" });

            // Assign the dataGridViewEmployees control to a field
            this.dataGridViewEmployees = dataGridViewEmployees;
            ID = id;

            // Display the data in textboxes
            Usernametxt.Text = name;
            guna2TextBox1.Text = phone;
            Emailtxt.Text = email;
            cmbType.SelectedItem = type;
        }

        private void Edit_Employee_Load(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            // Get the modified data from textboxes
            string newName = Usernametxt.Text;
            string newPhone = passwordtxt.Text;
            string newEmail = Emailtxt.Text;
            string newType = cmbType.SelectedItem?.ToString();

            // Check if the new email already exists in the database
            using (var context = new Warehouses_CompanyEntities1())
            {
                var existingEmployee = context.Roles.FirstOrDefault(r => r.Email == newEmail && r.ID != ID);
                if (existingEmployee != null)
                {
                    MessageBox.Show("Email address already exists in the database. Please enter a different email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit the method without saving changes
                }
            }

            // Update the corresponding row in the DataGridView
            DataGridViewRow row = dataGridViewEmployees.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["ID"].Value.ToString().Equals(ID.ToString()))
                .First();

            row.Cells["Name"].Value = newName;
            row.Cells["Phone"].Value = newPhone;
            row.Cells["Email"].Value = newEmail;
            row.Cells["Type"].Value = newType;
         
            // Save changes to the database
            using (var context = new Warehouses_CompanyEntities1())
            {
                var employee = context.Roles.FirstOrDefault(r => r.ID == ID);
                if (employee != null)
                {
                    employee.Name = newName;
                    employee.Phone = newPhone;
                    employee.Email = newEmail;
                    employee.Type = newType;
                    context.SaveChanges();
                }
            }

            // Close the Edit_Product form
            this.Close();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Phonetxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
