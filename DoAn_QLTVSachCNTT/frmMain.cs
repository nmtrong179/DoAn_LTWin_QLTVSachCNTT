using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
using DevExpress.XtraBars;
using System.Windows.Forms.VisualStyles;
using DoAn_QLTVSachCNTT.DATA;
using System.Drawing.Design;

namespace DoAn_QLTVSachCNTT
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        //XU ly phan quyen
        public void enableControl(int LoaiTK)
        {
            switch (LoaiTK)
            {
                case 1://Quan ly (admin)
                    btnDangXuat.Enabled = true;
                    btnDoiMK.Enabled = true;
                    rbSach.Enabled = true;
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
                    rbSach.Enabled = true;
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
                    rbSach.Enabled = false;
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
            //full man hinh
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            //Disable tat ca cac button
            enableControl(-1);
            //show formDangNhap
            //Truyen frmMain cho frmDangNhap qua construct
            frmDangNhap f = new frmDangNhap(this);
            f.StartPosition = FormStartPosition.CenterScreen;
            f.WindowState = FormWindowState.Normal;
            f.ShowDialog();
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            //Xu ly xoa tat ca tabpage trong tabControlMain
            tabControlMain.TabPages.Clear();
            frmMain_Load(sender, e);
        }

        private void btnSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageSach");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmSach f = new frmSach();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageSach";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnMuonTra_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageMuonTra");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmMuonTra f = new frmMuonTra();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageMuonTra";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageDocGia");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmDocGia f = new frmDocGia();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageDocGia";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnThuThu_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageThuThu");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmThuThu f = new frmThuThu();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageThuThu";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnNCC_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageNhaCungCap");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmNCC f = new frmNCC();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageNhaCungCap";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnTaiKhoan_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageTaiKhoan");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmTaiKhoan f = new frmTaiKhoan();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageTaiKhoan";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnTKSach_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageThongKeSach");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmThongKeSach f = new frmThongKeSach();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageThongKeSach";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnTKDocGia_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageThongKeDocGia");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmThongKeDocGia f = new frmThongKeDocGia();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageThongKeDocGia";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void tabControlMain_ControlAdded(object sender, ControlEventArgs e)
        {
            //khi add tab moi focus den no
            tabControlMain.SelectedIndex = tabControlMain.TabPages.Count - 1;
        }

        private void tabControlMain_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Graphics g = e.Graphics;
            Font drawFont = new Font("Arial", 9,FontStyle.Bold);
            g.FillRectangle(new SolidBrush(Color.DarkGray), e.Bounds);
            e.Graphics.DrawString("X", drawFont, Brushes.White, e.Bounds.Right - 12, e.Bounds.Top + 4);
            e.Graphics.DrawString(this.tabControlMain.TabPages[e.Index].Text, e.Font, Brushes.DarkBlue, e.Bounds.Left + 1, e.Bounds.Top + 4);
            e.DrawFocusRectangle();
        }

        private void tabControlMain_MouseDown(object sender, MouseEventArgs e)
        {
            //Looping through the controls.
            for (int i = 0; i < this.tabControlMain.TabPages.Count; i++)
            {
                Rectangle r = tabControlMain.GetTabRect(i);
                //Getting the position of the “x” mark.
                Rectangle closeButton = new Rectangle(r.Right - 12, r.Top + 4, 9, 7);
                if (closeButton.Contains(e.Location))
                {
                    if (MessageBox.Show("Bạn Có Chắc Muốn Đóng Tab ?", "Đóng Tab", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.tabControlMain.TabPages.RemoveAt(i);
                        break;
                    }
                }
            }
        }

        private void btnGioiThieu_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageGioiThieuChung");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmGioiThieu f = new frmGioiThieu();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageGioiThieuChung";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnQuyDinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageQuyDinhChung");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmQuyDinh f = new frmQuyDinh();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageQuyDinhChung";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageChiTietPhieuMuon");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmCTPhieuMuon f = new frmCTPhieuMuon();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageChiTietPhieuMuon";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }

        private void btnDoiMK_ItemClick(object sender, ItemClickEventArgs e)
        {
            //XL ly tabpage da ton chi active
            int index = tabControlMain.TabPages.IndexOfKey("tabPageDoiMatKhau");
            if (index >= 0)
                tabControlMain.SelectedIndex = index;
            else // Truong hop chua co tao moi tabpage
            {
                frmDoiMatKhau f = new frmDoiMatKhau();
                TabPage p = new TabPage(f.Text);
                p.Name = "tabPageDoiMatKhau";
                f.TopLevel = false;
                p.Controls.Add(f);
                f.Dock = DockStyle.Fill;
                f.FormBorderStyle = FormBorderStyle.None;
                tabControlMain.TabPages.Add(p);
                f.Show();
            }
        }
    }
}
