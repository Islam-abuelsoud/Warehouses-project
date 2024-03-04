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
    public partial class Home : Form
    {
        public string UserRole { get; set; }
        Form1 form;
        SupplierForm supplier;
        InventoryForm Inventory;
        FinanceForm Finances;
        ProductForm product;
        OrderForm Order;
        CustomerForm Customer;
        Employee Employee;
        ReportsHome report;


        public Home()
        {
            InitializeComponent();
            this.IsMdiContainer = true; // Set Home form as an MDI container
        }

     
        private void homebtn_Click(object sender, EventArgs e)
        {
            if (form == null)
            {
                form = new Form1();
                form.FormClosed += form_FormClosed;
                form.MdiParent = this;
                form.Show();
            }
            else
            {
                form.Activate();
            }
        }

        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            form=null;
        }

        private void supplierbtn_Click(object sender, EventArgs e)
        {
            CloseExistingForms();
            supplier = new SupplierForm();
            supplier.FormClosed += form_FormClosed;
            supplier.MdiParent = this;
            supplier.Show();
        }

        private void inventorybtn_Click(object sender, EventArgs e)
        {
                CloseExistingForms();
                Inventory = new InventoryForm();
                Inventory.FormClosed += form_FormClosed;
                Inventory.MdiParent = this;
                Inventory.Show();
           
        }

        private void Financesbtn_Click(object sender, EventArgs e)
        {
                CloseExistingForms();
                Finances = new FinanceForm();
                Finances.FormClosed += form_FormClosed;
                Finances.MdiParent = this;
                Finances.Show();
            
        }

        private void productbtn_Click(object sender, EventArgs e)
        {
                CloseExistingForms();
                product = new ProductForm();
                product.FormClosed += form_FormClosed;
                product.MdiParent = this;
                product.Show();
           
        }

        private void orderbtn_Click(object sender, EventArgs e)
        {
                CloseExistingForms();
                Order = new OrderForm();
                Order.FormClosed += form_FormClosed;
                Order.MdiParent = this;
                Order.Show();
            
        }
        private void customerbtn_Click(object sender, EventArgs e)
        {

            CloseExistingForms();
            Customer = new CustomerForm();
            Customer.FormClosed += form_FormClosed;
            Customer.MdiParent = this;
            Customer.Show();
        }
        private void managerbtn_Click(object sender, EventArgs e)
        {
           

            // Check if the current user is a manager
            if (UserRole != "manager")
            {
                MessageBox.Show("Only managers are allowed to add employees.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Open the Add_Employee form
            if (Employee != null && !Employee.IsDisposed)
            {
                Employee.Close(); // Close the existing instance
            }

            CloseExistingForms();
            Employee = new Employee();
            Employee.FormClosed += form_FormClosed;
            Employee.MdiParent = this;
            Employee.Show();  
       
        }
      

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            // Create an instance of your login form
            Login loginForm = new Login();

            // Hide the current form (assuming this logout button is in the form you want to hide)
            this.Hide();

            // Show the login form
            loginForm.Show();
        }

        private void CloseExistingForms()
        {
            if (form != null)
            {
                form.Close();
                form = null;
            }
            if (supplier != null)
            {
                supplier.Close();
                supplier = null;
            }
            if (Customer != null)
            {
                Customer.Close();
                Customer = null;
            }
            if (Finances != null)
            {
                Finances.Close();
                Finances = null;
            }
            if (Inventory != null)
            {
                Inventory.Close();
                Inventory = null;
            }
            if (Order != null)
            {
                Order.Close();
                Order = null;
            }
            if (product != null)
            {
                product.Close();
                product = null;
            }
            if (report != null)
            {
                report.Close();
                report = null;
            }



        }

        private void reportbtn_Click(object sender, EventArgs e)
        {
            
            CloseExistingForms();
            ReportsHome report = new ReportsHome();
            report.FormClosed += form_FormClosed;
            report.MdiParent = this;
            report.Show();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2ImageButton2_Click(object sender, EventArgs e)
        {


        }







        //private void form_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    form = null;
        //    // Assign null to other form variables as well if necessary
        //}
    }
}
