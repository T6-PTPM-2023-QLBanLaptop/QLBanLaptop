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
    public class NhaCungCapDAL
    {
        NHACUNGCAPTableAdapter da_NhaCungCap = new NHACUNGCAPTableAdapter();

        public NhaCungCapDAL()
        {

        }

        public DataTable LoadNhaCungCap()
        {
            DataTable dataTable = new DataTable();
            dataTable = da_NhaCungCap.GetData();
            return dataTable;
        }

        public void ThemNhaCungCap(NhaCungCap pNhaCungCap)
        {

            da_NhaCungCap.Insert(pNhaCungCap.MaNCC, pNhaCungCap.TenNCC, pNhaCungCap.DiaChi, pNhaCungCap.SDT);
        }

        public void XoaNhaCungCap(string maNhaCungCap)
        {
            QLSHOPLAPTOP.NHACUNGCAPRow rowToDelete = da_NhaCungCap.GetData().FindByMaNCC(maNhaCungCap);

            if (rowToDelete != null)
            {
                rowToDelete.Delete();
                da_NhaCungCap.Update(rowToDelete);
            }
        }

        public void SuaNhaCungCap(NhaCungCap pNhaCungCap)
        {
            QLSHOPLAPTOP.NHACUNGCAPRow rowToUpdate = da_NhaCungCap.GetData().FindByMaNCC(pNhaCungCap.MaNCC);

            if (rowToUpdate != null)
            {

                rowToUpdate.TenNCC = pNhaCungCap.TenNCC;
                rowToUpdate.DiaChi = pNhaCungCap.DiaChi;
                rowToUpdate.SDT = pNhaCungCap.SDT;

                da_NhaCungCap.Update(rowToUpdate);
            }
        }
    }
}
