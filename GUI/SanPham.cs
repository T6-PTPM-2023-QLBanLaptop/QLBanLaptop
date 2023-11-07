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
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void sANPHAMBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sANPHAMBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLShoplaptopDataSet);

        }

        private void SanPham_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLShoplaptopDataSet.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.qLShoplaptopDataSet.SANPHAM);

        }
    }
}
