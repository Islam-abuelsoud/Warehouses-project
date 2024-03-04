
namespace Design
{
    partial class Report_Suppliers_View
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
            this.crystalReportViewerSuppliers = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerSuppliers
            // 
            this.crystalReportViewerSuppliers.ActiveViewIndex = -1;
            this.crystalReportViewerSuppliers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerSuppliers.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerSuppliers.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerSuppliers.Name = "crystalReportViewerSuppliers";
            this.crystalReportViewerSuppliers.Size = new System.Drawing.Size(973, 527);
            this.crystalReportViewerSuppliers.TabIndex = 0;
            this.crystalReportViewerSuppliers.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Report_Suppliers_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 527);
            this.Controls.Add(this.crystalReportViewerSuppliers);
            this.Name = "Report_Suppliers_View";
            this.Text = "Report_Suppliers_View";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerSuppliers;
    }
}