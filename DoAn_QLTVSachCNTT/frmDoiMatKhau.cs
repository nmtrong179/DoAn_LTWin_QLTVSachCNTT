using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_QLTVSachCNTT
{
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void chbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (chbAll.Checked)
            {
                txtMKHT.UseSystemPasswordChar = false;
                txtMKM.UseSystemPasswordChar = false;
                txtNLMKM.UseSystemPasswordChar = false;
            }
            else
            {
                txtMKHT.UseSystemPasswordChar = true;
                txtMKM.UseSystemPasswordChar = true;
                txtNLMKM.UseSystemPasswordChar = true;
            }
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtMKHT.UseSystemPasswordChar = true;
            txtMKM.UseSystemPasswordChar = true;
            txtNLMKM.UseSystemPasswordChar = true;
        }
    }
}
