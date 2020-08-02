using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAn_QLTVSachCNTT.DATA;

namespace DoAn_QLTVSachCNTT
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAll.Checked)
            {
                txtMKHT.UseSystemPasswordChar = false;
                txtMKM.UseSystemPasswordChar = false;
                txtNLMKM.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKHT.UseSystemPasswordChar = true;
                txtMKM.UseSystemPasswordChar = true;
                txtNLMKM.UseSystemPasswordChar = true;
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            errorProvider1.SetError(txtMKHT, "");
            errorProvider1.SetError(txtMKM, "");
            errorProvider1.SetError(txtNLMKM, "");
            //check Mat Khau Hien Tai
            if (txtMKHT.Text == "")
            {
                errorProvider1.SetError(txtMKHT, "Mật Khẩu Hiện Tại Không Được Bỏ Trống!!!");
                return;
            }
            else if (txtMKHT.Text != clTruyenDL.matKhau)
            {
                errorProvider1.SetError(txtMKHT, "Mật Khẩu Không Chính Xác!!!");
                return;
            }
            //check Mat Khau Moi
            if (txtMKM.Text == "")
            {
                errorProvider1.SetError(txtMKM, "Mật Khẩu Mới Không Được Bỏ Trống!!!");
                return;
            }
            else if (txtMKM.Text.Length < 8 || !txtMKM.Text.Any(char.IsDigit) || !txtMKM.Text.Any(char.IsLower) || !txtMKM.Text.Any(char.IsUpper))
            {
                errorProvider1.SetError(txtMKM, "Mật khẩu mới tối thiểu 8 kí tự, gồm chữ số, chữ in hoa, chữ thường.");
                return;
            }
            //check Mat Khau Nhap Lai
            if (txtNLMKM.Text == "")
            {
                errorProvider1.SetError(txtNLMKM, "Mật Khẩu Hiện Tại Không Được Bỏ Trống!!!");
                return;

            }
            else if (txtMKM.Text != txtNLMKM.Text)
            {
                errorProvider1.SetError(txtNLMKM, "Mật khẩu nhập lại không trùng khớp!!!");
                return;
            }
            
            int count = XLBang.Thuc_hien_lenh("Update TAIKHOAN set MatKhau='" + txtMKM.Text + "' where ID ='" + clTruyenDL.id + "'");
            if (count > 0)
            {
                MessageBox.Show("Mật khẩu đã được cập nhật.");
                clTruyenDL.matKhau = txtMKM.Text;
            }
            else
                MessageBox.Show("Mật khẩu không hợp lệ!!!");
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            //Xu ly remove tabpage doi mat khau
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            //full man hinh
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
