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
    public partial class AddSupplierForm : Form
    {
        public AddSupplierForm()
        {
            InitializeComponent();
        }

        private void SaveNewSupplier_Click(object sender, EventArgs e)
        {
            Suppliersdp suppliersdp= new Suppliersdp();
            suppliersdp.Name = SupNameLp.Text;
            suppliersdp.Email = SupEmailLp.Text;
            suppliersdp.Phone = int.Parse(SupPhoneLp.Text);
            suppliersdp.Address = SupAdressLp.Text;

            Context.SuppliersdpList.Add(suppliersdp);

        }
    }
}
