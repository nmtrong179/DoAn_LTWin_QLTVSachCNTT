using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAn_QLTVSachCNTT.DATA;

namespace DoAn_QLTVSachCNTT
{
    public partial class frmThongKeDocGia : Form
    {
        public frmThongKeDocGia()
        {
            InitializeComponent();
        }

        BindingManagerBase DSDGQH;
        DataTable tblDGQuaHan;

        private void frmThongKeDocGia_Load(object sender, EventArgs e)
        {
            string a = "Select count(*) from DOCGIA";
            var m = XLDocGia.Thuc_hien_lenh_tinh_toan(a);
            txtSLDG.Text = m.ToString();
            string b = "Select count(distinct MaDG) from PHIEUMUON";
            var n = XLPhieuMuon.Thuc_hien_lenh_tinh_toan(b);
            txtSLDGDM.Text = n.ToString();
            string c = "Select Count(distinct MaDG) from PHIEUMUON where DATEDIFF(day,NgayTra,getdate())>0 and TrangThai='False'";
            var o = XLPhieuMuon.Thuc_hien_lenh_tinh_toan(c);
            txtSLDGQH.Text = o.ToString();
            string d = "Select count(*) from DOCGIA where MaDG not in (Select distinct MaDG from PHIEUMUON)";
            var p = XLDocGia.Thuc_hien_lenh_tinh_toan(d);
            //Ve bieu do
            ChDG.Series["Số Lượng Độc Giả"].Points.AddXY("Đã Mượn", txtSLDGDM.Text);
            ChDG.Series["Số Lượng Độc Giả"].Points.AddXY("Mượn Quá Hạn", txtSLDGQH.Text);
            ChDG.Series["Số Lượng Độc Giả"].Points.AddXY("Chưa Mượn", p.ToString());

            string query = "select PHIEUMUON.MaPM,PHIEUMUON.MaDG,DOCGIA.TenDG,sum(CTPHIEUMUON.SoLuong) as TongSoLuong,datediff(day,PHIEUMUON.NgayTra,GETDATE()) as SoNgayQH from PHIEUMUON inner join CTPHIEUMUON on PHIEUMUON.MaPM = CTPHIEUMUON.MaPM inner join DOCGIA on DOCGIA.MaDG = PHIEUMUON.MaDG where PHIEUMUON.TrangThai = 'False' and datediff(day, PHIEUMUON.NgayTra, GETDATE())> 0 group by PHIEUMUON.MaPM,PHIEUMUON.MaDG,DOCGIA.TenDG,PHIEUMUON.NgayTra";
            tblDGQuaHan = new DataTable();
            rdTheoMDG.Checked = true;
            SqlDataAdapter da = new SqlDataAdapter(query, XLBang.cnnStr);
            try
            {
                da.Fill(tblDGQuaHan);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            DSDGQH = this.BindingContext[tblDGQuaHan];
            dgvDSDGQH.AutoGenerateColumns = false;
            dgvDSDGQH.DataSource = tblDGQuaHan;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdTheoMDG.Checked == true)
            {
                string std = string.Format("MaDG like '%{0}%'", txtTimKiem.Text);
                tblDGQuaHan.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("TenDG like '%{0}%'", txtTimKiem.Text);
                tblDGQuaHan.DefaultView.RowFilter = std;
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dgvDSDGQH.RowCount == 1)
            {
                MessageBox.Show("Không có thông tin dữ liệu cần tìm!!!");
            }
        }

        private void dgvDSDGQH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSDGQH.Rows)
                r.Cells[0].Value = r.Index + 1;
        }
    }
}
