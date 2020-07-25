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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgvDSDGQH = new System.Windows.Forms.DataGridView();
            this.STT1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaDG1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.gTKDocGia = new System.Windows.Forms.GroupBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDGQH)).BeginInit();
            this.gTKDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSDGQH
            // 
            this.dgvDSDGQH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSDGQH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT1,
            this.MaDG1,
            this.SLSach});
            this.dgvDSDGQH.Location = new System.Drawing.Point(12, 213);
            this.dgvDSDGQH.Name = "dgvDSDGQH";
            this.dgvDSDGQH.RowHeadersWidth = 51;
            this.dgvDSDGQH.RowTemplate.Height = 24;
            this.dgvDSDGQH.Size = new System.Drawing.Size(369, 290);
            this.dgvDSDGQH.TabIndex = 17;
            // 
            // STT1
            // 
            this.STT1.HeaderText = "STT";
            this.STT1.MinimumWidth = 6;
            this.STT1.Name = "STT1";
            this.STT1.Width = 70;
            // 
            // MaDG1
            // 
            this.MaDG1.HeaderText = "Mã Độc Giả";
            this.MaDG1.MinimumWidth = 6;
            this.MaDG1.Name = "MaDG1";
            this.MaDG1.Width = 80;
            // 
            // SLSach
            // 
            this.SLSach.HeaderText = "SL Sách";
            this.SLSach.MinimumWidth = 6;
            this.SLSach.Name = "SLSach";
            this.SLSach.Width = 80;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(12, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(238, 18);
            this.label11.TabIndex = 16;
            this.label11.Text = "Danh Sách Độc Giả Quá Hạn: ";
            // 
            // gTKDocGia
            // 
            this.gTKDocGia.Controls.Add(this.textBox9);
            this.gTKDocGia.Controls.Add(this.textBox8);
            this.gTKDocGia.Controls.Add(this.textBox7);
            this.gTKDocGia.Controls.Add(this.label9);
            this.gTKDocGia.Controls.Add(this.label8);
            this.gTKDocGia.Controls.Add(this.label7);
            this.gTKDocGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gTKDocGia.Location = new System.Drawing.Point(15, 12);
            this.gTKDocGia.Name = "gTKDocGia";
            this.gTKDocGia.Size = new System.Drawing.Size(369, 152);
            this.gTKDocGia.TabIndex = 15;
            this.gTKDocGia.TabStop = false;
            this.gTKDocGia.Text = "Thống Kê Độc Giả";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(238, 27);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 24);
            this.textBox9.TabIndex = 14;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(238, 112);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 24);
            this.textBox8.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(238, 70);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 24);
            this.textBox7.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 115);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số Lượng Độc Giả Quá Hạn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số Lượng Độc Giả Đã Mượn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số Lượng Độc Giả:";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(398, 112);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(390, 390);
            this.chart1.TabIndex = 18;
            this.chart1.Text = "chart1";
            // 
            // frmThongKeDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 514);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dgvDSDGQH);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.gTKDocGia);
            this.Name = "frmThongKeDocGia";
            this.Text = "Thống Kê Độc Giả";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSDGQH)).EndInit();
            this.gTKDocGia.ResumeLayout(false);
            this.gTKDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSDGQH;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDG1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLSach;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gTKDocGia;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}