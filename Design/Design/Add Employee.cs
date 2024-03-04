using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class Add_Employee : Form
    {
        Warehouses_CompanyEntities1 Db = new Warehouses_CompanyEntities1();
        public delegate void EmployeeAddedEventHandler(object sender, EventArgs e);
        public event EmployeeAddedEventHandler EmployeeAdded;
        public Add_Employee()
        {
            InitializeComponent();
            cmbType.Items.AddRange(new string[] { "manager", "stuff", "delivery" });
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            string name = Nametxt.Text;
            string phone = Phonetxt.Text;
            string email = Emailtxt.Text;
            string type = cmbType.SelectedItem?.ToString();
            string password = Passwordtxt.Text;

            if (!IsValidName(name))
            {
                MessageBox.Show("Please enter a valid name (containing both characters or numbers).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Please enter a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (password.Length < 8)
            {
                MessageBox.Show("Password must be at least 8 characters long.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!IsValidPhone(phone))
            {
                MessageBox.Show("Please enter a valid phone number with 11 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrWhiteSpace(type) || !IsValidType(type))
            {
                MessageBox.Show("Please select a valid type (manager, staff, or delivery).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Db.Roles.Any(emp => emp.Email == email))
            {
                MessageBox.Show("Email address is already associated with another employee. Please enter a unique email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                var newEmployee = new Role
                {
                    Name = name,
                    Phone = phone,
                    Email = email,
                    Password = password,
                    Type = type
                };
                Db.Roles.Add(newEmployee);
                Db.SaveChanges();

                MessageBox.Show("Employee added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                EmployeeAdded?.Invoke(this, EventArgs.Empty); // Raise the event

                this.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding employee: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsValidName(string name)
        {
            // Check if the name contains at least one character, not numeric only
            return !string.IsNullOrWhiteSpace(name) && name.Any(char.IsLetter) && !name.All(char.IsDigit);
        }

        private bool IsValidPhone(string phone)
        {
            // Check if the phone number has exactly 11 digits
            return !string.IsNullOrWhiteSpace(phone) && phone.Length == 11 && phone.All(char.IsDigit);
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        }

        private bool IsValidType(string type)
        {
            // Check if the type is one of the valid options: manager, staff, or delivery
            return type == "manager" || type == "stuff" || type == "delivery";
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}
