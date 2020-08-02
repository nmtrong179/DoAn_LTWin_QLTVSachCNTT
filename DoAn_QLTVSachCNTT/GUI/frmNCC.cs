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
    public partial class frmNCC : Form
    {
        XLNhaCungCap tblNCC;
        bool capNhat = false;
        BindingManagerBase DSNCC;
        SqlDataAdapter daNCC;
        public frmNCC()
        {
            InitializeComponent();
        }

        private void frmNCC_Load(object sender, EventArgs e)
        {
            tblNCC = new XLNhaCungCap();
            rdTheoMa.Checked = true;
            daNCC = new SqlDataAdapter("Select * from NHACUNGCAP", XLNhaCungCap.cnnStr);
            try
            {
                daNCC.Fill(tblNCC);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daNCC);

            txtMaNCC.DataBindings.Add("text", tblNCC, "MaNCC", true);
            txtTenNCC.DataBindings.Add("text", tblNCC, "TenNCC", true);
            txtDiaChi.DataBindings.Add("text", tblNCC, "DiaChi", true);
            txtSDT.DataBindings.Add("text", tblNCC, "SDT", true);
            DSNCC = this.BindingContext[tblNCC];
            enabledButton();
            dgvTTNCC.AutoGenerateColumns = false;
            dgvTTNCC.DataSource = tblNCC;
        }

        private void enabledButton()
        {
            btnThem.Enabled = !capNhat;
            btnXoa.Enabled = !capNhat;
            btnSua.Enabled = !capNhat;
            gTTNCC.Enabled = capNhat;
            gTimKiem.Enabled = !capNhat;
            btnLuu.Enabled = capNhat;
            btnHuy.Enabled = capNhat;
        }

        private void dgvTTNCC_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvTTNCC.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSNCC.AddNew();
            capNhat = true;
            enabledButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSNCC.CancelCurrentEdit();
            tblNCC.RejectChanges();
            capNhat = false;
            enabledButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSNCC.RemoveAt(DSNCC.Position);
                daNCC.Update(tblNCC);
                tblNCC.AcceptChanges();
                MessageBox.Show("Xoá thành công!");
            }
            catch
            {
                tblNCC.RejectChanges();
                MessageBox.Show("Xoá thất bại!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaNCC.Enabled = false;
            capNhat = true;
            enabledButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Xu ly remove tabpage doi mat khau
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdTheoMa.Checked == true)
            {
                string std = string.Format("MaNCC like '%{0}%'", txtTimKiem.Text);
                tblNCC.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("TenNCC like '%{0}%'", txtTimKiem.Text);
                tblNCC.DefaultView.RowFilter = std;
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dgvTTNCC.RowCount == 1)
            {
                MessageBox.Show("Không tìm thấy!");
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSNCC.EndCurrentEdit();
                daNCC.Update(tblNCC);
                tblNCC.AcceptChanges();
                MessageBox.Show("Cập nhật thành công!");
                capNhat = false;
                enabledButton();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại!");
                txtMaNCC.Focus();
            }
        }
    }
}
