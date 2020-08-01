namespace DoAn_QLTVSachCNTT
{
    partial class frmDSSach
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
            this.rptvDSSach = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvDSSach
            // 
            this.rptvDSSach.ActiveViewIndex = -1;
            this.rptvDSSach.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvDSSach.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvDSSach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvDSSach.Location = new System.Drawing.Point(0, 0);
            this.rptvDSSach.Name = "rptvDSSach";
            this.rptvDSSach.Size = new System.Drawing.Size(800, 450);
            this.rptvDSSach.TabIndex = 0;
            // 
            // frmDSSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptvDSSach);
            this.Name = "frmDSSach";
            this.Text = "frmDSSach";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSSach_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvDSSach;
    }
}