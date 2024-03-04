
namespace Design
{
    partial class Report_Products_View
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
            this.crystalReportViewerProducts = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerProducts
            // 
            this.crystalReportViewerProducts.ActiveViewIndex = -1;
            this.crystalReportViewerProducts.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerProducts.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerProducts.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerProducts.Name = "crystalReportViewerProducts";
            this.crystalReportViewerProducts.Size = new System.Drawing.Size(951, 450);
            this.crystalReportViewerProducts.TabIndex = 0;
            this.crystalReportViewerProducts.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Report_Products_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.crystalReportViewerProducts);
            this.Name = "Report_Products_View";
            this.Text = "Report_Products_View";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerProducts;
    }
}