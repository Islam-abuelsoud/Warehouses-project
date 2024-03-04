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
    public partial class AddSupplier : Form
    {
        Warehouses_CompanyEntities1 context = new Warehouses_CompanyEntities1();
        private DataGridView dataGridView1;
        public AddSupplier(DataGridView dataGridView1)
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

        private void labelAddCus_Click(object sender, EventArgs e)
        {
            //Call valdiat Function 
            valdiation();


            //1 - Add New Customer 
            try
            {
                Supplier newSupplier = new Supplier()
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
                    context.Suppliers.Add(newSupplier);
                    MessageBox.Show("Supplier Added Sucsses");
                    context.SaveChanges();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the Suppliers: " + ex.Message);
            }

            // Refresh the DataGridView to reflect the changes
            dataGridView1.DataSource = context.Suppliers.ToList();

            // Close the Add_Customer form
            this.Close();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
