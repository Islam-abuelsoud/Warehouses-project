namespace Design
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.usernamelbl = new System.Windows.Forms.Label();
            this.readyloginlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.passwordtxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.usernametxt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Loginbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Closebtn = new System.Windows.Forms.Button();
            this.passwordlbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernamelbl
            // 
            this.usernamelbl.AutoSize = true;
            this.usernamelbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelbl.Location = new System.Drawing.Point(394, 104);
            this.usernamelbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.usernamelbl.Name = "usernamelbl";
            this.usernamelbl.Size = new System.Drawing.Size(52, 17);
            this.usernamelbl.TabIndex = 40;
            this.usernamelbl.Text = "E-mail";
            // 
            // readyloginlbl
            // 
            this.readyloginlbl.AutoSize = true;
            this.readyloginlbl.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readyloginlbl.Location = new System.Drawing.Point(394, 46);
            this.readyloginlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.readyloginlbl.Name = "readyloginlbl";
            this.readyloginlbl.Size = new System.Drawing.Size(147, 23);
            this.readyloginlbl.TabIndex = 39;
            this.readyloginlbl.Text = "Ready to LogIn";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(379, 369);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // passwordtxt
            // 
            this.passwordtxt.BorderRadius = 10;
            this.passwordtxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passwordtxt.DefaultText = "";
            this.passwordtxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordtxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordtxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordtxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.passwordtxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordtxt.IconLeft = ((System.Drawing.Image)(resources.GetObject("passwordtxt.IconLeft")));
            this.passwordtxt.Location = new System.Drawing.Point(398, 211);
            this.passwordtxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '●';
            this.passwordtxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.passwordtxt.PlaceholderText = "Enter your password";
            this.passwordtxt.SelectedText = "";
            this.passwordtxt.Size = new System.Drawing.Size(214, 29);
            this.passwordtxt.TabIndex = 45;
            this.passwordtxt.UseSystemPasswordChar = true;
            // 
            // usernametxt
            // 
            this.usernametxt.BorderRadius = 10;
            this.usernametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usernametxt.DefaultText = "";
            this.usernametxt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernametxt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernametxt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametxt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernametxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernametxt.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.usernametxt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernametxt.IconLeft = ((System.Drawing.Image)(resources.GetObject("usernametxt.IconLeft")));
            this.usernametxt.Location = new System.Drawing.Point(398, 137);
            this.usernametxt.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.PasswordChar = '\0';
            this.usernametxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(200)))), ((int)(((byte)(217)))));
            this.usernametxt.PlaceholderText = "Enter your email";
            this.usernametxt.SelectedText = "";
            this.usernametxt.Size = new System.Drawing.Size(214, 29);
            this.usernametxt.TabIndex = 44;
            // 
            // Loginbtn
            // 
            this.Loginbtn.BorderRadius = 7;
            this.Loginbtn.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Loginbtn.CustomBorderThickness = new System.Windows.Forms.Padding(20);
            this.Loginbtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Loginbtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Loginbtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Loginbtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Loginbtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Loginbtn.FocusedColor = System.Drawing.Color.GhostWhite;
            this.Loginbtn.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbtn.ForeColor = System.Drawing.Color.White;
            this.Loginbtn.Location = new System.Drawing.Point(425, 268);
            this.Loginbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Loginbtn.Name = "Loginbtn";
            this.Loginbtn.Size = new System.Drawing.Size(124, 37);
            this.Loginbtn.TabIndex = 43;
            this.Loginbtn.Text = "Log in";
            this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
            // 
            // Closebtn
            // 
            this.Closebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Closebtn.FlatAppearance.BorderSize = 0;
            this.Closebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Closebtn.ForeColor = System.Drawing.Color.White;
            this.Closebtn.Location = new System.Drawing.Point(621, 10);
            this.Closebtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Closebtn.Name = "Closebtn";
            this.Closebtn.Size = new System.Drawing.Size(22, 20);
            this.Closebtn.TabIndex = 42;
            this.Closebtn.Text = "X";
            this.Closebtn.UseVisualStyleBackColor = false;
            this.Closebtn.Click += new System.EventHandler(this.Closebtn_Click);
            // 
            // passwordlbl
            // 
            this.passwordlbl.AutoSize = true;
            this.passwordlbl.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlbl.Location = new System.Drawing.Point(394, 183);
            this.passwordlbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passwordlbl.Name = "passwordlbl";
            this.passwordlbl.Size = new System.Drawing.Size(70, 17);
            this.passwordlbl.TabIndex = 41;
            this.passwordlbl.Text = "Password";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 366);
            this.Controls.Add(this.usernamelbl);
            this.Controls.Add(this.readyloginlbl);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.Loginbtn);
            this.Controls.Add(this.Closebtn);
            this.Controls.Add(this.passwordlbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernamelbl;
        private System.Windows.Forms.Label readyloginlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Guna.UI2.WinForms.Guna2TextBox passwordtxt;
        private Guna.UI2.WinForms.Guna2TextBox usernametxt;
        private Guna.UI2.WinForms.Guna2Button Loginbtn;
        private System.Windows.Forms.Button Closebtn;
        private System.Windows.Forms.Label passwordlbl;
    }
}