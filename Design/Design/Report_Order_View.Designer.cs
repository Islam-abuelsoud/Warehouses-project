
namespace Design
{
    partial class Report_Order_View
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
            this.crystalReportViewerOrder = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // crystalReportViewerOrder
            // 
            this.crystalReportViewerOrder.ActiveViewIndex = -1;
            this.crystalReportViewerOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewerOrder.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewerOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewerOrder.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewerOrder.Name = "crystalReportViewerOrder";
            this.crystalReportViewerOrder.Size = new System.Drawing.Size(959, 579);
            this.crystalReportViewerOrder.TabIndex = 0;
            this.crystalReportViewerOrder.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // Report_Order_View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(959, 579);
            this.Controls.Add(this.crystalReportViewerOrder);
            this.Name = "Report_Order_View";
            this.Text = "Report_Order_View";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewerOrder;
    }
}