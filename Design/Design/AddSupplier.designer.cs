
namespace Design
{
    partial class AddSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSupplier));
            this.labelAddCus = new Guna.UI2.WinForms.Guna2Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.emailValdiation = new System.Windows.Forms.Label();
            this.phonevaldiation = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textName = new Guna.UI2.WinForms.Guna2TextBox();
            this.textAdress = new Guna.UI2.WinForms.Guna2TextBox();
            this.textEamil = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // labelAddCus
            // 
            this.labelAddCus.BackColor = System.Drawing.Color.White;
            this.labelAddCus.BorderRadius = 10;
            this.labelAddCus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.labelAddCus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.labelAddCus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.labelAddCus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.labelAddCus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelAddCus.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddCus.ForeColor = System.Drawing.Color.White;
            this.labelAddCus.Location = new System.Drawing.Point(112, 349);
            this.labelAddCus.Name = "labelAddCus";
            this.labelAddCus.Size = new System.Drawing.Size(109, 45);
            this.labelAddCus.TabIndex = 74;
            this.labelAddCus.Text = "Save";
            this.labelAddCus.Click += new System.EventHandler(this.labelAddCus_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.ForeColor = System.Drawing.Color.White;
            this.Closebtn.Location = new System.Drawing.Point(296, 18);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(22, 20);
            this.Closebtn.TabIndex = 113;
            this.Closebtn.Text = "X";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(94, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 26);
            this.label9.TabIndex = 112;
            this.label9.Text = "Add Supplier";
            // 
            // emailValdiation
            // 
            this.emailValdiation.AutoSize = true;
            this.emailValdiation.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValdiation.ForeColor = System.Drawing.Color.Red;
            this.emailValdiation.Location = new System.Drawing.Point(116, 209);
            this.emailValdiation.Name = "emailValdiation";
            this.emailValdiation.Size = new System.Drawing.Size(95, 16);
            this.emailValdiation.TabIndex = 124;
            this.emailValdiation.Text = "Must Contain @";
            this.emailValdiation.Visible = false;
            // 
            // phonevaldiation
            // 
            this.phonevaldiation.AutoSize = true;
            this.phonevaldiation.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonevaldiation.ForeColor = System.Drawing.Color.Red;
            this.phonevaldiation.Location = new System.Drawing.Point(116, 271);
            this.phonevaldiation.Name = "phonevaldiation";
            this.phonevaldiation.Size = new System.Drawing.Size(72, 16);
            this.phonevaldiation.TabIndex = 125;
            this.phonevaldiation.Text = " must be 11";
            this.phonevaldiation.Visible = false;
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Emaillbl.Location = new System.Drawing.Point(40, 176);
            this.Emaillbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(54, 19);
            this.Emaillbl.TabIndex = 126;
            this.Emaillbl.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(40, 120);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 127;
            this.label7.Text = "Name";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordlbl.Location = new System.Drawing.Point(33, 295);
            this.passwordlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(74, 19);
            this.passwordlbl.TabIndex = 128;
            this.passwordlbl.Text = "Address";
            this.passwordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(40, 238);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 129;
            this.label6.Text = "Phone";
            // 
            // textName
            // 
            this.textName.BorderRadius = 10;
            this.textName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textName.DefaultText = "";
            this.textName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textName.IconLeft = ((System.Drawing.Image)(resources.GetObject("textName.IconLeft")));
            this.textName.Location = new System.Drawing.Point(112, 120);
            this.textName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.textName.PlaceholderText = "Enter name";
            this.textName.SelectedText = "";
            this.textName.Size = new System.Drawing.Size(158, 29);
            this.textName.TabIndex = 130;
            // 
            // textAdress
            // 
            this.textAdress.BorderRadius = 10;
            this.textAdress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textAdress.DefaultText = "";
            this.textAdress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textAdress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textAdress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textAdress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textAdress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textAdress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textAdress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textAdress.IconLeft = ((System.Drawing.Image)(resources.GetObject("textAdress.IconLeft")));
            this.textAdress.Location = new System.Drawing.Point(112, 295);
            this.textAdress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textAdress.Name = "textAdress";
            this.textAdress.PasswordChar = '\0';
            this.textAdress.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.textAdress.PlaceholderText = "Enter address";
            this.textAdress.SelectedText = "";
            this.textAdress.Size = new System.Drawing.Size(158, 29);
            this.textAdress.TabIndex = 131;
            // 
            // textEamil
            // 
            this.textEamil.BorderRadius = 10;
            this.textEamil.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textEamil.DefaultText = "";
            this.textEamil.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textEamil.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textEamil.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEamil.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textEamil.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEamil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textEamil.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textEamil.IconLeft = ((System.Drawing.Image)(resources.GetObject("textEamil.IconLeft")));
            this.textEamil.Location = new System.Drawing.Point(112, 176);
            this.textEamil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textEamil.Name = "textEamil";
            this.textEamil.PasswordChar = '\0';
            this.textEamil.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.textEamil.PlaceholderText = "Enter email";
            this.textEamil.SelectedText = "";
            this.textEamil.Size = new System.Drawing.Size(158, 29);
            this.textEamil.TabIndex = 132;
            // 
            // textPhone
            // 
            this.textPhone.BorderRadius = 10;
            this.textPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPhone.DefaultText = "";
            this.textPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPhone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textPhone.IconLeft = ((System.Drawing.Image)(resources.GetObject("textPhone.IconLeft")));
            this.textPhone.Location = new System.Drawing.Point(112, 238);
            this.textPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textPhone.Name = "textPhone";
            this.textPhone.PasswordChar = '\0';
            this.textPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.textPhone.PlaceholderText = "Enter phone";
            this.textPhone.SelectedText = "";
            this.textPhone.Size = new System.Drawing.Size(158, 29);
            this.textPhone.TabIndex = 133;
            // 
            // AddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 404);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEamil);
            this.Controls.Add(this.textAdress);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.passwordlbl);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Emaillbl);
            this.Controls.Add(this.phonevaldiation);
            this.Controls.Add(this.emailValdiation);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.labelAddCus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(333, 404);
            this.MinimumSize = new System.Drawing.Size(333, 404);
            this.Name = "AddSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_Customer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button labelAddCus;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label emailValdiation;
        private System.Windows.Forms.Label phonevaldiation;
        private System.Windows.Forms.Label Emaillbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox textName;
        private Guna.UI2.WinForms.Guna2TextBox textAdress;
        private Guna.UI2.WinForms.Guna2TextBox textEamil;
        private Guna.UI2.WinForms.Guna2TextBox textPhone;
    }
}