using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using DTO;

namespace WebGUI
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SanPhamBLL spbll = new SanPhamBLL();
            GridView1.DataSource = spbll.LoadSanPham();
            GridView1.DataBind();
        }
    }
}