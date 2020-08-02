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
    public partial class frmThuThu : Form
    {
        XLNhanVien tblNhanVien;
        bool capNhat = false;
        BindingManagerBase DSNV;
        SqlDataAdapter daNhanVien;
        public frmThuThu()
        {
            InitializeComponent();
        }

        private void frmThuThu_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            tblNhanVien = new XLNhanVien();
            rdTheoMa.Checked = true;
            daNhanVien = new SqlDataAdapter("Select * from NHANVIEN", XLNhanVien.cnnStr);
            try
            {
                daNhanVien.Fill(tblNhanVien);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daNhanVien);

            txtMaTT.DataBindings.Add("text", tblNhanVien, "MaNV", true);
            txtTenTT.DataBindings.Add("text", tblNhanVien, "HoTenNV", true);
            txtDiaChi.DataBindings.Add("text", tblNhanVien, "DiaChi", true);
            txtChucVu.DataBindings.Add("text", tblNhanVien, "ChucVu", true);
            txtID.DataBindings.Add("text", tblNhanVien, "ID", true);
            txtSDT.DataBindings.Add("text", tblNhanVien, "SDT", true);
            dtNgaySinh.DataBindings.Add("text", tblNhanVien, "NgaySinh", true);
            rdNam.DataBindings.Add("checked", tblNhanVien, "GioiTinh", true);
            pThuThu.DataBindings.Add("Image", tblNhanVien, "Hinh", true);
            DSNV = this.BindingContext[tblNhanVien];
            enabledButton();
            dgvTTThuThu.AutoGenerateColumns = false;
            dgvTTThuThu.DataSource = tblNhanVien;
        }

        private void enabledButton()
        {
            btnThem.Enabled = !capNhat;
            btnXoa.Enabled = !capNhat;
            btnSua.Enabled = !capNhat;
            gTTThuThu.Enabled = capNhat;
            gTimKiem.Enabled = !capNhat;
            btnLuu.Enabled = capNhat;
            btnHuy.Enabled = capNhat;
            btnChonHinh.Enabled = capNhat;
        }

        private void dgvTTThuThu_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvTTThuThu.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pThuThu.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSNV.AddNew();
            capNhat = true;
            enabledButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSNV.CancelCurrentEdit();
            tblNhanVien.RejectChanges();
            capNhat = false;
            enabledButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.RemoveAt(DSNV.Position);
                daNhanVien.Update(tblNhanVien);
                tblNhanVien.AcceptChanges();
                MessageBox.Show("Xoá thành công!");
            }
            catch
            {
                tblNhanVien.RejectChanges();
                MessageBox.Show("Xoá thất bại!!!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            capNhat = true;
            txtMaTT.Enabled = false;
            enabledButton();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdTheoMa.Checked == true)
            {
                string std = string.Format("MaNV like '%{0}%'", txtTimKiem.Text);
                tblNhanVien.DefaultView.RowFilter = std;
            }
            else
            {
                string std = string.Format("HoTenNV like '%{0}%'", txtTimKiem.Text);
                tblNhanVien.DefaultView.RowFilter = std;
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dgvTTThuThu.RowCount == 1)
            {
                MessageBox.Show("Không tìm thấy!");
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSNV.EndCurrentEdit();
                daNhanVien.Update(tblNhanVien);
                tblNhanVien.AcceptChanges();
                MessageBox.Show("Cập nhật thành công!");
                capNhat = false;
                enabledButton();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại");
                txtMaTT.Focus();
            }
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            rdNu.Checked = !rdNam.Checked;
        }

        private void btnInDSNV_Click(object sender, EventArgs e)
        {
            frmDSNV f = new frmDSNV();
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}
