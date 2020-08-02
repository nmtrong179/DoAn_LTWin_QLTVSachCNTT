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
    public partial class frmThongKeSach : Form
    {
        public frmThongKeSach()
        {
            InitializeComponent();
        }

        BindingManagerBase DSPM;
        DataTable tblSachQuaHan;

        private void frmThongKeSach_Load(object sender, EventArgs e)
        {
            string a = "Select count(MaSach) from SACH";
            var m = XLSach.Thuc_hien_lenh_tinh_toan(a);
            txtDauSach.Text = m.ToString();
            string b = "Select count(Distinct TheLoai) from SACH";
            var n = XLSach.Thuc_hien_lenh_tinh_toan(b);
            txtTheLoai.Text = n.ToString();
            string c = "Select sum(SLTon) from SACH";
            var o = XLSach.Thuc_hien_lenh_tinh_toan(c);
            txtSLSach.Text = o.ToString();
            string d = "Select sum(SoLuong) from CTPHIEUMUON";
            var p = XLCTPhieuMuon.Thuc_hien_lenh_tinh_toan(d);
            txtSLSachMuon.Text = p.ToString();
            string f = "select a.sa-b.ctpm from(select sum(SLTon) as sa from SACH) as a,(select sum(SoLuong) as ctpm from CTPHIEUMUON) as b";
            var q = XLSach.Thuc_hien_lenh_tinh_toan(f);
            txtSLConLai.Text = q.ToString();
            string g = "Select sum(SoLuong) from CTPHIEUMUON inner join PHIEUMUON on CTPHIEUMUON.MaPM=PHIEUMUON.MaPM where datediff(day,PHIEUMUON.NgayTra,Getdate())>0 and PHIEUMUON.TrangThai='False' ";
            var w = XLPhieuMuon.Thuc_hien_lenh_tinh_toan(g);
            txtSachQuaHan.Text = w.ToString();

            //Ve Bieu Do
            chSach.Series["Số Lượng Sách"].Points.AddXY("Đầu Sách", txtDauSach.Text);
            chSach.Series["Số Lượng Sách"].Points.AddXY("Thể Loại", txtTheLoai.Text);
            chSach.Series["Số Lượng Sách"].Points.AddXY("Tổng Sách", txtSLSach.Text);
            chSach.Series["Số Lượng Sách"].Points.AddXY("Đã Mượn", txtSLSachMuon.Text);
            chSach.Series["Số Lượng Sách"].Points.AddXY("Còn Lại", txtSLConLai.Text);
            chSach.Series["Số Lượng Sách"].Points.AddXY("Quá Hạn", txtSachQuaHan.Text);

            string query = "select PHIEUMUON.MaPM,PHIEUMUON.MaDG,CTPHIEUMUON.MaSach,SACH.TenSach,CTPHIEUMUON.SoLuong,datediff(day,PHIEUMUON.NgayTra,GETDATE()) as SoNgayQH from PHIEUMUON inner join CTPHIEUMUON on PHIEUMUON.MaPM = CTPHIEUMUON.MaPM inner join SACH on CTPHIEUMUON.MaSach = SACH.MaSach where PHIEUMUON.TrangThai = 'False' and datediff(day, PHIEUMUON.NgayTra, GETDATE())> 0";
            tblSachQuaHan = new DataTable();
            rdTheoMS.Checked = true;
            SqlDataAdapter da = new SqlDataAdapter(query,XLBang.cnnStr);
            try
            {
                da.Fill(tblSachQuaHan);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            DSPM = this.BindingContext[tblSachQuaHan];
            dgvDSSQH.AutoGenerateColumns = false;
            dgvDSSQH.DataSource = tblSachQuaHan;
        }

        private void dgvDSSQH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSSQH.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdTheoMS.Checked == true)
            {
                string std = string.Format("MaSach like '%{0}%'", txtTimKiem.Text);
                tblSachQuaHan.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("TenSach like '%{0}%'", txtTimKiem.Text);
                tblSachQuaHan.DefaultView.RowFilter = std;
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dgvDSSQH.RowCount == 1)
            {
                MessageBox.Show("Không có thông tin dữ liệu cần tìm!!!");
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }
    }
}
