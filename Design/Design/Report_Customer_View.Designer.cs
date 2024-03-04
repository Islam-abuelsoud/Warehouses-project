
namespace Design
{
    partial class Report_Customer_View
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
            this.crystalReportViewerCustomer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerCustomer
            // 
            this.crystalReportViewerCustomer.ActiveViewIndex = -1;
            this.crystalReportViewerCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerCustomer.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerCustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerCustomer.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerCustomer.Name = "crystalReportViewerCustomer";
            this.crystalReportViewerCustomer.Size = new System.Drawing.Size(952, 552);
            this.crystalReportViewerCustomer.TabIndex = 0;
            this.crystalReportViewerCustomer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Report_Customer_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 552);
            this.Controls.Add(this.crystalReportViewerCustomer);
            this.Name = "Report_Customer_View";
            this.Text = "Report_Customer_View";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerCustomer;
    }
}