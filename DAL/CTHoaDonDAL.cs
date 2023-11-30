using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL.QLSHOPLAPTOPTableAdapters;
using System.Data;

namespace DAL
{
    public class CTHoaDonDAL
    {
        CHITIETHOADONTableAdapter da_CTHD = new CHITIETHOADONTableAdapter();

        public CTHoaDonDAL()
        {

        }

        public DataTable LoadCTHoaDon()
        {
            DataTable dataTable = new DataTable();
            dataTable = da_CTHD.GetData();
            return dataTable;
        }

        public void ThemCTHoaDon(CTHoaDon pCTHoaDon)
        {

            da_CTHD.Insert(pCTHoaDon.MaHD, pCTHoaDon.MaSP, pCTHoaDon.SoLuong, pCTHoaDon.DonGia, pCTHoaDon.ThanhTien);
        }

        public void XoaCTHoaDon(string maCTHoaDon, string maSP)
        {
            QLSHOPLAPTOP.CHITIETHOADONRow rowToDelete = da_CTHD.GetData().FindByMaHDMaSP(maCTHoaDon, maSP);

            if (rowToDelete != null)
            {
                rowToDelete.Delete();
                da_CTHD.Update(rowToDelete);
            }
        }

        public void SuaCTHD(CTHoaDon pCTHD)
        {
            QLSHOPLAPTOP.CHITIETHOADONRow rowToUpdate = da_CTHD.GetData().FindByMaHDMaSP(pCTHD.MaHD, pCTHD.MaSP);

            if (rowToUpdate != null)
            {

                rowToUpdate.SoLuong = pCTHD.SoLuong;
                rowToUpdate.DonGia = pCTHD.DonGia;
                rowToUpdate.ThanhTien = pCTHD.ThanhTien;

                da_CTHD.Update(rowToUpdate);
            }
        }
    }
}
