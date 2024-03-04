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
    public partial class Add_Customer : Form
    {
        Warehouses_CompanyEntities1 context = new Warehouses_CompanyEntities1();
        private DataGridView dataGridView1;
        public Add_Customer(DataGridView dataGridView1)
        {
            InitializeComponent();
            this.dataGridView1 = dataGridView1;
        }


        //Create Function To Handle Valdiation Emty 
        public void valdiation()
        {
            //Valdiation ..........
         
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Please Enter Name");
                return;
            }
            if (string.IsNullOrWhiteSpace(textEamil.Text))
            {
                MessageBox.Show("Please Enter Email");
                return;
            }
            if (string.IsNullOrWhiteSpace(textPhone.Text))
            {
                MessageBox.Show("Please Enter phone");
                return;
            }
           
            if (string.IsNullOrWhiteSpace(textAdress.Text))
            {
                MessageBox.Show("Please Enter Adress");
                return;
            }

        }

       

        private void labelAddCus_Click_1(object sender, EventArgs e)
        {
            //Call valdiat Function 
            valdiation();


            //1 - Add New Customer 
            try
            {
                Customer newCustomer = new Customer()
                {
                    Name = textName.Text,
                    Phone = textPhone.Text,
                    Address = textAdress.Text,
                    Email = textEamil.Text
                };
                if (textPhone.Text.Length < 11)                   //PhoneNumber Valdiation 
                {
                    phonevaldiation.Visible = true;
                    return;
                }

                else if (!textEamil.Text.Contains("@"))
                {
                    phonevaldiation.Visible = false;
                    emailValdiation.Visible = true;
                    return;
                }

                else
                {
                    emailValdiation.Visible = false;
                    context.Customers.Add(newCustomer);
                    MessageBox.Show("Customer Added Sucsses");
                    context.SaveChanges();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the customer: " + ex.Message);
            }

            // Refresh the DataGridView to reflect the changes
            dataGridView1.DataSource = context.Customers.Select(c => new { c.Name, c.Phone, c.Email, c.Address }).ToList();

            // Close the Add_Customer form
            this.Close();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
