namespace DoAn_QLTVSachCNTT
{
    partial class frmTaiKhoan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaiKhoan));
            this.gTTTK = new System.Windows.Forms.GroupBox();
            this.rdQL = new System.Windows.Forms.RadioButton();
            this.rdTT = new System.Windows.Forms.RadioButton();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtMatKhau = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gThaoTac = new System.Windows.Forms.GroupBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.dgvDSTK = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MatKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiTK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.gTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdTheoTenTK = new System.Windows.Forms.RadioButton();
            this.rdTheoID = new System.Windows.Forms.RadioButton();
            this.gTTTK.SuspendLayout();
            this.gThaoTac.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).BeginInit();
            this.gTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gTTTK
            // 
            this.gTTTK.Controls.Add(this.rdQL);
            this.gTTTK.Controls.Add(this.rdTT);
            this.gTTTK.Controls.Add(this.txtID);
            this.gTTTK.Controls.Add(this.txtTenTK);
            this.gTTTK.Controls.Add(this.txtMatKhau);
            this.gTTTK.Controls.Add(this.label4);
            this.gTTTK.Controls.Add(this.label3);
            this.gTTTK.Controls.Add(this.label2);
            this.gTTTK.Controls.Add(this.label1);
            this.gTTTK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTTTK.Location = new System.Drawing.Point(13, 13);
            this.gTTTK.Name = "gTTTK";
            this.gTTTK.Size = new System.Drawing.Size(380, 269);
            this.gTTTK.TabIndex = 0;
            this.gTTTK.TabStop = false;
            this.gTTTK.Text = "Thông Tin Tài Khoản";
            // 
            // rdQL
            // 
            this.rdQL.AutoSize = true;
            this.rdQL.Location = new System.Drawing.Point(260, 208);
            this.rdQL.Name = "rdQL";
            this.rdQL.Size = new System.Drawing.Size(84, 22);
            this.rdQL.TabIndex = 23;
            this.rdQL.TabStop = true;
            this.rdQL.Text = "Quản Lý";
            this.rdQL.UseVisualStyleBackColor = true;
            this.rdQL.CheckedChanged += new System.EventHandler(this.rdQL_CheckedChanged);
            // 
            // rdTT
            // 
            this.rdTT.AutoSize = true;
            this.rdTT.Location = new System.Drawing.Point(144, 208);
            this.rdTT.Name = "rdTT";
            this.rdTT.Size = new System.Drawing.Size(83, 22);
            this.rdTT.TabIndex = 22;
            this.rdTT.TabStop = true;
            this.rdTT.Text = "Thủ Thư";
            this.rdTT.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(144, 49);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(213, 24);
            this.txtID.TabIndex = 20;
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(144, 101);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(213, 24);
            this.txtTenTK.TabIndex = 19;
            // 
            // txtMatKhau
            // 
            this.txtMatKhau.Location = new System.Drawing.Point(144, 152);
            this.txtMatKhau.Name = "txtMatKhau";
            this.txtMatKhau.Size = new System.Drawing.Size(213, 24);
            this.txtMatKhau.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 18);
            this.label4.TabIndex = 15;
            this.label4.Text = "Loại Tài Khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 14;
            this.label3.Text = "Mật Khẩu:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 18);
            this.label2.TabIndex = 13;
            this.label2.Text = "Tên Tài Khoản:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "ID:";
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
            this.gThaoTac.Location = new System.Drawing.Point(399, 55);
            this.gThaoTac.Name = "gThaoTac";
            this.gThaoTac.Size = new System.Drawing.Size(227, 227);
            this.gThaoTac.TabIndex = 11;
            this.gThaoTac.TabStop = false;
            this.gThaoTac.Text = "Thao Tác";
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
            // dgvDSTK
            // 
            this.dgvDSTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSTK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.ID,
            this.TenTK,
            this.MatKhau,
            this.LoaiTK});
            this.dgvDSTK.Location = new System.Drawing.Point(9, 404);
            this.dgvDSTK.Name = "dgvDSTK";
            this.dgvDSTK.RowHeadersWidth = 51;
            this.dgvDSTK.RowTemplate.Height = 24;
            this.dgvDSTK.Size = new System.Drawing.Size(632, 150);
            this.dgvDSTK.TabIndex = 1;
            this.dgvDSTK.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSTK_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 60;
            // 
            // TenTK
            // 
            this.TenTK.DataPropertyName = "TenTK";
            this.TenTK.HeaderText = "Tên Tài Khoản";
            this.TenTK.MinimumWidth = 6;
            this.TenTK.Name = "TenTK";
            this.TenTK.Width = 90;
            // 
            // MatKhau
            // 
            this.MatKhau.DataPropertyName = "MatKhau";
            this.MatKhau.HeaderText = "Mật Khẩu";
            this.MatKhau.MinimumWidth = 6;
            this.MatKhau.Name = "MatKhau";
            this.MatKhau.Width = 90;
            // 
            // LoaiTK
            // 
            this.LoaiTK.DataPropertyName = "LoaiTK";
            this.LoaiTK.HeaderText = "Loại Tài Khoản";
            this.LoaiTK.MinimumWidth = 6;
            this.LoaiTK.Name = "LoaiTK";
            this.LoaiTK.Width = 90;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 375);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(176, 18);
            this.label6.TabIndex = 24;
            this.label6.Text = "Danh Sách Tài Khoản:";
            // 
            // gTimKiem
            // 
            this.gTimKiem.Controls.Add(this.btnTimKiem);
            this.gTimKiem.Controls.Add(this.txtTimKiem);
            this.gTimKiem.Controls.Add(this.rdTheoTenTK);
            this.gTimKiem.Controls.Add(this.rdTheoID);
            this.gTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTimKiem.Location = new System.Drawing.Point(13, 288);
            this.gTimKiem.Name = "gTimKiem";
            this.gTimKiem.Size = new System.Drawing.Size(613, 84);
            this.gTimKiem.TabIndex = 25;
            this.gTimKiem.TabStop = false;
            this.gTimKiem.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(458, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 43);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(177, 34);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 24);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Text = "Tìm Kiếm.....";
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rdTheoTenTK
            // 
            this.rdTheoTenTK.AutoSize = true;
            this.rdTheoTenTK.Location = new System.Drawing.Point(32, 53);
            this.rdTheoTenTK.Name = "rdTheoTenTK";
            this.rdTheoTenTK.Size = new System.Drawing.Size(119, 22);
            this.rdTheoTenTK.TabIndex = 1;
            this.rdTheoTenTK.TabStop = true;
            this.rdTheoTenTK.Text = "Theo Tên TK:";
            this.rdTheoTenTK.UseVisualStyleBackColor = true;
            // 
            // rdTheoID
            // 
            this.rdTheoID.AutoSize = true;
            this.rdTheoID.Location = new System.Drawing.Point(32, 25);
            this.rdTheoID.Name = "rdTheoID";
            this.rdTheoID.Size = new System.Drawing.Size(85, 22);
            this.rdTheoID.TabIndex = 0;
            this.rdTheoID.TabStop = true;
            this.rdTheoID.Text = "Theo ID:";
            this.rdTheoID.UseVisualStyleBackColor = true;
            // 
            // frmTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 565);
            this.Controls.Add(this.gTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDSTK);
            this.Controls.Add(this.gTTTK);
            this.Controls.Add(this.gThaoTac);
            this.Name = "frmTaiKhoan";
            this.Text = "Quản Lý Tài Khoản";
            this.Load += new System.EventHandler(this.frmTaiKhoan_Load);
            this.gTTTK.ResumeLayout(false);
            this.gTTTK.PerformLayout();
            this.gThaoTac.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSTK)).EndInit();
            this.gTimKiem.ResumeLayout(false);
            this.gTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gTTTK;
        private System.Windows.Forms.GroupBox gThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdQL;
        private System.Windows.Forms.RadioButton rdTT;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtMatKhau;
        private System.Windows.Forms.DataGridView dgvDSTK;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTK;
        private System.Windows.Forms.DataGridViewTextBoxColumn MatKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiTK;
        private System.Windows.Forms.GroupBox gTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdTheoTenTK;
        private System.Windows.Forms.RadioButton rdTheoID;
    }
}