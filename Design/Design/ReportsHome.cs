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
    public partial class ReportsHome : Form
    {
        public ReportsHome()
        {
            InitializeComponent();
        }

        private void productReportBtn_Click(object sender, EventArgs e)
        {
            Report_Products report = new Report_Products();
            report.ShowDialog();

        }

        private void customerReportBtn_Click(object sender, EventArgs e)
        {
            Report_Customer report = new Report_Customer();
            report.ShowDialog();

        }

        private void supplierReportBtn_Click(object sender, EventArgs e)
        {
            Report_Supliers report = new Report_Supliers();
            report.ShowDialog();
        }

        private void orderReportBtn_Click(object sender, EventArgs e)
        {
            Report_Order report = new Report_Order();
            report.ShowDialog();
        }
    }
}
