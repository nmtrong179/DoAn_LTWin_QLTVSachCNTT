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
        public frmCTPhieuMuon()
        {
            InitializeComponent();
        }

        XLPhieuMuon tblPhieuMuon;
        XLCTPhieuMuon tblCTPhieuMuon;
        XLSach tblSach;
        bool capNhat = false;
        BindingManagerBase DSCTPM;
        SqlDataAdapter daCTPM;

        private void frmCTPhieuMuon_Load(object sender, EventArgs e)
        {
            tblSach = new XLSach();
            tblPhieuMuon = new XLPhieuMuon();
            tblCTPhieuMuon = new XLCTPhieuMuon();
            rdTheoMaPM.Checked = true;
            daCTPM = new SqlDataAdapter("Select * from CTPHIEUMUON", XLCTPhieuMuon.cnnStr);
            try
            {
                daCTPM.Fill(tblCTPhieuMuon);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            loadPM();
            loadMaSach();
            cbMaPM.DataBindings.Add("SelectedValue", tblCTPhieuMuon, "MaPM", true);
            cbMaSach.DataBindings.Add("SelectedValue", tblCTPhieuMuon, "MaSach", true);
            nudSL.DataBindings.Add("text", tblCTPhieuMuon, "SoLuong", true);
            var cmb = new SqlCommandBuilder(daCTPM);
            DSCTPM = this.BindingContext[tblCTPhieuMuon];
            enabledButton();
            dgvCTPM.AutoGenerateColumns = false;
            dgvCTPM.DataSource = tblCTPhieuMuon;
        }
        private void loadPM()
        {
            cbMaPM.DataSource = tblPhieuMuon;
            cbMaPM.ValueMember = "MaPM";
            cbMaPM.DisplayMember = "MaPM";
        }

        private void loadMaSach()
        {
            cbMaSach.DataSource = tblSach;
            cbMaSach.ValueMember = "MaSach";
            cbMaSach.DisplayMember = "MaSach";
        }
        private void enabledButton()
        {
            btnThem.Enabled = !capNhat;
            btnXoa.Enabled = !capNhat;
            btnSua.Enabled = !capNhat;
            gCTPM.Enabled = capNhat;
            gTimKiem.Enabled = !capNhat;
            btnLuu.Enabled = capNhat;
            btnHuy.Enabled = capNhat;
            dgvCTPM.Enabled = !capNhat;
        }

        private void dgvCTPM_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvCTPM.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSCTPM.AddNew();
            capNhat = true;
            enabledButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSCTPM.RemoveAt(DSCTPM.Position);
                daCTPM.Update(tblCTPhieuMuon);
                tblCTPhieuMuon.AcceptChanges();
                MessageBox.Show("Xoá thành công!");
            }
            catch
            {
                tblSach.RejectChanges();
                MessageBox.Show("Xoá thất bại!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capNhat = true;
            cbMaPM.Enabled = false;
            enabledButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Xu ly remove tabpage
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSCTPM.EndCurrentEdit();
                daCTPM.Update(tblCTPhieuMuon);
                tblCTPhieuMuon.AcceptChanges();
                MessageBox.Show("Cập nhật thành công!");
                capNhat = false;
                enabledButton();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại!");
                cbMaPM.Focus();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSCTPM.CancelCurrentEdit();
            tblCTPhieuMuon.RejectChanges();
            capNhat = false;
            enabledButton();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dgvCTPM.RowCount == 1)
            {
                MessageBox.Show("Không có thông tin dữ liệu cần tìm!!!");
            }
        }
    }
}
