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
    public partial class FormNhanVien : Form
    {
        NhanVienBLL nvbll = new NhanVienBLL();
        public FormNhanVien()
        {
            InitializeComponent();
        }

        private void nHANVIENBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.nHANVIENBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLShoplaptopDataSet);

        }

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLShoplaptopDataSet.NHANVIEN' table. You can move, or remove it, as needed.
            this.nHANVIENTableAdapter.Fill(this.qLShoplaptopDataSet.NHANVIEN);

        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien
            {
                MaNV = maNVTextBox.Text,
                TenNV = tenNVTextBox.Text,
                NgaySinh = DateTime.Parse(ngaySinhDateTimePicker.Text),
                GioiTinh = gioiTinhTextBox.Text,
                DiaChi = diaChiTextBox.Text,
                SDT = int.Parse(sDTTextBox.Text)
            };
            if (maNVTextBox.Text != null)
            {
                int? kq = this.nHANVIENTableAdapter.KTKCNV(maNVTextBox.Text);
                if (kq.Value > 0)
                {
                    MessageBox.Show("Trùng khóa mã nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            nvbll.ThemNhanVien(nv);
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.nHANVIENTableAdapter.Fill(this.qLShoplaptopDataSet.NHANVIEN);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (nHANVIENDataGridView.SelectedRows.Count > 0)
            {
                string maNV = nHANVIENDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    nvbll.XoaNhanVien(maNV);

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    nHANVIENDataGridView.DataSource = nvbll.LoadNhanVien();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            NhanVien nv = new NhanVien
            {
                MaNV = maNVTextBox.Text,
                TenNV = tenNVTextBox.Text,
                NgaySinh = DateTime.Parse(ngaySinhDateTimePicker.Text),
                GioiTinh = gioiTinhTextBox.Text,
                DiaChi = diaChiTextBox.Text,
                SDT = int.Parse(sDTTextBox.Text)
            };

            nvbll.SuaNhanVien(nv);

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.nHANVIENTableAdapter.Fill(this.qLShoplaptopDataSet.NHANVIEN);
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
