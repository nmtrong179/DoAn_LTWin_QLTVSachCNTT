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
    public partial class frmCTPhieuMuon : Form
    {
        XLCTPhieuMuon tblCTPhieuMuon;
        XLSach tblSach;
        bool capNhat = false;
        BindingManagerBase DSCTPM;
        SqlDataAdapter daCTPhieuMuon;
        public frmCTPhieuMuon()
        {
            InitializeComponent();
        }

        private void enabledButton()
        {
            btnThem.Enabled = !capNhat;
            btnXoa.Enabled = !capNhat;
            btnSua.Enabled = !capNhat;
            gTTCTPhieuMuon.Enabled = capNhat;
            gTimKiem.Enabled = !capNhat;
            btnLuu.Enabled = capNhat;
            btnHuy.Enabled = capNhat;
            dgvCTPM.Enabled = !capNhat;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSCTPM.AddNew();
            capNhat = true;
            enabledButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Xu ly remove tabpage
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void frmCTPhieuMuon_Load(object sender, EventArgs e)
        {
            tblCTPhieuMuon = new XLCTPhieuMuon();
            tblSach = new XLSach();
            rdTheoMaPM.Checked = true;
            daCTPhieuMuon = new SqlDataAdapter("Select * from CTPHIEUMUON", XLDocGia.cnnStr);
            loadMaSach();
            try
            {
                daCTPhieuMuon.Fill(tblCTPhieuMuon);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daCTPhieuMuon);
            txtMaPM.DataBindings.Add("text", tblCTPhieuMuon, "MaPM", true);
            cbMaSach.DataBindings.Add("SelectedValue", tblCTPhieuMuon, "MaSach", true);
            nudSoLuong.DataBindings.Add("text", tblCTPhieuMuon, "SoLuong", true);
            DSCTPM = this.BindingContext[tblCTPhieuMuon];
            enabledButton();
            dgvCTPM.AutoGenerateColumns = false;
            dgvCTPM.DataSource = tblCTPhieuMuon;
        }
        private void loadMaSach()
        {
            cbMaSach.DataSource = tblSach;
            cbMaSach.ValueMember = "MaSach";
            cbMaSach.DisplayMember = "MaSach";
        }

        private void dgvCTPM_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvCTPM.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSCTPM.CancelCurrentEdit();
            tblCTPhieuMuon.RejectChanges();
            capNhat = false;
            enabledButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSCTPM.RemoveAt(DSCTPM.Position);
                daCTPhieuMuon.Update(tblCTPhieuMuon);
                tblCTPhieuMuon.AcceptChanges();
                MessageBox.Show("Xoá thành công!");
            }
            catch
            {
                tblCTPhieuMuon.RejectChanges();
                MessageBox.Show("Xoá thất bại!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capNhat = true;
            txtMaPM.Enabled = false;
            enabledButton();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdTheoMaPM.Checked == true)
            {
                string std = string.Format("MaPM like '%{0}%'", txtTimKiem.Text);
                tblCTPhieuMuon.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("MaSach like '%{0}%'", txtTimKiem.Text);
                tblCTPhieuMuon.DefaultView.RowFilter = std;
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dgvCTPM.RowCount == 1)
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSCTPM.EndCurrentEdit();
                daCTPhieuMuon.Update(tblCTPhieuMuon);
                tblCTPhieuMuon.AcceptChanges();
                MessageBox.Show("Cập nhật thành công!");
                capNhat = false;
                enabledButton();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại!");
                txtMaPM.Focus();
            }
        }
    }
}
