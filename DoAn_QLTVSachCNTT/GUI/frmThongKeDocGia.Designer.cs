namespace DoAn_QLTVSachCNTT
{
    partial class frmThongKeDocGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKeDocGia));
            this.gTKDocGia = new System.Windows.Forms.GroupBox();
            this.txtSLDG = new System.Windows.Forms.TextBox();
            this.txtSLDGQH = new System.Windows.Forms.TextBox();
            this.txtSLDGDM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChDG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gTimKiem = new System.Windows.Forms.GroupBox();
            this.btnTimKiem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.rdTheoDG = new System.Windows.Forms.RadioButton();
            this.rdTheoMDG = new System.Windows.Forms.RadioButton();
            this.dgvDSDGQH = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaPM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoNgayQH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.gTKDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChDG)).BeginInit();
            this.gTimKiem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDGQH)).BeginInit();
            this.SuspendLayout();
            // 
            // gTKDocGia
            // 
            this.gTKDocGia.Controls.Add(this.txtSLDG);
            this.gTKDocGia.Controls.Add(this.txtSLDGQH);
            this.gTKDocGia.Controls.Add(this.txtSLDGDM);
            this.gTKDocGia.Controls.Add(this.label9);
            this.gTKDocGia.Controls.Add(this.label8);
            this.gTKDocGia.Controls.Add(this.label7);
            this.gTKDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTKDocGia.Location = new System.Drawing.Point(15, 12);
            this.gTKDocGia.Name = "gTKDocGia";
            this.gTKDocGia.Size = new System.Drawing.Size(603, 171);
            this.gTKDocGia.TabIndex = 15;
            this.gTKDocGia.TabStop = false;
            this.gTKDocGia.Text = "Thống Kê Độc Giả";
            // 
            // txtSLDG
            // 
            this.txtSLDG.Location = new System.Drawing.Point(303, 27);
            this.txtSLDG.Name = "txtSLDG";
            this.txtSLDG.Size = new System.Drawing.Size(244, 24);
            this.txtSLDG.TabIndex = 14;
            // 
            // txtSLDGQH
            // 
            this.txtSLDGQH.Location = new System.Drawing.Point(303, 124);
            this.txtSLDGQH.Name = "txtSLDGQH";
            this.txtSLDGQH.Size = new System.Drawing.Size(244, 24);
            this.txtSLDGQH.TabIndex = 13;
            // 
            // txtSLDGDM
            // 
            this.txtSLDGDM.Location = new System.Drawing.Point(303, 73);
            this.txtSLDGDM.Name = "txtSLDGDM";
            this.txtSLDGDM.Size = new System.Drawing.Size(244, 24);
            this.txtSLDGDM.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số Lượng Độc Giả Quá Hạn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(57, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số Lượng Độc Giả Đã Mượn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(57, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số Lượng Độc Giả:";
            // 
            // ChDG
            // 
            chartArea2.Name = "ChartArea1";
            this.ChDG.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ChDG.Legends.Add(legend2);
            this.ChDG.Location = new System.Drawing.Point(624, 12);
            this.ChDG.Name = "ChDG";
            this.ChDG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series2.LabelForeColor = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "Số Lượng Độc Giả";
            this.ChDG.Series.Add(series2);
            this.ChDG.Size = new System.Drawing.Size(475, 435);
            this.ChDG.TabIndex = 18;
            this.ChDG.Text = "Thống Kê Độc Giả";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.ForeColor = System.Drawing.Color.Red;
            title2.Name = "ChDG";
            title2.Text = "Biểu Đồ Thống Kê Độc Giả";
            this.ChDG.Titles.Add(title2);
            // 
            // gTimKiem
            // 
            this.gTimKiem.Controls.Add(this.btnTimKiem);
            this.gTimKiem.Controls.Add(this.txtTimKiem);
            this.gTimKiem.Controls.Add(this.rdTheoDG);
            this.gTimKiem.Controls.Add(this.rdTheoMDG);
            this.gTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTimKiem.Location = new System.Drawing.Point(15, 189);
            this.gTimKiem.Name = "gTimKiem";
            this.gTimKiem.Size = new System.Drawing.Size(603, 84);
            this.gTimKiem.TabIndex = 21;
            this.gTimKiem.TabStop = false;
            this.gTimKiem.Text = "Tìm Kiếm";
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnTimKiem.ImageOptions.Image")));
            this.btnTimKiem.Location = new System.Drawing.Point(473, 30);
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
            this.txtTimKiem.Size = new System.Drawing.Size(262, 24);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Text = "Tìm Kiếm.....";
            this.txtTimKiem.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtTimKiem_MouseClick);
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // rdTheoDG
            // 
            this.rdTheoDG.AutoSize = true;
            this.rdTheoDG.Location = new System.Drawing.Point(30, 51);
            this.rdTheoDG.Name = "rdTheoDG";
            this.rdTheoDG.Size = new System.Drawing.Size(123, 22);
            this.rdTheoDG.TabIndex = 1;
            this.rdTheoDG.TabStop = true;
            this.rdTheoDG.Text = "Theo Tên DG:";
            this.rdTheoDG.UseVisualStyleBackColor = true;
            // 
            // rdTheoMDG
            // 
            this.rdTheoMDG.AutoSize = true;
            this.rdTheoMDG.Location = new System.Drawing.Point(30, 23);
            this.rdTheoMDG.Name = "rdTheoMDG";
            this.rdTheoMDG.Size = new System.Drawing.Size(119, 22);
            this.rdTheoMDG.TabIndex = 0;
            this.rdTheoMDG.TabStop = true;
            this.rdTheoMDG.Text = "Theo Mã DG:";
            this.rdTheoMDG.UseVisualStyleBackColor = true;
            // 
            // dgvDSDGQH
            // 
            this.dgvDSDGQH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDGQH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaPM,
            this.MaDG,
            this.TenDG,
            this.SoLuong,
            this.SoNgayQH});
            this.dgvDSDGQH.Location = new System.Drawing.Point(15, 297);
            this.dgvDSDGQH.Name = "dgvDSDGQH";
            this.dgvDSDGQH.RowHeadersWidth = 51;
            this.dgvDSDGQH.RowTemplate.Height = 24;
            this.dgvDSDGQH.Size = new System.Drawing.Size(603, 150);
            this.dgvDSDGQH.TabIndex = 22;
            this.dgvDSDGQH.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dgvDSDGQH_DataBindingComplete);
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
            // TenDG
            // 
            this.TenDG.DataPropertyName = "TenDG";
            this.TenDG.HeaderText = "Tên Độc Giả";
            this.TenDG.MinimumWidth = 6;
            this.TenDG.Name = "TenDG";
            this.TenDG.Width = 125;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "TongSoLuong";
            this.SoLuong.HeaderText = "Số Lượng Sách";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 18);
            this.label1.TabIndex = 15;
            this.label1.Text = "Danh Sách Độc Giả Mượn Quá Hạn:";
            // 
            // frmThongKeDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 470);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDSDGQH);
            this.Controls.Add(this.gTimKiem);
            this.Controls.Add(this.ChDG);
            this.Controls.Add(this.gTKDocGia);
            this.Name = "frmThongKeDocGia";
            this.Text = "Thống Kê Độc Giả";
            this.Load += new System.EventHandler(this.frmThongKeDocGia_Load);
            this.gTKDocGia.ResumeLayout(false);
            this.gTKDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChDG)).EndInit();
            this.gTimKiem.ResumeLayout(false);
            this.gTimKiem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDGQH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gTKDocGia;
        private System.Windows.Forms.TextBox txtSLDG;
        private System.Windows.Forms.TextBox txtSLDGQH;
        private System.Windows.Forms.TextBox txtSLDGDM;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart ChDG;
        private System.Windows.Forms.GroupBox gTimKiem;
        private DevExpress.XtraEditors.SimpleButton btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.RadioButton rdTheoDG;
        private System.Windows.Forms.RadioButton rdTheoMDG;
        private System.Windows.Forms.DataGridView dgvDSDGQH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPM;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDG;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoNgayQH;
    }
}