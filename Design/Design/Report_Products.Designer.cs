
namespace Design
{
    partial class Report_Products
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
            this.textSearch = new System.Windows.Forms.TextBox();
            this.printBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.getDataBtn = new System.Windows.Forms.Button();
            this.Grid1 = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).BeginInit();
            this.SuspendLayout();
            // 
            // textSearch
            // 
            this.textSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textSearch.Location = new System.Drawing.Point(133, 78);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(131, 31);
            this.textSearch.TabIndex = 75;
            // 
            // printBtn
            // 
            this.printBtn.Location = new System.Drawing.Point(827, 405);
            this.printBtn.Name = "printBtn";
            this.printBtn.Size = new System.Drawing.Size(97, 23);
            this.printBtn.TabIndex = 74;
            this.printBtn.Text = "print ";
            this.printBtn.UseVisualStyleBackColor = true;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Navy;
            this.label3.Location = new System.Drawing.Point(321, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 24);
            this.label3.TabIndex = 73;
            this.label3.Text = "Product Report ";
            // 
            // getDataBtn
            // 
            this.getDataBtn.Location = new System.Drawing.Point(624, 69);
            this.getDataBtn.Name = "getDataBtn";
            this.getDataBtn.Size = new System.Drawing.Size(75, 23);
            this.getDataBtn.TabIndex = 72;
            this.getDataBtn.Text = "All Products";
            this.getDataBtn.UseVisualStyleBackColor = true;
            this.getDataBtn.Click += new System.EventHandler(this.getDataBtn_Click);
            // 
            // Grid1
            // 
            this.Grid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid1.Location = new System.Drawing.Point(26, 118);
            this.Grid1.Name = "Grid1";
            this.Grid1.Size = new System.Drawing.Size(898, 268);
            this.Grid1.TabIndex = 71;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(26, 78);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 70;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // Report_Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 450);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.printBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.getDataBtn);
            this.Controls.Add(this.Grid1);
            this.Controls.Add(this.searchBtn);
            this.Name = "Report_Products";
            this.Text = "Report_Products";
            ((System.ComponentModel.ISupportInitialize)(this.Grid1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textSearch;
        private System.Windows.Forms.Button printBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button getDataBtn;
        private System.Windows.Forms.DataGridView Grid1;
        private System.Windows.Forms.Button searchBtn;
    }
}