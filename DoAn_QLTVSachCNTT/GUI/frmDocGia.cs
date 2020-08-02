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
    public partial class frmDocGia : Form
    {
        XLDocGia tblDocGia;
        bool capNhat = false;
        BindingManagerBase DSDG;
        SqlDataAdapter daDocGia;
        public frmDocGia()
        {
            InitializeComponent();
        }

        private void frmDocGia_Load(object sender, EventArgs e)
        {
            tblDocGia = new XLDocGia();
            rdTheoMa.Checked = true;
            daDocGia = new SqlDataAdapter("Select * from DOCGIA", XLDocGia.cnnStr);
            try
            {
                daDocGia.Fill(tblDocGia);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daDocGia);

            txtMaDG.DataBindings.Add("text", tblDocGia, "MaDG", true);
            txtTenDG.DataBindings.Add("text", tblDocGia, "TenDG", true);
            txtDiaChi.DataBindings.Add("text", tblDocGia, "DiaChi", true);
            txtSDT.DataBindings.Add("text", tblDocGia, "SDT", true);
            dtNgaySinh.DataBindings.Add("text", tblDocGia, "NgaySinh", true);
            rdNam.DataBindings.Add("checked", tblDocGia, "GioiTinh", true);
            pDocGia.DataBindings.Add("Image", tblDocGia, "Hinh", true);
            DSDG = this.BindingContext[tblDocGia];
            enabledButton();
            dgvTTDocGia.AutoGenerateColumns = false;
            dgvTTDocGia.DataSource = tblDocGia;
        }

        private void enabledButton()
        {
            btnThem.Enabled = !capNhat;
            btnXoa.Enabled = !capNhat;
            btnSua.Enabled = !capNhat;
            gTTDocGia.Enabled = capNhat;
            gTimKiem.Enabled = !capNhat;
            btnLuu.Enabled = capNhat;
            btnHuy.Enabled = capNhat;
            btnChonHinh.Enabled = capNhat;
            dgvTTDocGia.Enabled = !capNhat;
        }

        private void dgvTTDocGia_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvTTDocGia.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pDocGia.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSDG.AddNew();
            capNhat = true;
            enabledButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSDG.CancelCurrentEdit();
            tblDocGia.RejectChanges();
            capNhat = false;
            enabledButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSDG.RemoveAt(DSDG.Position);
                daDocGia.Update(tblDocGia);
                tblDocGia.AcceptChanges();
                MessageBox.Show("Xoá thành công!");
            }
            catch
            {
                tblDocGia.RejectChanges();
                MessageBox.Show("Xoá thất bại!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capNhat = true;
            txtMaDG.Enabled = false;
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
                string std = string.Format("MaDG like '%{0}%'", txtTimKiem.Text);
                tblDocGia.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("TenDG like '%{0}%'", txtTimKiem.Text);
                tblDocGia.DefaultView.RowFilter = std;
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dgvTTDocGia.RowCount == 1)
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSDG.EndCurrentEdit();
                daDocGia.Update(tblDocGia);
                tblDocGia.AcceptChanges();
                MessageBox.Show("Cập nhật thành công!");
                capNhat = false;
                enabledButton();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại!");
                txtMaDG.Focus();
            }
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            rdNu.Checked = !rdNam.Checked;
        }

        private void btnInDSDG_Click(object sender, EventArgs e)
        {
            frmDSDG f = new frmDSDG();
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
