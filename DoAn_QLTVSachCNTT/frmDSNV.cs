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
    public partial class frmDSNV : Form
    {
        public frmDSNV()
        {
            InitializeComponent();
        }

        private void frmDSNV_Load(object sender, EventArgs e)
        {
            string query = "SELECT MaNV, HoTenNV, NgaySinh, GioiTinh, DiaChi, SDT, ChucVu FROM NHANVIEN";
            DataTable tblDSNV = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, XLBang.cnnStr);
            try
            {
                da.Fill(tblDSNV);
                rpDSNV rpt = new rpDSNV();
                rpt.SetDataSource(tblDSNV);
                rptvDSNV.ReportSource = rpt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
