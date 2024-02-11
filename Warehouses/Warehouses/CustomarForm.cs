using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouses
{

    public partial class CustomarForm : Form
    {
        //Add Context To Connect With Database 
        Warehouses_CompanyEntities context = new Warehouses_CompanyEntities();

        public CustomarForm()
        {

            InitializeComponent();

        }
        //Create Function To View 
        public void geidView()
        {
            dataGridView1.DataSource = context.Customers.ToList();
        }

        //Create Function To Handle Valdiation Emty 
        public void valdiation()
        {
            //Valdiation ..........
            if (string.IsNullOrWhiteSpace(idText.Text))
            {
                MessageBox.Show("Please Enter Id");
                return;
            }
            if (string.IsNullOrWhiteSpace(textName.Text))
            {
                MessageBox.Show("Please Enter Name");
                return;
            }
            if (string.IsNullOrWhiteSpace(textPhone.Text))
            {
                MessageBox.Show("Please Enter phone");
                return;
            }
            if (string.IsNullOrWhiteSpace(textEamil.Text))
            {
                MessageBox.Show("Please Enter Email");
                return;
            }
            if (string.IsNullOrWhiteSpace(adressText.Text))
            {
                MessageBox.Show("Please Enter Adress");
                return;
            }

        }
        private void showbtn_Click(object sender, EventArgs e)
        {
            //Get All Data From Customer Table 
            geidView();


        }

        private void labelAddCus_Click(object sender, EventArgs e)
        {
            //Call valdiat Function 
            valdiation();


            //1 - Add New Customer 
            try
            {
                Customer newCustomer = new Customer()
                {

                    ID = int.Parse(idText.Text),
                    Name = textName.Text,
                    Phone = textPhone.Text,
                    Address = textAdress.Text,
                    Email = textEamil.Text
                };
                if (!textEamil.Text.Contains("@"))
                {

                    emailValdiation.Visible = true;

                }

                //else if (textPhone.Text.Length < 12)                   //PhoneNumber Valdiation 
                //{
                //    MessageBox.Show("sdfds");
                //    phonevaldiation.Visible = true;                      
                //}

                //else if ()                                            //Frequncy Id 
                //{

                //}

                else
                {
                    emailValdiation.Visible = false;
                    context.Customers.Add(newCustomer);
                    MessageBox.Show("Customer Added Sucsses");
                    context.SaveChanges();
                    geidView();
                }


            }

            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the customer: " + ex.Message);
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            //1 - Update Customer 
            try
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var upResult = context.Customers.SingleOrDefault(x => x.ID == id);
                upResult.Name = textName.Text;
                upResult.Phone = textPhone.Text;
                upResult.Email = textEamil.Text;
                upResult.Address = textAdress.Text;

                MessageBox.Show("Updeted Sucssefuly");
                geidView();
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while Updating the customer: " + ex.Message);
            }


        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            valdiation();

            var result = MessageBox.Show("Youer will delet", "warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

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

        //Search Section 
        private void searchBtn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var searchResult = context.Customers.SingleOrDefault(x => x.ID == id);
            textSearch.Text = searchResult.ToString();

            dataGridView1.DataSource = context.Customers.ToList();

        }
    }
}
