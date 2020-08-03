namespace DoAn_QLTVSachCNTT
{
    partial class frmMuonTra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMuonTra));
            this.gTTPM = new System.Windows.Forms.GroupBox();
            this.rdChuaTra = new System.Windows.Forms.RadioButton();
            this.rdDaTra = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtTra = new System.Windows.Forms.DateTimePicker();
            this.dtMuon = new System.Windows.Forms.DateTimePicker();
            this.cbMaDG = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gThaoTac = new System.Windows.Forms.GroupBox();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnTraSach = new DevExpress.XtraEditors.SimpleButton();
            this.btnGiaHan = new DevExpress.XtraEditors.SimpleButton();
            this.btnLapPhieu = new DevExpress.XtraEditors.SimpleButton();
            this.btnThoat = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnLuu = new DevExpress.XtraEditors.SimpleButton();
            this.gTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdTheoMaPM = new System.Windows.Forms.RadioButton();
            this.rdTheoMaDG = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvDSPM = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayMuon = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayTra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaPM = new System.Windows.Forms.TextBox();
            this.gTTPM.SuspendLayout();
            this.gThaoTac.SuspendLayout();
            this.gTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPM)).BeginInit();
            this.SuspendLayout();
            // 
            // gTTPM
            // 
            this.gTTPM.Controls.Add(this.txtMaPM);
            this.gTTPM.Controls.Add(this.rdChuaTra);
            this.gTTPM.Controls.Add(this.rdDaTra);
            this.gTTPM.Controls.Add(this.label9);
            this.gTTPM.Controls.Add(this.cbMaNV);
            this.gTTPM.Controls.Add(this.label8);
            this.gTTPM.Controls.Add(this.dtTra);
            this.gTTPM.Controls.Add(this.dtMuon);
            this.gTTPM.Controls.Add(this.cbMaDG);
            this.gTTPM.Controls.Add(this.label6);
            this.gTTPM.Controls.Add(this.label5);
            this.gTTPM.Controls.Add(this.label2);
            this.gTTPM.Controls.Add(this.label1);
            this.gTTPM.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTTPM.Location = new System.Drawing.Point(12, 12);
            this.gTTPM.Name = "gTTPM";
            this.gTTPM.Size = new System.Drawing.Size(561, 282);
            this.gTTPM.TabIndex = 0;
            this.gTTPM.TabStop = false;
            this.gTTPM.Text = "Thông Tin Phiếu Mượn";
            // 
            // rdChuaTra
            // 
            this.rdChuaTra.AutoSize = true;
            this.rdChuaTra.Location = new System.Drawing.Point(237, 228);
            this.rdChuaTra.Name = "rdChuaTra";
            this.rdChuaTra.Size = new System.Drawing.Size(90, 22);
            this.rdChuaTra.TabIndex = 16;
            this.rdChuaTra.TabStop = true;
            this.rdChuaTra.Text = "Chưa Trả";
            this.rdChuaTra.UseVisualStyleBackColor = true;
            // 
            // rdDaTra
            // 
            this.rdDaTra.AutoSize = true;
            this.rdDaTra.Location = new System.Drawing.Point(140, 230);
            this.rdDaTra.Name = "rdDaTra";
            this.rdDaTra.Size = new System.Drawing.Size(74, 22);
            this.rdDaTra.TabIndex = 15;
            this.rdDaTra.TabStop = true;
            this.rdDaTra.Text = "Đã Trả";
            this.rdDaTra.UseVisualStyleBackColor = true;
            this.rdDaTra.CheckedChanged += new System.EventHandler(this.rdDaTra_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 230);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Trạng thái:";
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(140, 134);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(175, 26);
            this.cbMaNV.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Mã Thủ Thư:";
            // 
            // dtTra
            // 
            this.dtTra.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTra.Location = new System.Drawing.Point(435, 181);
            this.dtTra.Name = "dtTra";
            this.dtTra.Size = new System.Drawing.Size(120, 24);
            this.dtTra.TabIndex = 11;
            // 
            // dtMuon
            // 
            this.dtMuon.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtMuon.Location = new System.Drawing.Point(140, 181);
            this.dtMuon.Name = "dtMuon";
            this.dtMuon.Size = new System.Drawing.Size(120, 24);
            this.dtMuon.TabIndex = 10;
            // 
            // cbMaDG
            // 
            this.cbMaDG.FormattingEnabled = true;
            this.cbMaDG.Location = new System.Drawing.Point(140, 88);
            this.cbMaDG.Name = "cbMaDG";
            this.cbMaDG.Size = new System.Drawing.Size(175, 26);
            this.cbMaDG.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(320, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày Trả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ngày Mượn:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Độc Giả:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Phiếu Mượn:";
            // 
            // gThaoTac
            // 
            this.gThaoTac.Controls.Add(this.btnSua);
            this.gThaoTac.Controls.Add(this.btnXoa);
            this.gThaoTac.Controls.Add(this.btnTraSach);
            this.gThaoTac.Controls.Add(this.btnGiaHan);
            this.gThaoTac.Controls.Add(this.btnLapPhieu);
            this.gThaoTac.Controls.Add(this.btnThoat);
            this.gThaoTac.Controls.Add(this.btnHuy);
            this.gThaoTac.Controls.Add(this.btnLuu);
            this.gThaoTac.Location = new System.Drawing.Point(579, 12);
            this.gThaoTac.Name = "gThaoTac";
            this.gThaoTac.Size = new System.Drawing.Size(323, 282);
            this.gThaoTac.TabIndex = 1;
            this.gThaoTac.TabStop = false;
            this.gThaoTac.Text = "Thao Tác:";
            // 
            // btnSua
            // 
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(15, 214);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(143, 51);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(164, 30);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(143, 51);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xoá";
            // 
            // btnTraSach
            // 
            this.btnTraSach.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTraSach.ImageOptions.Image")));
            this.btnTraSach.Location = new System.Drawing.Point(15, 153);
            this.btnTraSach.Name = "btnTraSach";
            this.btnTraSach.Size = new System.Drawing.Size(143, 51);
            this.btnTraSach.TabIndex = 10;
            this.btnTraSach.Text = "Trả Sách";
            this.btnTraSach.Click += new System.EventHandler(this.btnTraSach_Click);
            // 
            // btnGiaHan
            // 
            this.btnGiaHan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGiaHan.ImageOptions.Image")));
            this.btnGiaHan.Location = new System.Drawing.Point(15, 91);
            this.btnGiaHan.Name = "btnGiaHan";
            this.btnGiaHan.Size = new System.Drawing.Size(143, 51);
            this.btnGiaHan.TabIndex = 9;
            this.btnGiaHan.Text = "Gia Hạn";
            this.btnGiaHan.Click += new System.EventHandler(this.btnGiaHan_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLapPhieu.ImageOptions.Image")));
            this.btnLapPhieu.Location = new System.Drawing.Point(15, 30);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(143, 51);
            this.btnLapPhieu.TabIndex = 8;
            this.btnLapPhieu.Text = "Lập Phiếu";
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.ImageOptions.Image")));
            this.btnThoat.Location = new System.Drawing.Point(164, 214);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(143, 51);
            this.btnThoat.TabIndex = 7;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.ImageOptions.Image")));
            this.btnHuy.Location = new System.Drawing.Point(164, 153);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(143, 52);
            this.btnHuy.TabIndex = 5;
            this.btnHuy.Text = "Huỷ";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLuu.ImageOptions.Image")));
            this.btnLuu.Location = new System.Drawing.Point(164, 91);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(143, 51);
            this.btnLuu.TabIndex = 4;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gTimKiem
            // 
            this.gTimKiem.Controls.Add(this.btnTimKiem);
            this.gTimKiem.Controls.Add(this.txtTimKiem);
            this.gTimKiem.Controls.Add(this.rdTheoMaPM);
            this.gTimKiem.Controls.Add(this.rdTheoMaDG);
            this.gTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTimKiem.Location = new System.Drawing.Point(12, 309);
            this.gTimKiem.Name = "gTimKiem";
            this.gTimKiem.Size = new System.Drawing.Size(725, 84);
            this.gTimKiem.TabIndex = 2;
            this.gTimKiem.TabStop = false;
            this.gTimKiem.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(604, 25);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 43);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(282, 34);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(273, 24);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Text = "Tìm Kiếm.....";
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rdTheoMaPM
            // 
            this.rdTheoMaPM.AutoSize = true;
            this.rdTheoMaPM.Location = new System.Drawing.Point(75, 51);
            this.rdTheoMaPM.Name = "rdTheoMaPM";
            this.rdTheoMaPM.Size = new System.Drawing.Size(175, 22);
            this.rdTheoMaPM.TabIndex = 1;
            this.rdTheoMaPM.TabStop = true;
            this.rdTheoMaPM.Text = "Theo Mã Phiếu Mượn:";
            this.rdTheoMaPM.UseVisualStyleBackColor = true;
            // 
            // rdTheoMaDG
            // 
            this.rdTheoMaDG.AutoSize = true;
            this.rdTheoMaDG.Location = new System.Drawing.Point(75, 23);
            this.rdTheoMaDG.Name = "rdTheoMaDG";
            this.rdTheoMaDG.Size = new System.Drawing.Size(151, 22);
            this.rdTheoMaDG.TabIndex = 0;
            this.rdTheoMaDG.TabStop = true;
            this.rdTheoMaDG.Text = "Theo Mã Độc Giả:";
            this.rdTheoMaDG.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 405);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(157, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Danh Sách Phiếu Mượn";
            // 
            // dgvDSPM
            // 
            this.dgvDSPM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSPM.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPM,
            this.MaDG,
            this.NgayMuon,
            this.NgayTra,
            this.MaTT,
            this.TrangThai});
            this.dgvDSPM.Location = new System.Drawing.Point(12, 438);
            this.dgvDSPM.Name = "dgvDSPM";
            this.dgvDSPM.RowHeadersWidth = 51;
            this.dgvDSPM.RowTemplate.Height = 24;
            this.dgvDSPM.Size = new System.Drawing.Size(874, 183);
            this.dgvDSPM.TabIndex = 13;
            this.dgvDSPM.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSPM_DataBindingComplete);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 50;
            // 
            // MaPM
            // 
            this.MaPM.DataPropertyName = "MaPM";
            this.MaPM.HeaderText = "Mã PM";
            this.MaPM.MinimumWidth = 6;
            this.MaPM.Name = "MaPM";
            this.MaPM.Width = 80;
            // 
            // MaDG
            // 
            this.MaDG.DataPropertyName = "MaDG";
            this.MaDG.HeaderText = "Mã DG";
            this.MaDG.MinimumWidth = 6;
            this.MaDG.Name = "MaDG";
            this.MaDG.Width = 80;
            // 
            // NgayMuon
            // 
            this.NgayMuon.DataPropertyName = "NgayMuon";
            this.NgayMuon.HeaderText = "Ngày Mượn";
            this.NgayMuon.MinimumWidth = 6;
            this.NgayMuon.Name = "NgayMuon";
            this.NgayMuon.Width = 80;
            // 
            // NgayTra
            // 
            this.NgayTra.DataPropertyName = "NgayTra";
            this.NgayTra.HeaderText = "Ngày Trả";
            this.NgayTra.MinimumWidth = 6;
            this.NgayTra.Name = "NgayTra";
            this.NgayTra.Width = 80;
            // 
            // MaTT
            // 
            this.MaTT.DataPropertyName = "MaNV";
            this.MaTT.HeaderText = "Mã TT";
            this.MaTT.MinimumWidth = 6;
            this.MaTT.Name = "MaTT";
            this.MaTT.Width = 80;
            // 
            // TrangThai
            // 
            this.TrangThai.DataPropertyName = "TrangThai";
            this.TrangThai.HeaderText = "Trạng Thái";
            this.TrangThai.MinimumWidth = 6;
            this.TrangThai.Name = "TrangThai";
            this.TrangThai.Width = 70;
            // 
            // txtMaPM
            // 
            this.txtMaPM.Location = new System.Drawing.Point(140, 43);
            this.txtMaPM.Name = "txtMaPM";
            this.txtMaPM.Size = new System.Drawing.Size(175, 24);
            this.txtMaPM.TabIndex = 17;
            // 
            // frmMuonTra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 633);
            this.Controls.Add(this.dgvDSPM);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gTimKiem);
            this.Controls.Add(this.gThaoTac);
            this.Controls.Add(this.gTTPM);
            this.Name = "frmMuonTra";
            this.Text = "Quản Lý Mượn Trả";
            this.Load += new System.EventHandler(this.frmMuonTra_Load);
            this.gTTPM.ResumeLayout(false);
            this.gTTPM.PerformLayout();
            this.gThaoTac.ResumeLayout(false);
            this.gTimKiem.ResumeLayout(false);
            this.gTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSPM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gTTPM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gThaoTac;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnLuu;
        private DevExpress.XtraEditors.SimpleButton btnLapPhieu;
        private DevExpress.XtraEditors.SimpleButton btnThoat;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnTraSach;
        private DevExpress.XtraEditors.SimpleButton btnGiaHan;
        private System.Windows.Forms.DateTimePicker dtTra;
        private System.Windows.Forms.DateTimePicker dtMuon;
        private System.Windows.Forms.ComboBox cbMaDG;
        private System.Windows.Forms.GroupBox gTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdTheoMaPM;
        private System.Windows.Forms.RadioButton rdTheoMaDG;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvDSPM;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RadioButton rdDaTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayMuon;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayTra;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
        private System.Windows.Forms.RadioButton rdChuaTra;
        private System.Windows.Forms.ComboBox cbMaNV;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.TextBox txtMaPM;
    }
}