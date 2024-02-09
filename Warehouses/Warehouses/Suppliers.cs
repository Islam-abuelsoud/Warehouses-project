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
    public partial class Suppliers : Form
    {
        public Suppliers()
        {
            InitializeComponent();

            SuppGrid.DataSource = Context.SuppliersdpList;
        }
        private AddSupplierForm addSupplierForm;

        private void AddSupplierButton_Click(object sender, EventArgs e)
        {
            if (addSupplierForm == null || addSupplierForm.IsDisposed)
            {
                addSupplierForm = new AddSupplierForm();
                addSupplierForm.Show();
            }
            else
            {
                addSupplierForm.BringToFront();
            }

        }

        private void SuppGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
