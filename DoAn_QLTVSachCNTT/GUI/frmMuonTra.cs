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
            btnXoa.Enabled = !capNhat;
            dgvDSPM.Enabled = !capNhat;
            btnSua.Enabled = !capNhat;
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
            loadNhanVien();
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

            cbMaDG.DataBindings.Add("SelectedValue", tblPhieuMuon, "MaDG", true);
            cbMaNV.DataBindings.Add("SelectedValue", tblPhieuMuon, "MaNV", true);
            txtMaPM.DataBindings.Add("text", tblPhieuMuon, "MaPM", true);
            dtMuon.DataBindings.Add("text", tblPhieuMuon, "NgayMuon", true);
            dtTra.DataBindings.Add("text", tblPhieuMuon, "NgayTra", true);
            rdDaTra.DataBindings.Add("checked", tblPhieuMuon, "TrangThai", true);
            DSPM = this.BindingContext[tblPhieuMuon];
            enabledButton();
            dgvDSPM.AutoGenerateColumns = false;
            dgvDSPM.DataSource = tblPhieuMuon;
        }

        private void loadDocGia()
        {
            cbMaDG.DataSource = tblDocGia;
            cbMaDG.ValueMember = "MaDG";
            cbMaDG.DisplayMember = "MaDG";
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

            if (rdChuaTra.Checked == true)
            {
                if (MessageBox.Show("Bạn Có Chắc Muốn Trả Sách ?", "Thông Báo Trả Sách", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    rdDaTra.Checked = true;
                    try
                    {
                        DSPM.EndCurrentEdit();
                        daPhieuMuon.Update(tblPhieuMuon);
                        tblPhieuMuon.AcceptChanges();
                        MessageBox.Show("Trả sách thành công!");
                        capNhat = false;
                        enabledButton();
                    }
                    catch
                    {
                        MessageBox.Show("Trả sách thất bại!");
                        txtMaPM.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("Sách đã được trả từ trước!!!");
            }    
        
        }

        private void btnGiaHan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Chắc Muốn Gia Hạn ?", "Thông Báo Gia Hạn", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string x = "Select DateAdd(day,10,NgayTra) from PHIEUMUON where MaPM='" + txtMaPM.Text + "' and TrangThai='False'";
                var y = XLPhieuMuon.Thuc_hien_lenh_tinh_toan(x);
                if (y == null)
                {
                    MessageBox.Show("Sách không thể gia hạn!!!");
                }
                else
                {
                    dtTra.Text = y.ToString();
                    try
                    {
                        DSPM.EndCurrentEdit();
                        daPhieuMuon.Update(tblPhieuMuon);
                        tblPhieuMuon.AcceptChanges();
                        MessageBox.Show("Gia hạn thành công!");
                        capNhat = false;
                        enabledButton();
                    }
                    catch
                    {
                        MessageBox.Show("Gia hạn thất bại!");
                        txtMaPM.Focus();
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSPM.RemoveAt(DSPM.Position);
                daPhieuMuon.Update(tblPhieuMuon);
                tblPhieuMuon.AcceptChanges();
                MessageBox.Show("Xoá thành công!");
            }
            catch
            {
                tblPhieuMuon.RejectChanges();
                MessageBox.Show("Xoá thất bại!!!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSPM.EndCurrentEdit();
                daPhieuMuon.Update(tblPhieuMuon);
                tblPhieuMuon.AcceptChanges();
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

        private void rdDaTra_CheckedChanged(object sender, EventArgs e)
        {
            rdChuaTra.Checked = !rdDaTra.Checked;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            txtMaPM.Enabled = false;
            capNhat = true;
            enabledButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSPM.CancelCurrentEdit();
            tblPhieuMuon.RejectChanges();
            capNhat = false;
            enabledButton();
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
