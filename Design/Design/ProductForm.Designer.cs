namespace Design
{
    partial class ProductForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.Deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Resetbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProductPriceSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductNameSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.Searchbtn = new Guna.UI2.WinForms.Guna2Button();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(216, 258);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 26;
            this.dataGridViewProducts.Size = new System.Drawing.Size(712, 298);
            this.dataGridViewProducts.TabIndex = 58;
            // 
            // Deletebtn
            // 
            this.Deletebtn.BorderRadius = 7;
            this.Deletebtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Deletebtn.CustomBorderThickness = new System.Windows.Forms.Padding(20);
            this.Deletebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Deletebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Deletebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Deletebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Deletebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Deletebtn.FocusedColor = System.Drawing.Color.GhostWhite;
            this.Deletebtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.ForeColor = System.Drawing.Color.White;
            this.Deletebtn.Location = new System.Drawing.Point(762, 591);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(166, 45);
            this.Deletebtn.TabIndex = 61;
            this.Deletebtn.Text = "Delete";
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Updatebtn
            // 
            this.Updatebtn.BorderRadius = 7;
            this.Updatebtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Updatebtn.CustomBorderThickness = new System.Windows.Forms.Padding(20);
            this.Updatebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Updatebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Updatebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Updatebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Updatebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Updatebtn.FocusedColor = System.Drawing.Color.GhostWhite;
            this.Updatebtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Updatebtn.ForeColor = System.Drawing.Color.White;
            this.Updatebtn.Location = new System.Drawing.Point(499, 591);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(166, 45);
            this.Updatebtn.TabIndex = 60;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Addbtn
            // 
            this.Addbtn.BorderRadius = 7;
            this.Addbtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Addbtn.CustomBorderThickness = new System.Windows.Forms.Padding(20);
            this.Addbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Addbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Addbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Addbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Addbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Addbtn.FocusedColor = System.Drawing.Color.GhostWhite;
            this.Addbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbtn.ForeColor = System.Drawing.Color.White;
            this.Addbtn.Location = new System.Drawing.Point(216, 591);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(166, 45);
            this.Addbtn.TabIndex = 59;
            this.Addbtn.Text = "Add";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Resetbtn
            // 
            this.Resetbtn.BorderRadius = 7;
            this.Resetbtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Resetbtn.CustomBorderThickness = new System.Windows.Forms.Padding(20);
            this.Resetbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Resetbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Resetbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Resetbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Resetbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Resetbtn.FocusedColor = System.Drawing.Color.GhostWhite;
            this.Resetbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resetbtn.ForeColor = System.Drawing.Color.White;
            this.Resetbtn.Location = new System.Drawing.Point(789, 184);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(129, 45);
            this.Resetbtn.TabIndex = 65;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // ProductPriceSearch
            // 
            this.ProductPriceSearch.BorderRadius = 10;
            this.ProductPriceSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductPriceSearch.DefaultText = "";
            this.ProductPriceSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductPriceSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductPriceSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductPriceSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductPriceSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductPriceSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductPriceSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductPriceSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("ProductPriceSearch.IconLeft")));
            this.ProductPriceSearch.Location = new System.Drawing.Point(575, 193);
            this.ProductPriceSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductPriceSearch.Name = "ProductPriceSearch";
            this.ProductPriceSearch.PasswordChar = '\0';
            this.ProductPriceSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.ProductPriceSearch.PlaceholderText = "Enter product price";
            this.ProductPriceSearch.SelectedText = "";
            this.ProductPriceSearch.Size = new System.Drawing.Size(177, 36);
            this.ProductPriceSearch.TabIndex = 64;
            // 
            // ProductNameSearch
            // 
            this.ProductNameSearch.BorderRadius = 10;
            this.ProductNameSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductNameSearch.DefaultText = "";
            this.ProductNameSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductNameSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductNameSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductNameSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductNameSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductNameSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductNameSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductNameSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("ProductNameSearch.IconLeft")));
            this.ProductNameSearch.Location = new System.Drawing.Point(359, 193);
            this.ProductNameSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductNameSearch.Name = "ProductNameSearch";
            this.ProductNameSearch.PasswordChar = '\0';
            this.ProductNameSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.ProductNameSearch.PlaceholderText = "Enter product name";
            this.ProductNameSearch.SelectedText = "";
            this.ProductNameSearch.Size = new System.Drawing.Size(177, 36);
            this.ProductNameSearch.TabIndex = 63;
            // 
            // Searchbtn
            // 
            this.Searchbtn.BorderRadius = 7;
            this.Searchbtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Searchbtn.CustomBorderThickness = new System.Windows.Forms.Padding(20);
            this.Searchbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Searchbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Searchbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Searchbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Searchbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Searchbtn.FocusedColor = System.Drawing.Color.GhostWhite;
            this.Searchbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.ForeColor = System.Drawing.Color.White;
            this.Searchbtn.Location = new System.Drawing.Point(216, 184);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(127, 45);
            this.Searchbtn.TabIndex = 62;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(472, 89);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(159, 53);
            this.guna2HtmlLabel1.TabIndex = 114;
            this.guna2HtmlLabel1.Text = "Product";
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 698);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.ProductPriceSearch);
            this.Controls.Add(this.ProductNameSearch);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.dataGridViewProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1320, 698);
            this.MinimumSize = new System.Drawing.Size(1320, 698);
            this.Name = "ProductForm";
            this.Text = "Products";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private Guna.UI2.WinForms.Guna2Button Deletebtn;
        private Guna.UI2.WinForms.Guna2Button Updatebtn;
        private Guna.UI2.WinForms.Guna2Button Addbtn;
        private Guna.UI2.WinForms.Guna2Button Resetbtn;
        private Guna.UI2.WinForms.Guna2TextBox ProductPriceSearch;
        private Guna.UI2.WinForms.Guna2TextBox ProductNameSearch;
        private Guna.UI2.WinForms.Guna2Button Searchbtn;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}