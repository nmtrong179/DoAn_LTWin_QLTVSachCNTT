using DoAn_QLTVSachCNTT.DATA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLTVSachCNTT
{
    public partial class frmDSSach : Form
    {
        public frmDSSach()
        {
            InitializeComponent();
        }

        private void frmDSSach_Load(object sender, EventArgs e)
        {
            string query = "SELECT dbo.SACH.MaSach, dbo.SACH.TenSach, dbo.SACH.TheLoai, dbo.SACH.TacGia, dbo.SACH.NXB, dbo.NHACUNGCAP.TenNCC, dbo.SACH.SLTon, dbo.SACH.Hinh FROM dbo.NHACUNGCAP INNER JOIN dbo.SACH ON dbo.NHACUNGCAP.MaNCC = dbo.SACH.MaNCC";
            DataTable tblDSSach = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, XLBang.cnnStr);
            try
            {
                da.Fill(tblDSSach);
                rpSach rpt = new rpSach();
                rpt.SetDataSource(tblDSSach);
                rptvDSSach.ReportSource = rpt;
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
