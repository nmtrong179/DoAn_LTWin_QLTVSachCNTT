using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.Collections;
using DoAn_QLTVSachCNTT.DATA;
using DevExpress.Data.TreeList;

namespace DoAn_QLTVSachCNTT
{
    public partial class frmDangNhap : Form
    {
        frmMain fMain = null;
        XLTaiKhoan tblTaiKhoan;
        XLNhanVien tblNhanVien;
        string[] tenTK = new string[5];
        int[] soLanDN = new int[5];
        int n = 0;
        //Construct coi tham so la frmMain
        public frmDangNhap(frmMain pf)
        {
            fMain = pf;
            InitializeComponent();
        }

        private void chbPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPass.Checked)
                txtMatKhau.UseSystemPasswordChar = false;
            else txtMatKhau.UseSystemPasswordChar = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text == "")
            {
                lbbaoloi.Text = "Tên Tài Khoản Không Được Để Trống!";
                this.txtTenTK.Focus();
            }
            else if (txtMatKhau.Text == "")
            {
                lbbaoloi.Text = "Mật Khẩu Không Được Để Trống!";
                this.txtMatKhau.Focus();
            }
            else
            {
                lbbaoloi.Text = "";
                tblTaiKhoan = new XLTaiKhoan();
                var r = tblTaiKhoan.Select("TenTK='" + txtTenTK.Text + "' and MatKhau ='" + txtMatKhau.Text + "'");
                if (r.Count() > 0)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (txtTenTK.Text == tenTK[i])
                        {
                            soLanDN[i] = 0;
                        }
                    }
                    clTruyenDL.id = r[0]["ID"].ToString();
                    tblNhanVien = new XLNhanVien();
                    var k = tblNhanVien.Select("ID='" + clTruyenDL.id +"'");
                    fMain.Text = "Quản Lý Thư Viện Sách CNTT J2Team - Xin Chào "+k[0]["HoTenNV"];
                    clTruyenDL.matKhau = r[0]["MatKhau"].ToString();
                    fMain.enableControl((int)r[0]["LoaiTK"]);
                    this.Close();
                }
                else
                {
                    for (int i = 0; i < 5; i++)
                    {
                        if (txtTenTK.Text == tenTK[i])
                        {
                            soLanDN[i] += 1;
                            if (soLanDN[i] > 3)
                            {
                                MessageBox.Show("Sai Quá 3 lần, Đã Khoá Tài! Vui Lòng Gặp Quản Lý Để Mở Lại Tài Khoản.");
                                txtTenTK.Enabled = false;
                                txtMatKhau.Enabled = false;
                                btnDangNhap.Enabled = false;
                            }
                            else
                            {
                                MessageBox.Show("Thông Tin Tài Khoản Hoặc Mật Khẩu Không Chính Xác!!!");
                                this.txtTenTK.Focus();
                                break;
                            }
                        }
                        else
                        {
                            tenTK[n] = txtTenTK.Text;
                            soLanDN[n] += 1;
                            n += 1;
                            MessageBox.Show("Thông Tin Tài Khoản Hoặc Mật Khẩu Không Chính Xác!!!");
                            this.txtTenTK.Focus();
                            break;
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Enter)
            { btnDangNhap_Click(sender, e); }
        }
    }
}
