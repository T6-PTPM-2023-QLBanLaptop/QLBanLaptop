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
    public partial class FormDonHang : Form
    {
        HoaDonBLL hdbll = new HoaDonBLL();
        CTHoaDonBLL cthdbll = new CTHoaDonBLL();
        public FormDonHang()
        {
            InitializeComponent();
        }

        private void hOADONBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.hOADONBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.qLShoplaptopDataSet);

        }

        private void FormDonHang_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLShoplaptopDataSet.SANPHAM' table. You can move, or remove it, as needed.
            this.sANPHAMTableAdapter.Fill(this.qLShoplaptopDataSet.SANPHAM);
            // TODO: This line of code loads data into the 'qLShoplaptopDataSet.CHITIETHOADON' table. You can move, or remove it, as needed.
            this.cHITIETHOADONTableAdapter.Fill(this.qLShoplaptopDataSet.CHITIETHOADON);
            // TODO: This line of code loads data into the 'qLShoplaptopDataSet.HOADON' table. You can move, or remove it, as needed.
            this.hOADONTableAdapter.Fill(this.qLShoplaptopDataSet.HOADON);

            
        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.cHITIETHOADON1TableAdapter.Fill(this.qLShoplaptopDataSet.CHITIETHOADON1, maHDTextBox.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void maHDTextBox_TextChanged(object sender, EventArgs e)
        {
            this.cHITIETHOADON1TableAdapter.Fill(this.qLShoplaptopDataSet.CHITIETHOADON1, maHDTextBox.Text);
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon
            {
                MaHD = maHDTextBox.Text,
                MaNV = maNVTextBox.Text,
                MaKH = maKHTextBox.Text,
                NgayBan = DateTime.Parse(ngayBanDateTimePicker.Text),
            };
            if (maHDTextBox.Text != null)
            {
                int? kq = this.hOADONTableAdapter.KTKCHD(maHDTextBox.Text);
                if (kq.Value > 0)
                {
                    MessageBox.Show("Trùng khóa mã hóa đơn!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }

            hdbll.ThemHoaDon(hd);
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.hOADONTableAdapter.Fill(this.qLShoplaptopDataSet.HOADON);
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (hOADONDataGridView.SelectedRows.Count > 0)
            {
                string maHD = hOADONDataGridView.SelectedRows[0].Cells[0].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa hóa đơn này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    hdbll.XoaHoaDon(maHD);

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    hOADONDataGridView.DataSource = hdbll.LoadHoaDon();
                }
            }
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            HoaDon hd = new HoaDon
            {
                MaHD = maNVTextBox.Text,
                MaNV = maNVTextBox.Text,
                MaKH = maKHTextBox.Text,
                NgayBan = DateTime.Parse(ngayBanDateTimePicker.Text),
                TongTien = int.Parse(tongTienTextBox.Text)
            };

            hdbll.SuaHoaDon(hd);

            MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.hOADONTableAdapter.Fill(this.qLShoplaptopDataSet.HOADON);
        }

        private void btn_ThemSP_Click(object sender, EventArgs e)
        {
            CTHoaDon cthd = new CTHoaDon
            {
                MaHD = maHDTextBox.Text,
                MaSP = maSPTextBox1.Text,
                DonGia = Convert.ToInt32(giaBanTextBox.Text),
                SoLuong = Convert.ToInt32(txtSoLuong.Text),

            };
            cthd.ThanhTien = cthd.DonGia * cthd.SoLuong;

            cthdbll.ThemCTHoaDon(cthd);
            MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.cHITIETHOADON1TableAdapter.Fill(this.qLShoplaptopDataSet.CHITIETHOADON1, maHDTextBox.Text);
            this.hOADONTableAdapter.Fill(this.qLShoplaptopDataSet.HOADON);
        }

        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            if (cHITIETHOADON1DataGridView.SelectedRows.Count > 0)
            {
                string maHD = cHITIETHOADON1DataGridView.SelectedRows[0].Cells[0].Value.ToString();
                string maSP = cHITIETHOADON1DataGridView.SelectedRows[0].Cells[1].Value.ToString();

                if (MessageBox.Show("Bạn có chắc chắn muốn xóa Hóa Đơn này này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    cthdbll.XoaCTHoaDon(maHD, maSP);

                    MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.cHITIETHOADON1TableAdapter.Fill(this.qLShoplaptopDataSet.CHITIETHOADON1, maHDTextBox.Text);
                }
            }
        }
    }
}
