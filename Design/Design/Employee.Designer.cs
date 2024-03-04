namespace Design
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.Resetbtn = new Guna.UI2.WinForms.Guna2Button();
            this.EmployeePhoneSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.EmployeeNameSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.Searchbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Deletebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.Savebtn = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
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
            this.Resetbtn.Location = new System.Drawing.Point(583, 124);
            this.Resetbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Resetbtn.Name = "Resetbtn";
            this.Resetbtn.Size = new System.Drawing.Size(97, 37);
            this.Resetbtn.TabIndex = 112;
            this.Resetbtn.Text = "Reset";
            this.Resetbtn.Click += new System.EventHandler(this.Resetbtn_Click_1);
            // 
            // EmployeePhoneSearch
            // 
            this.EmployeePhoneSearch.BorderRadius = 10;
            this.EmployeePhoneSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmployeePhoneSearch.DefaultText = "";
            this.EmployeePhoneSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmployeePhoneSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmployeePhoneSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeePhoneSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeePhoneSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeePhoneSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmployeePhoneSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeePhoneSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("EmployeePhoneSearch.IconLeft")));
            this.EmployeePhoneSearch.Location = new System.Drawing.Point(424, 131);
            this.EmployeePhoneSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EmployeePhoneSearch.Name = "EmployeePhoneSearch";
            this.EmployeePhoneSearch.PasswordChar = '\0';
            this.EmployeePhoneSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.EmployeePhoneSearch.PlaceholderText = "Enter employee phone";
            this.EmployeePhoneSearch.SelectedText = "";
            this.EmployeePhoneSearch.Size = new System.Drawing.Size(154, 29);
            this.EmployeePhoneSearch.TabIndex = 111;
            // 
            // EmployeeNameSearch
            // 
            this.EmployeeNameSearch.BorderRadius = 10;
            this.EmployeeNameSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmployeeNameSearch.DefaultText = "";
            this.EmployeeNameSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.EmployeeNameSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.EmployeeNameSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeNameSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.EmployeeNameSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeNameSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.EmployeeNameSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.EmployeeNameSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("EmployeeNameSearch.IconLeft")));
            this.EmployeeNameSearch.Location = new System.Drawing.Point(273, 131);
            this.EmployeeNameSearch.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.EmployeeNameSearch.Name = "EmployeeNameSearch";
            this.EmployeeNameSearch.PasswordChar = '\0';
            this.EmployeeNameSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.EmployeeNameSearch.PlaceholderText = "Enter employee name";
            this.EmployeeNameSearch.SelectedText = "";
            this.EmployeeNameSearch.Size = new System.Drawing.Size(146, 29);
            this.EmployeeNameSearch.TabIndex = 110;
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
            this.Searchbtn.Location = new System.Drawing.Point(172, 124);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(97, 37);
            this.Searchbtn.TabIndex = 109;
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
            this.Deletebtn.Location = new System.Drawing.Point(555, 488);
            this.Deletebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(124, 37);
            this.Deletebtn.TabIndex = 108;
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
            this.Updatebtn.Location = new System.Drawing.Point(365, 488);
            this.Updatebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Updatebtn.Name = "Updatebtn";
            this.Updatebtn.Size = new System.Drawing.Size(124, 37);
            this.Updatebtn.TabIndex = 107;
            this.Updatebtn.Text = "Update";
            this.Updatebtn.Click += new System.EventHandler(this.Updatebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BorderRadius = 7;
            this.Savebtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Savebtn.CustomBorderThickness = new System.Windows.Forms.Padding(20);
            this.Savebtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Savebtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Savebtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Savebtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Savebtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Savebtn.FocusedColor = System.Drawing.Color.GhostWhite;
            this.Savebtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.Color.White;
            this.Savebtn.Location = new System.Drawing.Point(172, 488);
            this.Savebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(124, 37);
            this.Savebtn.TabIndex = 106;
            this.Savebtn.Text = "Add";
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.GridColor = System.Drawing.Color.Gainsboro;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(172, 178);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.RowHeadersWidth = 51;
            this.dataGridViewEmployee.RowTemplate.Height = 26;
            this.dataGridViewEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(508, 269);
            this.dataGridViewEmployee.TabIndex = 105;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(350, 55);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(163, 41);
            this.guna2HtmlLabel1.TabIndex = 113;
            this.guna2HtmlLabel1.Text = "Employee";
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 567);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.Resetbtn);
            this.Controls.Add(this.EmployeePhoneSearch);
            this.Controls.Add(this.EmployeeNameSearch);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.Updatebtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.dataGridViewEmployee);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximumSize = new System.Drawing.Size(990, 567);
            this.MinimumSize = new System.Drawing.Size(990, 567);
            this.Name = "Employee";
            this.Text = "Employee";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button Resetbtn;
        private Guna.UI2.WinForms.Guna2TextBox EmployeePhoneSearch;
        private Guna.UI2.WinForms.Guna2TextBox EmployeeNameSearch;
        private Guna.UI2.WinForms.Guna2Button Searchbtn;
        private Guna.UI2.WinForms.Guna2Button Deletebtn;
        private Guna.UI2.WinForms.Guna2Button Updatebtn;
        private Guna.UI2.WinForms.Guna2Button Savebtn;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}