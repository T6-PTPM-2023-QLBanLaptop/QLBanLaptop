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
    public class HoaDonBLL
    {
        HoaDonDAL dalhd = new HoaDonDAL();

        public DataTable LoadHoaDon()
        {
            return dalhd.LoadHoaDon();
        }

        public void ThemHoaDon(HoaDon pHD)
        {
            dalhd.ThemHoaDon(pHD);
        }
        public void XoaHoaDon(string maHoaDon)
        {
            dalhd.XoaHoaDon(maHoaDon);
        }

        public void SuaHoaDon(HoaDon pHoaDon)
        {
            dalhd.SuaHoaDon(pHoaDon);
        }
    }
}
