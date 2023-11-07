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
    public class SanPhamBLL
    {
        SanPhamDAL dalsp = new SanPhamDAL();

        public SanPhamBLL()
        {

        }

        public DataTable GetSanPham()
        {
            return dalsp.LoadSanPham();
        }
    }
}
