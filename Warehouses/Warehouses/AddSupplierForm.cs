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
            Warehouses_projectEntities context = new Warehouses_projectEntities();
            Supplier newSup = new Supplier()
            {
                ID = 156,
                Name = SupNameLp.Text,
                Phone = SupPhoneLp.Text,
                Address = SupAdressLp.Text,
                Email = SupEmailLp.Text,

            };
            
            context.Suppliers.Add(newSup);
            context.SaveChanges();
            Suppliers supplierss = new Suppliers();
            supplierss.getsupgrid();
            //supplierss.OursuppliersButton_Click();

        }
    }
}
