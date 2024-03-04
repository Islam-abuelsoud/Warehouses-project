
namespace Design
{
    partial class update_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(update_Customer));
            this.updateBtn = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.phonevaldiation = new System.Windows.Forms.Label();
            this.emailValdiation = new System.Windows.Forms.Label();
            this.Closebtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.passwordlbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Emaillbl = new System.Windows.Forms.Label();
            this.textPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.textEamil = new Guna.UI2.WinForms.Guna2TextBox();
            this.textAdress = new Guna.UI2.WinForms.Guna2TextBox();
            this.textName = new Guna.UI2.WinForms.Guna2TextBox();
            this.SuspendLayout();
            // 
            // updateBtn
            // 
            this.updateBtn.BackColor = System.Drawing.Color.White;
            this.updateBtn.BorderRadius = 10;
            this.updateBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.updateBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateBtn.ForeColor = System.Drawing.Color.White;
            this.updateBtn.Location = new System.Drawing.Point(118, 336);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(109, 45);
            this.updateBtn.TabIndex = 66;
            this.updateBtn.Text = "Save";
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(89, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 26);
            this.label5.TabIndex = 89;
            this.label5.Text = "Edit Customer";
            // 
            // phonevaldiation
            // 
            this.phonevaldiation.AutoSize = true;
            this.phonevaldiation.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonevaldiation.ForeColor = System.Drawing.Color.Red;
            this.phonevaldiation.Location = new System.Drawing.Point(115, 270);
            this.phonevaldiation.Name = "phonevaldiation";
            this.phonevaldiation.Size = new System.Drawing.Size(72, 16);
            this.phonevaldiation.TabIndex = 78;
            this.phonevaldiation.Text = " must be 11";
            this.phonevaldiation.Visible = false;
            // 
            // emailValdiation
            // 
            this.emailValdiation.AutoSize = true;
            this.emailValdiation.Font = new System.Drawing.Font("Microsoft YaHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValdiation.ForeColor = System.Drawing.Color.Red;
            this.emailValdiation.Location = new System.Drawing.Point(115, 219);
            this.emailValdiation.Name = "emailValdiation";
            this.emailValdiation.Size = new System.Drawing.Size(95, 16);
            this.emailValdiation.TabIndex = 77;
            this.emailValdiation.Text = "Must Contain @";
            this.emailValdiation.Visible = false;
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.ForeColor = System.Drawing.Color.White;
            this.Closebtn.Location = new System.Drawing.Point(296, 10);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(22, 20);
            this.Closebtn.TabIndex = 90;
            this.Closebtn.Text = "X";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(46, 241);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 19);
            this.label6.TabIndex = 98;
            this.label6.Text = "Phone";
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.passwordlbl.Location = new System.Drawing.Point(38, 292);
            this.passwordlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(74, 19);
            this.passwordlbl.TabIndex = 97;
            this.passwordlbl.Text = "Address";
            this.passwordlbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.passwordlbl.Click += new System.EventHandler(this.passwordlbl_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(46, 132);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 19);
            this.label7.TabIndex = 96;
            this.label7.Text = "Name";
            // 
            // Emaillbl
            // 
            this.Emaillbl.AutoSize = true;
            this.Emaillbl.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emaillbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Emaillbl.Location = new System.Drawing.Point(49, 186);
            this.Emaillbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Emaillbl.Name = "Emaillbl";
            this.Emaillbl.Size = new System.Drawing.Size(54, 19);
            this.Emaillbl.TabIndex = 95;
            this.Emaillbl.Text = "Email";
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
            this.textPhone.Location = new System.Drawing.Point(118, 237);
            this.textPhone.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textPhone.Name = "textPhone";
            this.textPhone.PasswordChar = '\0';
            this.textPhone.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.textPhone.PlaceholderText = "Enter phone";
            this.textPhone.SelectedText = "";
            this.textPhone.Size = new System.Drawing.Size(158, 29);
            this.textPhone.TabIndex = 107;
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
            this.textEamil.Location = new System.Drawing.Point(118, 186);
            this.textEamil.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textEamil.Name = "textEamil";
            this.textEamil.PasswordChar = '\0';
            this.textEamil.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.textEamil.PlaceholderText = "Enter email";
            this.textEamil.SelectedText = "";
            this.textEamil.Size = new System.Drawing.Size(158, 29);
            this.textEamil.TabIndex = 106;
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
            this.textAdress.Location = new System.Drawing.Point(118, 292);
            this.textAdress.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textAdress.Name = "textAdress";
            this.textAdress.PasswordChar = '\0';
            this.textAdress.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.textAdress.PlaceholderText = "Enter address";
            this.textAdress.SelectedText = "";
            this.textAdress.Size = new System.Drawing.Size(158, 29);
            this.textAdress.TabIndex = 105;
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
            this.textName.Location = new System.Drawing.Point(117, 132);
            this.textName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.textName.PlaceholderText = "Enter name";
            this.textName.SelectedText = "";
            this.textName.Size = new System.Drawing.Size(158, 29);
            this.textName.TabIndex = 104;
            // 
            // update_Customer
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
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.phonevaldiation);
            this.Controls.Add(this.emailValdiation);
            this.Controls.Add(this.updateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(333, 404);
            this.MinimumSize = new System.Drawing.Size(333, 404);
            this.Name = "update_Customer";
            this.Text = "update_Customer";
            this.Load += new System.EventHandler(this.update_Customer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button updateBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label phonevaldiation;
        private System.Windows.Forms.Label emailValdiation;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label passwordlbl;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label Emaillbl;
        private Guna.UI2.WinForms.Guna2TextBox textPhone;
        private Guna.UI2.WinForms.Guna2TextBox textEamil;
        private Guna.UI2.WinForms.Guna2TextBox textAdress;
        private Guna.UI2.WinForms.Guna2TextBox textName;
    }
}