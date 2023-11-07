using DAL.QLSHOPLAPTOPTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        SANPHAMTableAdapter sanpham = new SANPHAMTableAdapter();

        public SanPhamDAL()
        {

        }

        public DataTable LoadSanPham()
        {
            return sanpham.GetData();
        }

    }
}
