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
    public partial class frmSach : Form
    {
        XLSach tblSach;
        XLNhaCungCap tblNCC;
        bool capNhat = false;
        BindingManagerBase DSSach;
        SqlDataAdapter daSach, daNCC;
        public frmSach()
        {
            InitializeComponent();
        }

        private void frmSach_Load(object sender, EventArgs e)
        {

            tblSach = new XLSach();
            tblNCC = new XLNhaCungCap();
            loadCTSach();
            loadNCC();
            rdTheoMa.Checked = true;
            daSach = new SqlDataAdapter("Select * from SACH", XLSach.cnnStr);
            daNCC = new SqlDataAdapter("Select * from NHACUNGCAP", XLNhaCungCap.cnnStr);
            try
            {
                daSach.Fill(tblSach);
                daNCC.Fill(tblNCC);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
            var cmb = new SqlCommandBuilder(daSach);

            txtMaSach.DataBindings.Add("text", tblSach, "MaSach", true);
            txtNXB.DataBindings.Add("text", tblSach, "NXB", true);
            txtTacGia.DataBindings.Add("text", tblSach, "TacGia", true);
            txtTenSach.DataBindings.Add("text", tblSach, "TenSach", true);
            txtTheLoai.DataBindings.Add("text", tblSach, "TheLoai", true);
            nudSLTon.DataBindings.Add("value", tblSach, "SLTon", true);
            pSach.DataBindings.Add("Image", tblSach, "Hinh", true);
            cbNCC.DataBindings.Add("SelectedValue", tblSach,"MaNCC", true);
            DSSach = this.BindingContext[tblSach];
            enabledButton();
            dgvTTSach.AutoGenerateColumns = false;
            dgvTTSach.DataSource = tblSach;
        }

        private void enabledButton()
        {
            btnThem.Enabled = !capNhat;
            btnXoa.Enabled = !capNhat;
            btnSua.Enabled = !capNhat;
            gTTSach.Enabled = capNhat;
            gTimKiem.Enabled = !capNhat;
            btnLuu.Enabled = capNhat;
            btnHuy.Enabled = capNhat;
            btnChonHinh.Enabled = capNhat;
            dgvTTSach.Enabled = !capNhat;
        }

        private void loadNCC()
        {
            cbNCC.DataSource = tblNCC;
            cbNCC.ValueMember = "MaNCC";
            cbNCC.DisplayMember = "TenNCC";
        }

        private void loadCTSach()
        {
            DataSet ds = new DataSet();
            ds.Tables.AddRange(new DataTable[] { tblNCC, tblSach });
            DataRelation qh = new DataRelation("FRK_NHACUNGCAP_SACH", tblNCC.Columns["MaNCC"], tblSach.Columns["MaNCC"]);
            ds.Relations.Add(qh);
            DataColumn cTenNCC = new DataColumn("TenNCC", Type.GetType("System.String"), "Parent (FRK_NHACUNGCAP_SACH).TenNCC");
            tblSach.Columns.Add(cTenNCC);
        }

        private void dgvTTSach_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow r in dgvTTSach.Rows)
                r.Cells[0].Value = r.Index + 1;
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "JPG Files|*.jpg|PNG Files|*.png|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pSach.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DSSach.AddNew();
            capNhat = true;
            enabledButton();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DSSach.CancelCurrentEdit();
            tblSach.RejectChanges();
            capNhat = false;
            enabledButton();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                DSSach.RemoveAt(DSSach.Position);
                daSach.Update(tblSach);
                tblSach.AcceptChanges();
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
            txtMaSach.Enabled = false;
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            if (rdTheoMa.Checked == true)
            {
                string std = string.Format("MaSach like '%{0}%'", txtTimKiem.Text);
                tblSach.DefaultView.RowFilter = std;
            }
            else 
            {
                string std = string.Format("TenSach like '%{0}%'", txtTimKiem.Text);
                tblSach.DefaultView.RowFilter = std;
            }
        }

        private void txtTimKiem_MouseClick(object sender, MouseEventArgs e)
        {
            txtTimKiem.Text = "";
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (dgvTTSach.RowCount == 1)
            {
                MessageBox.Show("Không có thông tin dữ liệu cần tìm!!!");
            }
        }

        private void btnInDSSach_Click(object sender, EventArgs e)
        {
            frmDSSach f = new frmDSSach();
            f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                DSSach.EndCurrentEdit();
                daSach.Update(tblSach);
                tblSach.AcceptChanges();
                MessageBox.Show("Cập nhật thành công!");
                capNhat = false;
                enabledButton();
            }
            catch
            {
                MessageBox.Show("Cập nhật thất bại!");
                txtMaSach.Focus();
            }
        }
    }
}
