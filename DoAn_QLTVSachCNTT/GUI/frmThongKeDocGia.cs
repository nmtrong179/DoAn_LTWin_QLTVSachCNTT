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

        private void frmThongKeDocGia_Load(object sender, EventArgs e)
        {
            string a = "Select count(*) from DOCGIA";
            var m = XLDocGia.Thuc_hien_lenh_tinh_toan(a);
            txtSLDG.Text = m.ToString();
            string b = "Select count(MaDG) from PHIEUMUON";
            var n = XLPhieuMuon.Thuc_hien_lenh_tinh_toan(b);
            txtSLDGDM.Text = n.ToString();
            string c = "Select Count(*) from PHIEUMUON where DATEDIFF(day,NgayTra,getdate())>0 and TrangThai='False'";
            var o = XLPhieuMuon.Thuc_hien_lenh_tinh_toan(c);
            txtSLDGQH.Text = o.ToString();
            string d = "Select count(*) from DOCGIA where MaDG not in (Select distinct MaDG from PHIEUMUON)";
            var p = XLDocGia.Thuc_hien_lenh_tinh_toan(d);
            //Ve bieu do
            ChDG.Series["Số Lượng Độc Giả"].Points.AddXY("Đã Mượn", txtSLDGDM.Text);
            ChDG.Series["Số Lượng Độc Giả"].Points.AddXY("Mượn Quá Hạn", txtSLDGQH.Text);
            ChDG.Series["Số Lượng Độc Giả"].Points.AddXY("Chưa Mượn", p.ToString());
        }
    }
}
