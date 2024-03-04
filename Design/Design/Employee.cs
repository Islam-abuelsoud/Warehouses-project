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
    public partial class Employee : Form
    {
        Warehouses_CompanyEntities1 Db = new Warehouses_CompanyEntities1();
        public Employee()
        {
            InitializeComponent();
            LoadEmployeeData();
            // Set the items of the combo box for types
            //cmbType.Items.AddRange(new string[] { "manager", "stuff", "delivery" });
        }
        private void LoadEmployeeData()
        {
            try
            {
                dataGridViewEmployee.DataSource = Db.Roles.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading employee data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            // Get the ID of the selected row
            var ID = int.Parse(dataGridViewEmployee.CurrentRow.Cells["ID"].Value.ToString());

            // Find the role entry with the corresponding ID in the database
            var role = Db.Roles.Find(ID);
            // If there are no associations, proceed with deletion
            Db.Roles.Remove(role);
            Db.SaveChanges();

            // Show a success message
            MessageBox.Show("Employee deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Update the DataGridView to reflect the changes
            dataGridViewEmployee.DataSource = Db.Roles.ToList();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            // Check if any rows are selected
            if (dataGridViewEmployee.SelectedRows.Count > 0)
            {
                // Retrieve data from the first selected row
                int ID = Convert.ToInt32(dataGridViewEmployee.SelectedRows[0].Cells["ID"].Value);
                string name = Convert.ToString(dataGridViewEmployee.SelectedRows[0].Cells["Name"].Value);
                string phone = Convert.ToString(dataGridViewEmployee.SelectedRows[0].Cells["Phone"].Value);
                string email = Convert.ToString(dataGridViewEmployee.SelectedRows[0].Cells["Email"].Value);
                string type = Convert.ToString(dataGridViewEmployee.SelectedRows[0].Cells["Type"].Value);

                // Open the Edit_Product form with the selected data
                Edit_Employee editForm = new Edit_Employee(dataGridViewEmployee, ID, name, phone, email, type);
                editForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            // Retrieve search criteria
            string nameSearch = EmployeeNameSearch.Text.Trim();
            string phoneSearch = EmployeePhoneSearch.Text.Trim();

            // Filter employees based on search criteria
            var filteredEmployees = Db.Roles.AsQueryable(); // Start with all employees
            if (!string.IsNullOrEmpty(nameSearch))
            {
                filteredEmployees = filteredEmployees.Where(x => x.Name.Contains(nameSearch));
            }
            if (!string.IsNullOrEmpty(phoneSearch))
            {
                filteredEmployees = filteredEmployees.Where(x => x.Phone.Contains(phoneSearch));
            }

            // Display filtered employees in dataGridViewEmployee
            dataGridViewEmployee.DataSource = filteredEmployees.ToList();
        }

        //private void Resetbtn_Click(object sender, EventArgs e)
        //{
        //    dataGridViewEmployee.DataSource = Db.Roles.ToList();
        //}

        private void Savebtn_Click(object sender, EventArgs e)
        {
            Add_Employee employee = new Add_Employee();
            employee.EmployeeAdded += EmployeeAddedHandler;
            employee.ShowDialog();

        }

        private void EmployeeAddedHandler(object sender, EventArgs e)
        {
            // This method is called when the EmployeeAdded event is raised
            // Reload the DataGridView to reflect the changes made by adding a new employee
            LoadEmployeeData();
        }

        private void Resetbtn_Click_1(object sender, EventArgs e)
        {
            dataGridViewEmployee.DataSource = Db.Roles.ToList();
        }
    }
}
