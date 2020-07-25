using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DoAn_QLTVSachCNTT.DATA;

namespace DoAn_QLTVSachCNTT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        frmDangNhap login = new frmDangNhap();
        public frmMain()
        {
            InitializeComponent();
        }
        //Variable Gobal
        frmDoiMatKhau fDoiMatKhau;
        public string matKhau,id;
        //XU ly phan quyen
        public void enableControl(int LoaiTK)
        {
            switch (LoaiTK)
            {
                case 1://Quan ly (admin)
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnSach.Enabled = true;
                    btnMuonTra.Enabled = true;
                    btnGioiThieu.Enabled = true;
                    btnQuyDinh.Enabled = true;
                    btnDocGia.Enabled = true;
                    btnThuThu.Enabled = true;
                    btnNCC.Enabled = true;
                    btnTaiKhoan.Enabled = true;
                    btnTKSach.Enabled = true;
                    btnTKDocGia.Enabled = true;
                    break;
                case 0: //Thu Thu
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    btnSach.Enabled = true;
                    btnMuonTra.Enabled = true;
                    btnGioiThieu.Enabled = true;
                    btnQuyDinh.Enabled = true;
                    btnDocGia.Enabled = true;
                    btnThuThu.Enabled = false;
                    btnNCC.Enabled = false;
                    btnTaiKhoan.Enabled = false;
                    btnTKSach.Enabled = false;
                    btnTKDocGia.Enabled = false;
                    break;
                default:
                    btnDangXuat.Enabled = false;
                    btnDoiMK.Enabled = false;
                    btnSach.Enabled = false;
                    btnMuonTra.Enabled = false;
                    btnGioiThieu.Enabled = true;
                    btnQuyDinh.Enabled = true;
                    btnDocGia.Enabled = false;
                    btnThuThu.Enabled = false;
                    btnNCC.Enabled = false;
                    btnTaiKhoan.Enabled = false;
                    btnTKSach.Enabled = false;
                    btnTKDocGia.Enabled = false;
                    break;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            enableControl(-1);
            frmDangNhap f = new frmDangNhap();
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
            f.WindowState = FormWindowState.Normal;
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Xu ly dong tat ca form con
            foreach (Form f in this.MdiChildren)
            {
                this.Close();
            }
            frmMain_Load(sender, e);
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            if(fDoiMatKhau == null)
            {
                fDoiMatKhau = new frmDoiMatKhau();
                fDoiMatKhau.MdiParent = this;
                fDoiMatKhau.WindowState = FormWindowState.Maximized;
                fDoiMatKhau.Show();
            }
            else
            {
                fDoiMatKhau.Activate();
                fDoiMatKhau.Show();
            }
        }
    }
}
