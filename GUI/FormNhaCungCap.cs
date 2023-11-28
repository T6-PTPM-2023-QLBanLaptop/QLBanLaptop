using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class FormNhaCungCap : Form
    {
        NhaCungCapBLL nccbll = new NhaCungCapBLL();
        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void nHACUNGCAPBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHACUNGCAPBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLShoplaptopDataSet);

        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLShoplaptopDataSet.NHACUNGCAP' table. You can move, or remove it, as needed.
            this.nHACUNGCAPTableAdapter.Fill(this.qLShoplaptopDataSet.NHACUNGCAP);

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap
            {
                MaNCC = maNCCTextBox.Text,
                TenNCC = tenNCCTextBox.Text,
                DiaChi = diaChiTextBox.Text,
                SDT = int.Parse(sDTTextBox.Text)
            };
            if (maNCCTextBox.Text != null)
            {
                int? kq = this.nHACUNGCAPTableAdapter.KTKCNCC(maNCCTextBox.Text);
                if (kq.Value > 0)
                {
                    MessageBox.Show("Trùng khóa mã nhà cung cấp!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            nccbll.ThemNhaCungCap(ncc);
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.nHACUNGCAPTableAdapter.Fill(this.qLShoplaptopDataSet.NHACUNGCAP);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (nHACUNGCAPDataGridView.SelectedRows.Count > 0)
            {
                string maNCC = nHACUNGCAPDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhà cung cấp này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nccbll.XoaNhaCungCap(maNCC);

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nHACUNGCAPDataGridView.DataSource = nccbll.LoadNhaCungCap();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            NhaCungCap ncc = new NhaCungCap
            {
                MaNCC = maNCCTextBox.Text,
                TenNCC = tenNCCTextBox.Text,
                DiaChi = diaChiTextBox.Text,
                SDT = int.Parse(sDTTextBox.Text)
            };

            nccbll.SuaNhaCungCap(ncc);

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.nHACUNGCAPTableAdapter.Fill(this.qLShoplaptopDataSet.NHACUNGCAP);
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
            FormTrangChu trangChu = new FormTrangChu();
            trangChu.Show();
            this.Hide();
        }
    }
}
