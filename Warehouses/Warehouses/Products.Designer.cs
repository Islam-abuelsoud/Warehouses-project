namespace Desktop_App
{
    partial class Products
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products));
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.Resetbtn = new Guna.UI2.WinForms.Guna2Button();
            this.ProductTypeSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductPriceSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ProductNameSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.Searchbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Addbtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(12, 96);
            this.dataGridViewProducts.MultiSelect = false;
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 51;
            this.dataGridViewProducts.RowTemplate.Height = 26;
            this.dataGridViewProducts.Size = new System.Drawing.Size(648, 425);
            this.dataGridViewProducts.TabIndex = 57;
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
            this.Resetbtn.Location = new System.Drawing.Point(1, 24);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(145, 45);
            this.Resetbtn.TabIndex = 56;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click);
            // 
            // ProductTypeSearch
            // 
            this.ProductTypeSearch.BorderRadius = 10;
            this.ProductTypeSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProductTypeSearch.DefaultText = "";
            this.ProductTypeSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProductTypeSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProductTypeSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductTypeSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProductTypeSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductTypeSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProductTypeSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProductTypeSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("ProductTypeSearch.IconLeft")));
            this.ProductTypeSearch.Location = new System.Drawing.Point(726, 24);
            this.ProductTypeSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductTypeSearch.Name = "ProductTypeSearch";
            this.ProductTypeSearch.PasswordChar = '\0';
            this.ProductTypeSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.ProductTypeSearch.PlaceholderText = "Enter product type";
            this.ProductTypeSearch.SelectedText = "";
            this.ProductTypeSearch.Size = new System.Drawing.Size(184, 36);
            this.ProductTypeSearch.TabIndex = 55;
            this.ProductTypeSearch.TextChanged += new System.EventHandler(this.ProductTypeSearch_TextChanged);
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
            this.ProductPriceSearch.Location = new System.Drawing.Point(522, 24);
            this.ProductPriceSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductPriceSearch.Name = "ProductPriceSearch";
            this.ProductPriceSearch.PasswordChar = '\0';
            this.ProductPriceSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.ProductPriceSearch.PlaceholderText = "Enter product price";
            this.ProductPriceSearch.SelectedText = "";
            this.ProductPriceSearch.Size = new System.Drawing.Size(184, 36);
            this.ProductPriceSearch.TabIndex = 54;
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
            this.ProductNameSearch.Location = new System.Drawing.Point(313, 24);
            this.ProductNameSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProductNameSearch.Name = "ProductNameSearch";
            this.ProductNameSearch.PasswordChar = '\0';
            this.ProductNameSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.ProductNameSearch.PlaceholderText = "Enter product name";
            this.ProductNameSearch.SelectedText = "";
            this.ProductNameSearch.Size = new System.Drawing.Size(184, 36);
            this.ProductNameSearch.TabIndex = 53;
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
            this.Searchbtn.Location = new System.Drawing.Point(147, 24);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(145, 45);
            this.Searchbtn.TabIndex = 52;
            this.Searchbtn.Text = "Search";
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
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
            this.Deletebtn.Location = new System.Drawing.Point(745, 379);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(145, 45);
            this.Deletebtn.TabIndex = 51;
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
            this.Updatebtn.Location = new System.Drawing.Point(745, 309);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(145, 45);
            this.Updatebtn.TabIndex = 50;
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
            this.Addbtn.Location = new System.Drawing.Point(745, 229);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(145, 45);
            this.Addbtn.TabIndex = 49;
            this.Addbtn.Text = "Add";
            this.Addbtn.Click += new System.EventHandler(this.Addbtn_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 533);
            this.Controls.Add(this.dataGridViewProducts);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.ProductTypeSearch);
            this.Controls.Add(this.ProductPriceSearch);
            this.Controls.Add(this.ProductNameSearch);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Addbtn);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private Guna.UI2.WinForms.Guna2Button Resetbtn;
        private Guna.UI2.WinForms.Guna2TextBox ProductTypeSearch;
        private Guna.UI2.WinForms.Guna2TextBox ProductPriceSearch;
        private Guna.UI2.WinForms.Guna2TextBox ProductNameSearch;
        private Guna.UI2.WinForms.Guna2Button Searchbtn;
        private Guna.UI2.WinForms.Guna2Button Deletebtn;
        private Guna.UI2.WinForms.Guna2Button Updatebtn;
        private Guna.UI2.WinForms.Guna2Button Addbtn;
    }
}