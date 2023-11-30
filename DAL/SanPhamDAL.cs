using DAL.QLSHOPLAPTOPTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAL
{
    public class SanPhamDAL
    {
        SANPHAMTableAdapter da_SanPham = new SANPHAMTableAdapter();

        public SanPhamDAL()
        {

        }

        public DataTable LoadSanPham()
        {
            DataTable dataTable = new DataTable();
            dataTable = da_SanPham.GetData();
            return dataTable;
        }

        public void ThemSanPham(SanPham pSanPham)
        {
            
            da_SanPham.Insert(pSanPham.MaSP, pSanPham.TenSP, pSanPham.SoLuong, pSanPham.GiaBan, pSanPham.MaNCC);
        }

        public void XoaSanPham(string maSanPham)
        {
            QLSHOPLAPTOP.SANPHAMRow rowToDelete = da_SanPham.GetData().FindByMaSP(maSanPham);

            if (rowToDelete != null)
            {
                rowToDelete.Delete();
                da_SanPham.Update(rowToDelete);
            }
        }

        public void SuaSanPham(SanPham pSanPham)
        {
            QLSHOPLAPTOP.SANPHAMRow rowToUpdate = da_SanPham.GetData().FindByMaSP(pSanPham.MaSP);

            if (rowToUpdate != null)
            {

                rowToUpdate.TenSP = pSanPham.TenSP;
                rowToUpdate.SoLuong = pSanPham.SoLuong;
                rowToUpdate.GiaBan = pSanPham.GiaBan;
                rowToUpdate.MaNCC = pSanPham.MaNCC;

                da_SanPham.Update(rowToUpdate);
            }
        }
    }
}
