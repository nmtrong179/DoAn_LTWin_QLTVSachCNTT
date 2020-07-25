namespace DoAn_QLTVSachCNTT
{
    partial class frmNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNCC));
            this.gTTNCC = new System.Windows.Forms.GroupBox();
            this.gThaoTac = new System.Windows.Forms.GroupBox();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtTenNCC = new System.Windows.Forms.TextBox();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdTheoTen = new System.Windows.Forms.RadioButton();
            this.rdTheoMa = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvTTNCC = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTTNCC.SuspendLayout();
            this.gThaoTac.SuspendLayout();
            this.gTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNCC)).BeginInit();
            this.SuspendLayout();
            // 
            // gTTNCC
            // 
            this.gTTNCC.Controls.Add(this.txtSDT);
            this.gTTNCC.Controls.Add(this.txtDiaChi);
            this.gTTNCC.Controls.Add(this.txtTenNCC);
            this.gTTNCC.Controls.Add(this.txtMaNCC);
            this.gTTNCC.Controls.Add(this.label4);
            this.gTTNCC.Controls.Add(this.label3);
            this.gTTNCC.Controls.Add(this.label2);
            this.gTTNCC.Controls.Add(this.label1);
            this.gTTNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTTNCC.Location = new System.Drawing.Point(12, 12);
            this.gTTNCC.Name = "gTTNCC";
            this.gTTNCC.Size = new System.Drawing.Size(670, 238);
            this.gTTNCC.TabIndex = 0;
            this.gTTNCC.TabStop = false;
            this.gTTNCC.Text = "Thông Tin Nhà Cung Cấp";
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
            this.gThaoTac.Location = new System.Drawing.Point(688, 38);
            this.gThaoTac.Name = "gThaoTac";
            this.gThaoTac.Size = new System.Drawing.Size(227, 212);
            this.gThaoTac.TabIndex = 11;
            this.gThaoTac.TabStop = false;
            this.gThaoTac.Text = "Thao Tác";
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(119, 153);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(102, 51);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(6, 153);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(102, 51);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(119, 87);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(102, 51);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(6, 87);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(102, 51);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(119, 23);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(102, 51);
            this.btnLuu.TabIndex = 1;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnThem
            // 
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(6, 23);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(102, 51);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(173, 144);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(142, 24);
            this.txtSDT.TabIndex = 7;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(458, 47);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(205, 74);
            this.txtDiaChi.TabIndex = 6;
            // 
            // txtTenNCC
            // 
            this.txtTenNCC.Location = new System.Drawing.Point(173, 99);
            this.txtTenNCC.Name = "txtTenNCC";
            this.txtTenNCC.Size = new System.Drawing.Size(194, 24);
            this.txtTenNCC.TabIndex = 5;
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(173, 47);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(100, 24);
            this.txtMaNCC.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "SĐT:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(382, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa Chỉ:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Nhà Cung Cấp:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Nhà Cung Cấp:";
            // 
            // gTimKiem
            // 
            this.gTimKiem.Controls.Add(this.btnTimKiem);
            this.gTimKiem.Controls.Add(this.txtTimKiem);
            this.gTimKiem.Controls.Add(this.rdTheoTen);
            this.gTimKiem.Controls.Add(this.rdTheoMa);
            this.gTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTimKiem.Location = new System.Drawing.Point(12, 256);
            this.gTimKiem.Name = "gTimKiem";
            this.gTimKiem.Size = new System.Drawing.Size(663, 84);
            this.gTimKiem.TabIndex = 10;
            this.gTimKiem.TabStop = false;
            this.gTimKiem.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(515, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 43);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(237, 34);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(250, 24);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Text = "Tìm Kiếm.....";
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rdTheoTen
            // 
            this.rdTheoTen.AutoSize = true;
            this.rdTheoTen.Location = new System.Drawing.Point(75, 51);
            this.rdTheoTen.Name = "rdTheoTen";
            this.rdTheoTen.Size = new System.Drawing.Size(96, 22);
            this.rdTheoTen.TabIndex = 1;
            this.rdTheoTen.TabStop = true;
            this.rdTheoTen.Text = "Theo Tên:";
            this.rdTheoTen.UseVisualStyleBackColor = true;
            // 
            // rdTheoMa
            // 
            this.rdTheoMa.AutoSize = true;
            this.rdTheoMa.Location = new System.Drawing.Point(75, 23);
            this.rdTheoMa.Name = "rdTheoMa";
            this.rdTheoMa.Size = new System.Drawing.Size(92, 22);
            this.rdTheoMa.TabIndex = 0;
            this.rdTheoMa.TabStop = true;
            this.rdTheoMa.Text = "Theo Mã:";
            this.rdTheoMa.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 343);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(284, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Danh Sách Thông Tin Nhà Cung Cấp";
            // 
            // dgvTTNCC
            // 
            this.dgvTTNCC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTTNCC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaNCC,
            this.TenNCC,
            this.DiaChi,
            this.SDT});
            this.dgvTTNCC.Location = new System.Drawing.Point(15, 364);
            this.dgvTTNCC.Name = "dgvTTNCC";
            this.dgvTTNCC.RowHeadersWidth = 51;
            this.dgvTTNCC.RowTemplate.Height = 24;
            this.dgvTTNCC.Size = new System.Drawing.Size(911, 223);
            this.dgvTTNCC.TabIndex = 13;
            this.dgvTTNCC.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvTTNCC_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 70;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã Nhà Cung Cấp";
            this.MaNCC.MinimumWidth = 6;
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.Width = 125;
            // 
            // TenNCC
            // 
            this.TenNCC.DataPropertyName = "TenNCC";
            this.TenNCC.HeaderText = "Tên Nhà Cung Cấp";
            this.TenNCC.MinimumWidth = 6;
            this.TenNCC.Name = "TenNCC";
            this.TenNCC.Width = 160;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChi";
            this.DiaChi.HeaderText = "Địa Chỉ";
            this.DiaChi.MinimumWidth = 6;
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 160;
            // 
            // SDT
            // 
            this.SDT.DataPropertyName = "SDT";
            this.SDT.HeaderText = "SĐT";
            this.SDT.MinimumWidth = 6;
            this.SDT.Name = "SDT";
            this.SDT.Width = 115;
            // 
            // frmNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 599);
            this.Controls.Add(this.gThaoTac);
            this.Controls.Add(this.dgvTTNCC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.gTimKiem);
            this.Controls.Add(this.gTTNCC);
            this.Name = "frmNCC";
            this.Text = "Quản Lý Nhà Cung Cấp";
            this.Load += new System.EventHandler(this.frmNCC_Load);
            this.gTTNCC.ResumeLayout(false);
            this.gTTNCC.PerformLayout();
            this.gThaoTac.ResumeLayout(false);
            this.gTimKiem.ResumeLayout(false);
            this.gTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTTNCC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gTTNCC;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtTenNCC;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.GroupBox gTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdTheoTen;
        private System.Windows.Forms.RadioButton rdTheoMa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvTTNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDT;
    }
}