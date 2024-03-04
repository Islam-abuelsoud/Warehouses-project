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
    public partial class Report_Customer_View : Form
    {
        public Report_Customer_View()
        {
            InitializeComponent();


        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            // Load and display the Crystal Report in the Crystal Report Viewer
            CrystalReport_Customer reportDocument = new CrystalReport_Customer();   
            crystalReportViewerCustomer.ReportSource = reportDocument;
        }
    }
}
