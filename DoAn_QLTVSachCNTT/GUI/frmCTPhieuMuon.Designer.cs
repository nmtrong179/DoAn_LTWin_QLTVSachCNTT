namespace DoAn_QLTVSachCNTT
{
    partial class frmCTPhieuMuon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCTPhieuMuon));
            this.label4 = new System.Windows.Forms.Label();
            this.dgvCTPM = new System.Windows.Forms.DataGridView();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdTheoMaSach = new System.Windows.Forms.RadioButton();
            this.rdTheoMaPM = new System.Windows.Forms.RadioButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.gTimKiem = new System.Windows.Forms.GroupBox();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.gThaoTac = new System.Windows.Forms.GroupBox();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.cbMaSach = new System.Windows.Forms.ComboBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gTTCTPhieuMuon = new System.Windows.Forms.GroupBox();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPM)).BeginInit();
            this.gTimKiem.SuspendLayout();
            this.gThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.gTTCTPhieuMuon.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Danh Sách Chi Tiết Phiếu Mượn:";
            // 
            // dgvCTPM
            // 
            this.dgvCTPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPM,
            this.MaSach,
            this.SoLuong});
            this.dgvCTPM.Location = new System.Drawing.Point(12, 357);
            this.dgvCTPM.Name = "dgvCTPM";
            this.dgvCTPM.RowHeadersWidth = 51;
            this.dgvCTPM.RowTemplate.Height = 24;
            this.dgvCTPM.Size = new System.Drawing.Size(626, 191);
            this.dgvCTPM.TabIndex = 18;
            this.dgvCTPM.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvCTPM_DataBindingComplete);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(230, 34);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 24);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Text = "Tìm Kiếm.....";
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rdTheoMaSach
            // 
            this.rdTheoMaSach.AutoSize = true;
            this.rdTheoMaSach.Location = new System.Drawing.Point(34, 51);
            this.rdTheoMaSach.Name = "rdTheoMaSach";
            this.rdTheoMaSach.Size = new System.Drawing.Size(130, 22);
            this.rdTheoMaSach.TabIndex = 1;
            this.rdTheoMaSach.TabStop = true;
            this.rdTheoMaSach.Text = "Theo Mã Sách:";
            this.rdTheoMaSach.UseVisualStyleBackColor = true;
            // 
            // rdTheoMaPM
            // 
            this.rdTheoMaPM.AutoSize = true;
            this.rdTheoMaPM.Location = new System.Drawing.Point(34, 23);
            this.rdTheoMaPM.Name = "rdTheoMaPM";
            this.rdTheoMaPM.Size = new System.Drawing.Size(175, 22);
            this.rdTheoMaPM.TabIndex = 0;
            this.rdTheoMaPM.TabStop = true;
            this.rdTheoMaPM.Text = "Theo Mã Phiếu Mượn:";
            this.rdTheoMaPM.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(119, 168);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 51);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(6, 168);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 51);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(119, 97);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 51);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(6, 97);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 51);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(505, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 43);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // gTimKiem
            // 
            this.gTimKiem.Controls.Add(this.btnTimKiem);
            this.gTimKiem.Controls.Add(this.txtTimKiem);
            this.gTimKiem.Controls.Add(this.rdTheoMaSach);
            this.gTimKiem.Controls.Add(this.rdTheoMaPM);
            this.gTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTimKiem.Location = new System.Drawing.Point(12, 245);
            this.gTimKiem.Name = "gTimKiem";
            this.gTimKiem.Size = new System.Drawing.Size(626, 84);
            this.gTimKiem.TabIndex = 17;
            this.gTimKiem.TabStop = false;
            this.gTimKiem.Text = "Tìm Kiếm";
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(119, 29);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 51);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gThaoTac
            // 
            this.gThaoTac.Controls.Add(this.btnThoat);
            this.gThaoTac.Controls.Add(this.btnSua);
            this.gThaoTac.Controls.Add(this.btnHuy);
            this.gThaoTac.Controls.Add(this.btnXoa);
            this.gThaoTac.Controls.Add(this.btnLuu);
            this.gThaoTac.Controls.Add(this.btnThem);
            this.gThaoTac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gThaoTac.Location = new System.Drawing.Point(411, 12);
            this.gThaoTac.Name = "gThaoTac";
            this.gThaoTac.Size = new System.Drawing.Size(227, 227);
            this.gThaoTac.TabIndex = 16;
            this.gThaoTac.TabStop = false;
            this.gThaoTac.Text = "Thao Tác";
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(6, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 51);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(179, 37);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(174, 24);
            this.txtMaPM.TabIndex = 6;
            // 
            // cbMaSach
            // 
            this.cbMaSach.FormattingEnabled = true;
            this.cbMaSach.Location = new System.Drawing.Point(179, 87);
            this.cbMaSach.Name = "cbMaSach";
            this.cbMaSach.Size = new System.Drawing.Size(174, 26);
            this.cbMaSach.TabIndex = 5;
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Location = new System.Drawing.Point(179, 139);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(174, 24);
            this.nudSoLuong.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Sách:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Mượn:";
            // 
            // gTTCTPhieuMuon
            // 
            this.gTTCTPhieuMuon.Controls.Add(this.txtMaPM);
            this.gTTCTPhieuMuon.Controls.Add(this.cbMaSach);
            this.gTTCTPhieuMuon.Controls.Add(this.nudSoLuong);
            this.gTTCTPhieuMuon.Controls.Add(this.label3);
            this.gTTCTPhieuMuon.Controls.Add(this.label2);
            this.gTTCTPhieuMuon.Controls.Add(this.label1);
            this.gTTCTPhieuMuon.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTTCTPhieuMuon.Location = new System.Drawing.Point(12, 12);
            this.gTTCTPhieuMuon.Name = "gTTCTPhieuMuon";
            this.gTTCTPhieuMuon.Size = new System.Drawing.Size(393, 197);
            this.gTTCTPhieuMuon.TabIndex = 15;
            this.gTTCTPhieuMuon.TabStop = false;
            this.gTTCTPhieuMuon.Text = "Thông Tin Chi Tiết Phiếu Mượn:";
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 80;
            // 
            // MaPM
            // 
            this.MaPM.DataPropertyName = "MaPM";
            this.MaPM.HeaderText = "Mã Phiếu Mượn";
            this.MaPM.MinimumWidth = 6;
            this.MaPM.Name = "MaPM";
            this.MaPM.Width = 120;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 110;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 90;
            // 
            // frmCTPhieuMuon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 559);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvCTPM);
            this.Controls.Add(this.gTimKiem);
            this.Controls.Add(this.gThaoTac);
            this.Controls.Add(this.gTTCTPhieuMuon);
            this.Name = "frmCTPhieuMuon";
            this.Text = "frmCTPhieuMuon";
            this.Load += new System.EventHandler(this.frmCTPhieuMuon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPM)).EndInit();
            this.gTimKiem.ResumeLayout(false);
            this.gTimKiem.PerformLayout();
            this.gThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.gTTCTPhieuMuon.ResumeLayout(false);
            this.gTTCTPhieuMuon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvCTPM;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdTheoMaSach;
        private System.Windows.Forms.RadioButton rdTheoMaPM;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.GroupBox gTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private System.Windows.Forms.GroupBox gThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.TextBox txtMaPM;
        private System.Windows.Forms.ComboBox cbMaSach;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gTTCTPhieuMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}