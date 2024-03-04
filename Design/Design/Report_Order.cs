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
    public partial class Report_Order : Form
    {
        Warehouses_CompanyEntities1 context = new Warehouses_CompanyEntities1();
        bool check;
        public Report_Order()
        {
            InitializeComponent();
        }

        private void getDataBtn_Click(object sender, EventArgs e)
        {
            try
            {

                  var filteredOrders = context.Orders
                  .Join(context.order_item,
                   order => order.ID,
                   orderItem => orderItem.OrderID,
                  (order, orderItem) => new
                  {
                   order.Date,
                   order.Customer_ID,
                   order.Customer,
                   orderItem.Product_Name,
                   order.Quantity,
                   order.Total_cost,
                   order.Type,

                   }).ToList();

                Grid1.DataSource = filteredOrders;
                check = true;


            }
            catch(Exception ex)
            {
                MessageBox.Show("An error occurred while adding the orders: " + ex.Message);
            }

        
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
       
                //Create Two Vaiable For Two Date Time 
                string startDate = startdateTimePicker1.Value.ToString("yyyy-MM-dd");
                string endDate = endDateTimePicker.Value.ToString("yyyy-MM-dd");

                //Convert Date From String To Date Time 
                DateTime parsedStartDate = DateTime.Parse(startDate);
                DateTime parsedEndDate = DateTime.Parse(endDate);//.AddDays(1).AddSeconds(-1); 

                //Select Data From Data Base Based On Condation 
                var filteredOrders = context.Orders
                    .Where(p => p.Date >= parsedStartDate && p.Date <= parsedEndDate)
                    .Select(p => new { p.ID, p.Date, p.Customer_ID, p.Customer, p.Quantity, p.Total_cost, p.Type }).ToList();

                Grid1.DataSource = filteredOrders;
                check = true;
        }

        private void printBtn_Click(object sender, EventArgs e)
        {

            if (check)
            {
                // When the print button is clicked, open the Print Form
                Report_Order_View printForm = new Report_Order_View();
                printForm.ShowDialog();
            }

            else
            {
                MessageBox.Show("Please Get Orders First");
            }


        }
    }
}
