namespace DoAn_QLTVSachCNTT
{
    partial class frmDSDG
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
            this.rptvDSDG = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rptvDSDG
            // 
            this.rptvDSDG.ActiveViewIndex = -1;
            this.rptvDSDG.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rptvDSDG.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptvDSDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptvDSDG.Location = new System.Drawing.Point(0, 0);
            this.rptvDSDG.Name = "rptvDSDG";
            this.rptvDSDG.Size = new System.Drawing.Size(800, 450);
            this.rptvDSDG.TabIndex = 0;
            // 
            // frmDSDG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptvDSDG);
            this.Name = "frmDSDG";
            this.Text = "frmDSDG";
            this.Load += new System.EventHandler(this.frmDSDG_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rptvDSDG;
    }
}