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

        XLPhieuMuon tblPhieuMuon;
        BindingManagerBase DSPM;
        SqlDataAdapter daPM;

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

            tblPhieuMuon = new XLPhieuMuon();
            daPM = new SqlDataAdapter("Select * from PHIEUMUON", XLPhieuMuon.cnnStr);
            try
            {
                daPM.Fill(tblPhieuMuon);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            DSPM = this.BindingContext[tblPhieuMuon];
            dgvDSSQH.AutoGenerateColumns = false;
            dgvDSSQH.DataSource = tblPhieuMuon;
        }

        private void dgvDSSQH_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSSQH.Rows)
                r.Cells[0].Value = r.Index + 1;
        }
    }
}
