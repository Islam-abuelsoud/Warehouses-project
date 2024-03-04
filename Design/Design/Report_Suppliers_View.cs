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
    public partial class Report_Suppliers_View : Form
    {
        public Report_Suppliers_View()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            // Load and display the Crystal Report in the Crystal Report Viewer
            CrystalReport_Suppliers reportDocument = new CrystalReport_Suppliers();
            crystalReportViewerSuppliers.ReportSource = reportDocument;
        }
    }
}
