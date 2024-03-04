using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Design
{
    public partial class FinanceForm : Form
    {
        Warehouses_CompanyEntities1 context = new Warehouses_CompanyEntities1();
        public FinanceForm()
        {
            InitializeComponent();
        }

        private void salesBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void pureBtn_Click(object sender, EventArgs e)
        {
          
        }

        private void ProfitpercentageBtn_Click(object sender, EventArgs e)
        {
            //Get Profit percentage 
            double ProfitpercentageSel = double.Parse(totalPriceSal.Text);
            double ProfitpercentagePur = double.Parse(totalPricePur.Text);
            if (ProfitpercentageSel > ProfitpercentagePur)
            {
                ProfitpercentageLa.Text = ((ProfitpercentageSel - ProfitpercentagePur) * 0.01 + "%").ToString();
            }
            else if (ProfitpercentageSel < ProfitpercentagePur)
            {
                ProfitpercentageLa.Text = ((ProfitpercentagePur - ProfitpercentageSel) * 0.01 + "%").ToString();
            }
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FinanceForm_Load(object sender, EventArgs e)
        {
            //Get All Sell Order 
            var getSales = context.Orders.Where(or => or.Type == "sell").Select(o => new { o.Date, o.State, o.Quantity, o.Total_cost, o.Type });
            dataGridSales.DataSource = getSales.ToList();

            //Get All Purchase invoices From DataBase 
            var getpur = context.Orders.Where(or => or.Type == "Buy").Select(o => new { o.Date, o.State, o.Quantity, o.Total_cost, o.Type });
            dataGridPur.DataSource = getpur.ToList();

        }

        private void pureBtn_Click_1(object sender, EventArgs e)
        {
            //Get All Purchase invoices From DataBase 
            //var getpur = context.Orders.Where(or => or.Type == "Buy");
            //dataGridPur.DataSource = getpur.ToList();
            var getpur = context.Orders.Where(or => or.Type == "Buy").Select(o => new { o.Date, o.State, o.Quantity, o.Total_cost, o.Type });
            dataGridPur.DataSource = getpur.ToList();

            //Sum All Purchase invoices Orders 
            decimal sum2 = (decimal)getpur.Sum(item => item.Total_cost);
            totalPricePur.Text = sum2.ToString();

            //Count All Purchase invoices Orders 
            int count2 = getpur.Count();
            quantityPur.Text = count2.ToString();
        }

        private void salesBtn_Click_1(object sender, EventArgs e)
        {
            //Get All Salles Sales invoices From DataBase 
            //var getSales = context.Orders.Where(or => or.Type == "sell");
            //dataGridSales.DataSource = getSales.ToList();
            var getSales = context.Orders.Where(or => or.Type == "sell").Select(o => new { o.Date, o.State, o.Quantity, o.Total_cost, o.Type });
            dataGridSales.DataSource = getSales.ToList();

            //Sum All Sales invoices Orders 
            decimal sum1 = (decimal)getSales.Sum(item => item.Total_cost);
            totalPriceSal.Text = sum1.ToString();

            //Count All Sales invoices Orders 
            int count1 = getSales.Count();
            quantitySal.Text = count1.ToString();
        }
    }
}
