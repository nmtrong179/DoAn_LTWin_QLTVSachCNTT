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
    public partial class frmDSDG : Form
    {
        public frmDSDG()
        {
            InitializeComponent();
        }

        private void frmDSDG_Load(object sender, EventArgs e)
        {
            string query = "SELECT MaDG,TenDG,NgaySinh,GioiTinh,DiaChi,SDT FROM DOCGIA";
            DataTable tblDSDG = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, XLBang.cnnStr);
            try
            {
                da.Fill(tblDSDG);
                rpDocGia rpt = new rpDocGia();
                rpt.SetDataSource(tblDSDG);
                rptvDSDG.ReportSource = rpt;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
