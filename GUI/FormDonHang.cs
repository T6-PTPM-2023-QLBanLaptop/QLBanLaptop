using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormDonHang : Form
    {
        public FormDonHang()
        {
            InitializeComponent();
        }

        private void kHOHANGBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.kHOHANGBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLShoplaptopDataSet);

        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLShoplaptopDataSet.KHOHANG' table. You can move, or remove it, as needed.
            this.kHOHANGTableAdapter.Fill(this.qLShoplaptopDataSet.KHOHANG);

        }
    }
}
