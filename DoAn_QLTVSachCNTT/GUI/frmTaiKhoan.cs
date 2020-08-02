using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.IO;
using DoAn_QLTVSachCNTT.DATA;

namespace DoAn_QLTVSachCNTT
{
    public partial class frmTaiKhoan : Form
    {
        XLTaiKhoan tblTaiKhoan;
        bool capNhat = false;
        BindingManagerBase DSTK;
        SqlDataAdapter daTaiKhoan;
        public frmTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Xu ly remove tabpage doi mat khau
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSTK.AddNew();
            capNhat = true;
            enabledButton();
        }

        private void enabledButton()
        {
            btnThem.Enabled = !capNhat;
            btnXoa.Enabled = !capNhat;
            btnSua.Enabled = !capNhat;
            gTTTK.Enabled = capNhat;
            gTimKiem.Enabled = !capNhat;
            btnLuu.Enabled = capNhat;
            btnHuy.Enabled = capNhat;
            dgvDSTK.Enabled = !capNhat;
        }

        private void frmTaiKhoan_Load(object sender, EventArgs e)
        {
            tblTaiKhoan = new XLTaiKhoan();
            rdTheoID.Checked = true;
            daTaiKhoan = new SqlDataAdapter("Select * from TAIKHOAN", XLTaiKhoan.cnnStr);
            try
            {
                daTaiKhoan.Fill(tblTaiKhoan);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daTaiKhoan);
            txtID.DataBindings.Add("text", tblTaiKhoan, "ID", true);
            txtTenTK.DataBindings.Add("text", tblTaiKhoan, "TenTK", true);
            txtMatKhau.DataBindings.Add("text", tblTaiKhoan, "MatKhau", true);
            rdQL.DataBindings.Add("checked", tblTaiKhoan, "LoaiTK", true);
            DSTK = this.BindingContext[tblTaiKhoan];
            enabledButton();
            dgvDSTK.AutoGenerateColumns = false;
            dgvDSTK.DataSource = tblTaiKhoan;
        }

        private void dgvDSTK_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSTK.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSTK.CancelCurrentEdit();
            tblTaiKhoan.RejectChanges();
            capNhat = false;
            enabledButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSTK.RemoveAt(DSTK.Position);
                daTaiKhoan.Update(tblTaiKhoan);
                tblTaiKhoan.AcceptChanges();
                MessageBox.Show("Xoá thành công!");
            }
            catch
            {
                tblTaiKhoan.RejectChanges();
                MessageBox.Show("Xoá thất bại!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capNhat = true;
            txtID.Enabled = false;
            enabledButton();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdTheoID.Checked == true)
            {
                string std = string.Format("ID like '%{0}%'", txtTimKiem.Text);
                tblTaiKhoan.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("TenTK like '%{0}%'", txtTimKiem.Text);
                tblTaiKhoan.DefaultView.RowFilter = std;
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dgvDSTK.RowCount == 1)
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSTK.EndCurrentEdit();
                daTaiKhoan.Update(tblTaiKhoan);
                tblTaiKhoan.AcceptChanges();
                MessageBox.Show("Cập nhật thành công!");
                capNhat = false;
                enabledButton();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại!");
                txtID.Focus();
            }
        }

        private void rdQL_CheckedChanged(object sender, EventArgs e)
        {
            rdTT.Checked = !rdQL.Checked;
        }
    }
}
