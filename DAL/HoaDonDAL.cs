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
    public class HoaDonDAL
    {
        HOADONTableAdapter da_HoaDon = new HOADONTableAdapter();
        public HoaDonDAL()
        {

        }
        public DataTable LoadHoaDon()
        {
            DataTable dataTable = new DataTable();
            dataTable = da_HoaDon.GetData();
            return dataTable;
        }

        public void ThemHoaDon(HoaDon pHoaDon)
        {

            da_HoaDon.Insert(pHoaDon.MaHD, pHoaDon.MaNV, pHoaDon.MaKH, pHoaDon.NgayBan, pHoaDon.TongTien);
        }
        public void XoaHoaDon(string maHoaDon)
        {
            QLSHOPLAPTOP.HOADONRow rowToDelete = da_HoaDon.GetData().FindByMaHD(maHoaDon);

            if (rowToDelete != null)
            {
                rowToDelete.Delete();
                da_HoaDon.Update(rowToDelete);
            }
        }

        public void SuaHoaDon(HoaDon pHoaDon)
        {
            QLSHOPLAPTOP.HOADONRow rowToUpdate = da_HoaDon.GetData().FindByMaHD(pHoaDon.MaHD);

            if (rowToUpdate != null)
            {

                rowToUpdate.MaNV = pHoaDon.MaNV;
                rowToUpdate.MaKH = pHoaDon.MaKH;
                rowToUpdate.NgayBan = pHoaDon.NgayBan;
                rowToUpdate.TongTien = pHoaDon.TongTien;

                da_HoaDon.Update(rowToUpdate);
            }
        }
    }
}
