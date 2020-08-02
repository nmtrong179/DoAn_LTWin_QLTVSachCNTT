namespace DoAn_QLTVSachCNTT
{
    partial class frmThongKeSach
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeSach));
            this.gTKSach = new System.Windows.Forms.GroupBox();
            this.txtSLConLai = new System.Windows.Forms.TextBox();
            this.txtSachQuaHan = new System.Windows.Forms.TextBox();
            this.txtSLSachMuon = new System.Windows.Forms.TextBox();
            this.txtSLSach = new System.Windows.Forms.TextBox();
            this.txtDauSach = new System.Windows.Forms.TextBox();
            this.txtTheLoai = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSSQH = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.chSach = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayQH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdTheoTenSach = new System.Windows.Forms.RadioButton();
            this.rdTheoMS = new System.Windows.Forms.RadioButton();
            this.gTKSach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSQH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSach)).BeginInit();
            this.gTimKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // gTKSach
            // 
            this.gTKSach.Controls.Add(this.txtSLConLai);
            this.gTKSach.Controls.Add(this.txtSachQuaHan);
            this.gTKSach.Controls.Add(this.txtSLSachMuon);
            this.gTKSach.Controls.Add(this.txtSLSach);
            this.gTKSach.Controls.Add(this.txtDauSach);
            this.gTKSach.Controls.Add(this.txtTheLoai);
            this.gTKSach.Controls.Add(this.label6);
            this.gTKSach.Controls.Add(this.label5);
            this.gTKSach.Controls.Add(this.label4);
            this.gTKSach.Controls.Add(this.label3);
            this.gTKSach.Controls.Add(this.label2);
            this.gTKSach.Controls.Add(this.label1);
            this.gTKSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTKSach.Location = new System.Drawing.Point(12, 12);
            this.gTKSach.Name = "gTKSach";
            this.gTKSach.Size = new System.Drawing.Size(679, 152);
            this.gTKSach.TabIndex = 0;
            this.gTKSach.TabStop = false;
            this.gTKSach.Text = "Thống Kê Sách";
            // 
            // txtSLConLai
            // 
            this.txtSLConLai.Location = new System.Drawing.Point(531, 73);
            this.txtSLConLai.Name = "txtSLConLai";
            this.txtSLConLai.Size = new System.Drawing.Size(120, 24);
            this.txtSLConLai.TabIndex = 11;
            // 
            // txtSachQuaHan
            // 
            this.txtSachQuaHan.Location = new System.Drawing.Point(531, 115);
            this.txtSachQuaHan.Name = "txtSachQuaHan";
            this.txtSachQuaHan.Size = new System.Drawing.Size(120, 24);
            this.txtSachQuaHan.TabIndex = 10;
            // 
            // txtSLSachMuon
            // 
            this.txtSLSachMuon.Location = new System.Drawing.Point(531, 30);
            this.txtSLSachMuon.Name = "txtSLSachMuon";
            this.txtSLSachMuon.Size = new System.Drawing.Size(120, 24);
            this.txtSLSachMuon.TabIndex = 9;
            // 
            // txtSLSach
            // 
            this.txtSLSach.Location = new System.Drawing.Point(182, 112);
            this.txtSLSach.Name = "txtSLSach";
            this.txtSLSach.Size = new System.Drawing.Size(118, 24);
            this.txtSLSach.TabIndex = 8;
            // 
            // txtDauSach
            // 
            this.txtDauSach.Location = new System.Drawing.Point(182, 27);
            this.txtDauSach.Name = "txtDauSach";
            this.txtDauSach.Size = new System.Drawing.Size(118, 24);
            this.txtDauSach.TabIndex = 7;
            // 
            // txtTheLoai
            // 
            this.txtTheLoai.Location = new System.Drawing.Point(182, 70);
            this.txtTheLoai.Name = "txtTheLoai";
            this.txtTheLoai.Size = new System.Drawing.Size(118, 24);
            this.txtTheLoai.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(351, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số Lượng Quá Hạn:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(351, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Số Lượng Còn Lại:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Lượng Đã Mượn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Số Lượng Sách:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Số Lượng Thể Loại:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Số Lượng Đầu Sách:";
            // 
            // dgvDSSQH
            // 
            this.dgvDSSQH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSQH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPM,
            this.MaDG,
            this.MaSach,
            this.TenSach,
            this.SoLuong,
            this.SoNgayQH});
            this.dgvDSSQH.Location = new System.Drawing.Point(12, 309);
            this.dgvDSSQH.Name = "dgvDSSQH";
            this.dgvDSSQH.RowHeadersWidth = 51;
            this.dgvDSSQH.RowTemplate.Height = 24;
            this.dgvDSSQH.Size = new System.Drawing.Size(679, 180);
            this.dgvDSSQH.TabIndex = 2;
            this.dgvDSSQH.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSSQH_DataBindingComplete);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(9, 288);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(214, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Danh Sách Sách Quá Hạn: ";
            // 
            // chSach
            // 
            chartArea2.Name = "ChartArea1";
            this.chSach.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chSach.Legends.Add(legend2);
            this.chSach.Location = new System.Drawing.Point(697, 12);
            this.chSach.Name = "chSach";
            this.chSach.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Số Lượng Sách";
            this.chSach.Series.Add(series2);
            this.chSach.Size = new System.Drawing.Size(570, 477);
            this.chSach.TabIndex = 19;
            this.chSach.Text = "Thống Kê Sách";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Red;
            title2.Name = "chSach";
            title2.Text = "Biểu Đồ Thống Kê Sách";
            this.chSach.Titles.Add(title2);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.Width = 60;
            // 
            // MaPM
            // 
            this.MaPM.DataPropertyName = "MaPM";
            this.MaPM.HeaderText = "Mã Phiếu Mượn";
            this.MaPM.MinimumWidth = 6;
            this.MaPM.Name = "MaPM";
            this.MaPM.Width = 70;
            // 
            // MaDG
            // 
            this.MaDG.DataPropertyName = "MaDG";
            this.MaDG.HeaderText = "Mã Độc Giả";
            this.MaDG.MinimumWidth = 6;
            this.MaDG.Name = "MaDG";
            this.MaDG.Width = 70;
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.MinimumWidth = 6;
            this.MaSach.Name = "MaSach";
            this.MaSach.Width = 70;
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.MinimumWidth = 6;
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 60;
            // 
            // SoNgayQH
            // 
            this.SoNgayQH.DataPropertyName = "SoNgayQH";
            this.SoNgayQH.HeaderText = "Số Ngày Quá Hạn";
            this.SoNgayQH.MinimumWidth = 6;
            this.SoNgayQH.Name = "SoNgayQH";
            this.SoNgayQH.Width = 60;
            // 
            // gTimKiem
            // 
            this.gTimKiem.Controls.Add(this.btnTimKiem);
            this.gTimKiem.Controls.Add(this.txtTimKiem);
            this.gTimKiem.Controls.Add(this.rdTheoTenSach);
            this.gTimKiem.Controls.Add(this.rdTheoMS);
            this.gTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTimKiem.Location = new System.Drawing.Point(12, 170);
            this.gTimKiem.Name = "gTimKiem";
            this.gTimKiem.Size = new System.Drawing.Size(679, 84);
            this.gTimKiem.TabIndex = 20;
            this.gTimKiem.TabStop = false;
            this.gTimKiem.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(536, 30);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(115, 43);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm Kiếm";
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(193, 39);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(314, 24);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Text = "Tìm Kiếm.....";
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rdTheoTenSach
            // 
            this.rdTheoTenSach.AutoSize = true;
            this.rdTheoTenSach.Location = new System.Drawing.Point(30, 51);
            this.rdTheoTenSach.Name = "rdTheoTenSach";
            this.rdTheoTenSach.Size = new System.Drawing.Size(134, 22);
            this.rdTheoTenSach.TabIndex = 1;
            this.rdTheoTenSach.TabStop = true;
            this.rdTheoTenSach.Text = "Theo Tên Sách:";
            this.rdTheoTenSach.UseVisualStyleBackColor = true;
            // 
            // rdTheoMS
            // 
            this.rdTheoMS.AutoSize = true;
            this.rdTheoMS.Location = new System.Drawing.Point(30, 23);
            this.rdTheoMS.Name = "rdTheoMS";
            this.rdTheoMS.Size = new System.Drawing.Size(130, 22);
            this.rdTheoMS.TabIndex = 0;
            this.rdTheoMS.TabStop = true;
            this.rdTheoMS.Text = "Theo Mã Sách:";
            this.rdTheoMS.UseVisualStyleBackColor = true;
            // 
            // frmThongKeSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1279, 537);
            this.Controls.Add(this.gTimKiem);
            this.Controls.Add(this.chSach);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvDSSQH);
            this.Controls.Add(this.gTKSach);
            this.Name = "frmThongKeSach";
            this.Text = "Thống Kê Sách";
            this.Load += new System.EventHandler(this.frmThongKeSach_Load);
            this.gTKSach.ResumeLayout(false);
            this.gTKSach.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSQH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chSach)).EndInit();
            this.gTimKiem.ResumeLayout(false);
            this.gTimKiem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gTKSach;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSLConLai;
        private System.Windows.Forms.TextBox txtSachQuaHan;
        private System.Windows.Forms.TextBox txtSLSachMuon;
        private System.Windows.Forms.TextBox txtSLSach;
        private System.Windows.Forms.TextBox txtDauSach;
        private System.Windows.Forms.TextBox txtTheLoai;
        private System.Windows.Forms.DataGridView dgvDSSQH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataVisualization.Charting.Chart chSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayQH;
        private System.Windows.Forms.GroupBox gTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdTheoTenSach;
        private System.Windows.Forms.RadioButton rdTheoMS;
    }
}