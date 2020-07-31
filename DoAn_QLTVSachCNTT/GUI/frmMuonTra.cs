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
    public partial class frmMuonTra : Form
    {

        XLPhieuMuon tblPhieuMuon;
        XLCTPhieuMuon tblCTPhieuMuon;
        XLDocGia tblDocGia;
        XLNhanVien tblNhanVien;
        XLSach tblSach;
        bool capNhat = false;
        BindingManagerBase DSPM;
        SqlDataAdapter daPhieuMuon, daCTPhieuMuon, daDocGia, daNhanVien, daSach;
        public frmMuonTra()
        {
            InitializeComponent();
        }

        private void enabledButton()
        {
            btnLapPhieu.Enabled = !capNhat;
            btnGiaHan.Enabled = !capNhat;
            btnTraSach.Enabled = !capNhat;
            gTTPM.Enabled = capNhat;
            gTimKiem.Enabled = !capNhat;
            btnLuu.Enabled = capNhat;
            btnHuy.Enabled = capNhat;
            btnIn.Enabled = capNhat;
            dgvDSPM.Enabled = !capNhat;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            //Xu ly remove tabpage doi mat khau
            TabPage p = (TabPage)this.Parent;
            TabControl tabMain = (TabControl)p.Parent;
            tabMain.TabPages.Remove(p);
        }

        private void btnLapPhieu_Click(object sender, EventArgs e)
        {
            DSPM.AddNew();
            capNhat = true;
            enabledButton();
        }

        private void frmMuonTra_Load(object sender, EventArgs e)
        {
            tblPhieuMuon = new XLPhieuMuon();
            tblCTPhieuMuon = new XLCTPhieuMuon();
            tblNhanVien = new XLNhanVien();
            tblDocGia = new XLDocGia();
            tblSach = new XLSach();
            rdTheoMaDG.Checked = true;
            loadDocGia();
            loadSach();
            loadNhanVien();
            loadPhieuMuon();
            loadCTPhieuMuon();
            daPhieuMuon = new SqlDataAdapter("Select * from PHIEUMUON", XLPhieuMuon.cnnStr);
            daCTPhieuMuon = new SqlDataAdapter("Select * from CTPHIEUMUON", XLCTPhieuMuon.cnnStr);
            daDocGia = new SqlDataAdapter("Select * from DOCGIA", XLDocGia.cnnStr);
            daNhanVien = new SqlDataAdapter("Select * from NHANVIEN", XLNhanVien.cnnStr);
            daSach = new SqlDataAdapter("Select * from SACH", XLSach.cnnStr);
            try
            {
                daCTPhieuMuon.Fill(tblCTPhieuMuon);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daPhieuMuon);

            cbMaDG.DataBindings.Add("SelectedValue", tblCTPhieuMuon, "MaDG", true);
            cbMaNV.DataBindings.Add("SelectedValue", tblCTPhieuMuon, "MaNV", true);
            cbMaSach.DataBindings.Add("SelectedValue", tblCTPhieuMuon, "MaSach", true);
            cbMaPM.DataBindings.Add("SelectedValue", tblCTPhieuMuon, "MaPM", true);
            nudSL.DataBindings.Add("text", tblCTPhieuMuon, "SoLuong", true);
            dtMuon.DataBindings.Add("text", tblCTPhieuMuon, "NgayMuon", true);
            dtTra.DataBindings.Add("text", tblCTPhieuMuon, "NgayTra", true);
            rdChuaTra.DataBindings.Add("checked", tblCTPhieuMuon, "TrangThai", true);
            DSPM = this.BindingContext[tblCTPhieuMuon];
            enabledButton();
            dgvDSPM.AutoGenerateColumns = false;
            dgvDSPM.DataSource = tblCTPhieuMuon;
        }

        private void loadDocGia()
        {
            cbMaDG.DataSource = tblDocGia;
            cbMaDG.ValueMember = "MaDG";
            cbMaDG.DisplayMember = "MaDG";
        }
        private void loadSach()
        {
            cbMaSach.DataSource = tblSach;
            cbMaSach.ValueMember = "MaSach";
            cbMaSach.DisplayMember = "MaSach";
        }

        private void dgvDSPM_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvDSPM.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void loadNhanVien()
        {
            cbMaNV.DataSource = tblNhanVien;
            cbMaNV.ValueMember = "MaNV";
            cbMaNV.DisplayMember = "MaNV";
        }

        private void btnTraSach_Click(object sender, EventArgs e)
        {
            btnXacNhanTra.Enabled = true;
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Muốn Gia Hạn ?", "Thông Báo Gia Hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void rdChuaTra_CheckedChanged(object sender, EventArgs e)
        {
            rdDaTra.Checked = !rdChuaTra.Checked;
        }

        private void loadPhieuMuon()
        {
            cbMaPM.DataSource = tblPhieuMuon;
            cbMaPM.ValueMember = "MaPM";
            cbMaPM.DisplayMember = "MaPM";
        }

        private void loadCTPhieuMuon()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblPhieuMuon, tblCTPhieuMuon });
            DataRelation qh = new DataRelation("FRK_PHIEUMUON_CTPHIEUMUON", tblPhieuMuon.Columns["MaPM"], tblCTPhieuMuon.Columns["MaPM"]);
            ds.Relations.Add(qh);
            DataColumn cMaNV = new DataColumn("MaNV", Type.GetType("System.String"), "Parent(FRK_PHIEUMUON_CTPHIEUMUON).MaNV");
            DataColumn cMaDG = new DataColumn("MaDG", Type.GetType("System.String"), "Parent(FRK_PHIEUMUON_CTPHIEUMUON).MaDG");
            DataColumn cNgayTra = new DataColumn("NgayTra", Type.GetType("System.String"), "Parent(FRK_PHIEUMUON_CTPHIEUMUON).NgayTra");
            DataColumn cNgayMuon = new DataColumn("NgayMuon", Type.GetType("System.String"), "Parent(FRK_PHIEUMUON_CTPHIEUMUON).NgayMuon");
            tblCTPhieuMuon.Columns.Add(cMaNV);
            tblCTPhieuMuon.Columns.Add(cMaDG);
            tblCTPhieuMuon.Columns.Add(cNgayTra);
            tblCTPhieuMuon.Columns.Add(cNgayMuon);
        }
        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdTheoMaDG.Checked == true)
            {
                string std = string.Format("MaDG like '%{0}%'", txtTimKiem.Text);
                tblPhieuMuon.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("MaPM like '%{0}%'", txtTimKiem.Text);
                tblPhieuMuon.DefaultView.RowFilter = std;
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }
    }
}
