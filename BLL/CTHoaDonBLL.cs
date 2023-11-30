using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using DTO;
using System.Data;

namespace BLL
{
    public class CTHoaDonBLL
    {
        CTHoaDonDAL dalcthd = new CTHoaDonDAL();

        public DataTable LoadCTHoaDon()
        {
            return dalcthd.LoadCTHoaDon();
        }

        public void ThemCTHoaDon(CTHoaDon pHD)
        {
            dalcthd.ThemCTHoaDon(pHD);
        }
        public void XoaCTHoaDon(string maHoaDon, string maSanPham)
        {
            dalcthd.XoaCTHoaDon(maHoaDon, maSanPham);
        }

        public void SuaCTHoaDon(CTHoaDon pHoaDon)
        {
            dalcthd.SuaCTHD(pHoaDon);
        }
    }
}
