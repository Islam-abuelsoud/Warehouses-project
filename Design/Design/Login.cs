using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Windows.Forms;

namespace Design
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Loginbtn_Click(object sender, EventArgs e)
        {
            string username = usernametxt.Text;
            string password = passwordtxt.Text;

            // Perform validation
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Please enter a Email.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter a Password.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Check username and password against database
            if (CheckCredentials(username, password))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Retrieve the user's role
                string userRole = GetUserRole(username);
                // Create an instance of BaseForm
                Home baseForm = new Home();
                baseForm.UserRole = userRole;
                // Show the BaseForm
                // baseForm.Show();
                baseForm.ShowDialog();

                // Close the login form
                //this.Hide();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckCredentials(string username, string password)
        {
            using (var context = new Warehouses_CompanyEntities1())
            {
                //return context.Role.Any(u => u.username == username && u.Password == password);
                // Query the database to check if username and password exist and if the user has the role of "Manager" or "Staff"
                return context.Roles.Any(u => u.Email == username && u.Password == password && (u.Type == "Manager" || u.Type == "Stuff"));
            }
        }
        private string GetUserRole(string username)
        {
            using (var context = new Warehouses_CompanyEntities1())
            {
                // Query the database to retrieve the user's role
                var user = context.Roles.FirstOrDefault(u => u.Email == username);
                if (user != null)
                {
                    return user.Type;
                }
                else
                {
                    return null; // Handle case where user is not found
                }
            }
        }

       

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
