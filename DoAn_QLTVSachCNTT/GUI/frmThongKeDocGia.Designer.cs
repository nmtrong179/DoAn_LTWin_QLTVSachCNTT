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
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.gTKDocGia = new System.Windows.Forms.GroupBox();
            this.txtSLDG = new System.Windows.Forms.TextBox();
            this.txtSLDGQH = new System.Windows.Forms.TextBox();
            this.txtSLDGDM = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ChDG = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gTKDocGia.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChDG)).BeginInit();
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
            this.gTKDocGia.Size = new System.Drawing.Size(475, 171);
            this.gTKDocGia.TabIndex = 15;
            this.gTKDocGia.TabStop = false;
            this.gTKDocGia.Text = "Thống Kê Độc Giả";
            // 
            // txtSLDG
            // 
            this.txtSLDG.Location = new System.Drawing.Point(274, 27);
            this.txtSLDG.Name = "txtSLDG";
            this.txtSLDG.Size = new System.Drawing.Size(152, 24);
            this.txtSLDG.TabIndex = 14;
            // 
            // txtSLDGQH
            // 
            this.txtSLDGQH.Location = new System.Drawing.Point(274, 124);
            this.txtSLDGQH.Name = "txtSLDGQH";
            this.txtSLDGQH.Size = new System.Drawing.Size(152, 24);
            this.txtSLDGQH.TabIndex = 13;
            // 
            // txtSLDGDM
            // 
            this.txtSLDGDM.Location = new System.Drawing.Point(274, 73);
            this.txtSLDGDM.Name = "txtSLDGDM";
            this.txtSLDGDM.Size = new System.Drawing.Size(152, 24);
            this.txtSLDGDM.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(198, 18);
            this.label9.TabIndex = 8;
            this.label9.Text = "Số Lượng Độc Giả Quá Hạn:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(200, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Số Lượng Độc Giả Đã Mượn:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Số Lượng Độc Giả:";
            // 
            // ChDG
            // 
            chartArea1.Name = "ChartArea1";
            this.ChDG.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.ChDG.Legends.Add(legend1);
            this.ChDG.Location = new System.Drawing.Point(15, 189);
            this.ChDG.Name = "ChDG";
            this.ChDG.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.LabelForeColor = System.Drawing.Color.Red;
            series1.Legend = "Legend1";
            series1.Name = "Số Lượng Độc Giả";
            this.ChDG.Series.Add(series1);
            this.ChDG.Size = new System.Drawing.Size(475, 339);
            this.ChDG.TabIndex = 18;
            this.ChDG.Text = "Thống Kê Độc Giả";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.ForeColor = System.Drawing.Color.Red;
            title1.Name = "ChDG";
            title1.Text = "Biểu Đồ Thống Kê Độc Giả";
            this.ChDG.Titles.Add(title1);
            // 
            // frmThongKeDocGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 540);
            this.Controls.Add(this.ChDG);
            this.Controls.Add(this.gTKDocGia);
            this.Name = "frmThongKeDocGia";
            this.Text = "Thống Kê Độc Giả";
            this.Load += new System.EventHandler(this.frmThongKeDocGia_Load);
            this.gTKDocGia.ResumeLayout(false);
            this.gTKDocGia.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChDG)).EndInit();
            this.ResumeLayout(false);

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
    }
}