using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouses;

namespace Warehouses
{

    public partial class SuppliersForm : Form
    {
        //Add Context To Connect With Database 
        Warehouses_CompanyEntities context = new Warehouses_CompanyEntities();

        public SuppliersForm()
        {

            InitializeComponent();
            geidView();
        }
        //Create Function To View 
        public void geidView()
        {
            dataGridView1.DataSource = context.Suppliers.ToList();
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

        private void labelAddSup_Click(object sender, EventArgs e)
        {
            valdiation();
            try
            {
                Supplier newSup = new Supplier()
                {

                    ID = int.Parse(idText.Text),
                    Name = textName.Text,
                    Phone = textPhone.Text,
                    Address = adressText.Text,
                    Email = textEamil.Text
                };
                if (!textEamil.Text.Contains("@"))
                {

                    emailValdiation.Visible = true;

                }
                else
                {
                    emailValdiation.Visible = false;
                    context.Suppliers.Add(newSup);
                    MessageBox.Show("Suppliers Added Sucsses");
                    context.SaveChanges();
                    geidView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while adding the Suppliers: " + ex.Message);
            }
        }
        private void updateBtn_Click(object sender, EventArgs e)
        {
            //1 - Update Customer 
            try
            {
                int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                var upResult = context.Suppliers.SingleOrDefault(x => x.ID == id);
                upResult.Name = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                upResult.Phone = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                upResult.Email = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                upResult.Address = dataGridView1.CurrentRow.Cells[4].Value.ToString();

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
            var result = MessageBox.Show("Youer will delete", "warnning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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

        
        


        //Search Section 
        //private void searchBtn_Click(object sender, EventArgs e)
        //{
        //    int id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());

        //    var searchResult = context.Suppliers.SingleOrDefault(x => x.ID == id);
        //    textSearch.Text = searchResult.ToString();

        //    dataGridView1.DataSource = context.Customers.ToList();

        //}


    }
}
