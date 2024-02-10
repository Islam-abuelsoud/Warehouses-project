
namespace Warehouses
{
    partial class SuppliersForm
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
            this.labelId = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.emailValdiation = new System.Windows.Forms.Label();
            this.phonevaldiation = new System.Windows.Forms.Label();
            this.idValdiation = new System.Windows.Forms.Label();
            this.idText = new Guna.UI2.WinForms.Guna2TextBox();
            this.adressText = new Guna.UI2.WinForms.Guna2TextBox();
            this.textEamil = new Guna.UI2.WinForms.Guna2TextBox();
            this.textPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.textName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelAddSup = new Guna.UI2.WinForms.Guna2Button();
            this.Deletesup = new Guna.UI2.WinForms.Guna2Button();
            this.UpdatesupBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(37, 41);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(26, 18);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "ID";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(419, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 292);
            this.dataGridView1.TabIndex = 10;
            // 
            // emailValdiation
            // 
            this.emailValdiation.AutoSize = true;
            this.emailValdiation.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailValdiation.ForeColor = System.Drawing.Color.Red;
            this.emailValdiation.Location = new System.Drawing.Point(290, 184);
            this.emailValdiation.Name = "emailValdiation";
            this.emailValdiation.Size = new System.Drawing.Size(129, 19);
            this.emailValdiation.TabIndex = 15;
            this.emailValdiation.Text = "Must Contain @";
            this.emailValdiation.Visible = false;
            // 
            // phonevaldiation
            // 
            this.phonevaldiation.AutoSize = true;
            this.phonevaldiation.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phonevaldiation.ForeColor = System.Drawing.Color.Red;
            this.phonevaldiation.Location = new System.Drawing.Point(290, 138);
            this.phonevaldiation.Name = "phonevaldiation";
            this.phonevaldiation.Size = new System.Drawing.Size(96, 19);
            this.phonevaldiation.TabIndex = 16;
            this.phonevaldiation.Text = " must be 12";
            this.phonevaldiation.Visible = false;
            // 
            // idValdiation
            // 
            this.idValdiation.AutoSize = true;
            this.idValdiation.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idValdiation.ForeColor = System.Drawing.Color.Red;
            this.idValdiation.Location = new System.Drawing.Point(281, 40);
            this.idValdiation.Name = "idValdiation";
            this.idValdiation.Size = new System.Drawing.Size(109, 19);
            this.idValdiation.TabIndex = 17;
            this.idValdiation.Text = "Id is frequent";
            this.idValdiation.Visible = false;
            // 
            // idText
            // 
            this.idText.BorderRadius = 10;
            this.idText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.idText.DefaultText = "";
            this.idText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.idText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.idText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.idText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.idText.Location = new System.Drawing.Point(82, 32);
            this.idText.Name = "idText";
            this.idText.PasswordChar = '\0';
            this.idText.PlaceholderText = "";
            this.idText.SelectedText = "";
            this.idText.Size = new System.Drawing.Size(200, 36);
            this.idText.TabIndex = 20;
            // 
            // adressText
            // 
            this.adressText.BorderRadius = 10;
            this.adressText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.adressText.DefaultText = "Adress";
            this.adressText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.adressText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.adressText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adressText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.adressText.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adressText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.adressText.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.adressText.Location = new System.Drawing.Point(84, 233);
            this.adressText.Name = "adressText";
            this.adressText.PasswordChar = '\0';
            this.adressText.PlaceholderText = "";
            this.adressText.SelectedText = "";
            this.adressText.Size = new System.Drawing.Size(200, 36);
            this.adressText.TabIndex = 21;
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
            this.textEamil.Location = new System.Drawing.Point(84, 177);
            this.textEamil.Name = "textEamil";
            this.textEamil.PasswordChar = '\0';
            this.textEamil.PlaceholderText = "";
            this.textEamil.SelectedText = "";
            this.textEamil.Size = new System.Drawing.Size(200, 36);
            this.textEamil.TabIndex = 22;
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
            this.textPhone.Location = new System.Drawing.Point(84, 132);
            this.textPhone.Name = "textPhone";
            this.textPhone.PasswordChar = '\0';
            this.textPhone.PlaceholderText = "";
            this.textPhone.SelectedText = "";
            this.textPhone.Size = new System.Drawing.Size(200, 36);
            this.textPhone.TabIndex = 23;
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
            this.textName.Location = new System.Drawing.Point(82, 83);
            this.textName.Name = "textName";
            this.textName.PasswordChar = '\0';
            this.textName.PlaceholderText = "";
            this.textName.SelectedText = "";
            this.textName.Size = new System.Drawing.Size(200, 36);
            this.textName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 25;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Phone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 28;
            this.label4.Text = "Adress";
            // 
            // labelAddSup
            // 
            this.labelAddSup.BorderRadius = 10;
            this.labelAddSup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.labelAddSup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.labelAddSup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.labelAddSup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.labelAddSup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAddSup.ForeColor = System.Drawing.Color.White;
            this.labelAddSup.Location = new System.Drawing.Point(12, 286);
            this.labelAddSup.Name = "labelAddSup";
            this.labelAddSup.Size = new System.Drawing.Size(85, 45);
            this.labelAddSup.TabIndex = 29;
            this.labelAddSup.Text = "Add";
            this.labelAddSup.Click += new System.EventHandler(this.labelAddSup_Click);
            // 
            // Deletesup
            // 
            this.Deletesup.BorderRadius = 10;
            this.Deletesup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Deletesup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Deletesup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Deletesup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Deletesup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletesup.ForeColor = System.Drawing.Color.White;
            this.Deletesup.Location = new System.Drawing.Point(246, 286);
            this.Deletesup.Name = "Deletesup";
            this.Deletesup.Size = new System.Drawing.Size(85, 45);
            this.Deletesup.TabIndex = 30;
            this.Deletesup.Text = "Delete";
            this.Deletesup.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // UpdatesupBtn
            // 
            this.UpdatesupBtn.BorderRadius = 10;
            this.UpdatesupBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdatesupBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdatesupBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdatesupBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdatesupBtn.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdatesupBtn.ForeColor = System.Drawing.Color.White;
            this.UpdatesupBtn.Location = new System.Drawing.Point(128, 286);
            this.UpdatesupBtn.Name = "UpdatesupBtn";
            this.UpdatesupBtn.Size = new System.Drawing.Size(85, 45);
            this.UpdatesupBtn.TabIndex = 31;
            this.UpdatesupBtn.Text = "Update";
            this.UpdatesupBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // SuppliersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 341);
            this.Controls.Add(this.UpdatesupBtn);
            this.Controls.Add(this.Deletesup);
            this.Controls.Add(this.labelAddSup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEamil);
            this.Controls.Add(this.adressText);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.idValdiation);
            this.Controls.Add(this.phonevaldiation);
            this.Controls.Add(this.emailValdiation);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.labelId);
            this.Location = new System.Drawing.Point(170, 80);
            this.Name = "SuppliersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelId;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label emailValdiation;
        private System.Windows.Forms.Label phonevaldiation;
        private System.Windows.Forms.Label idValdiation;
        private Guna.UI2.WinForms.Guna2TextBox idText;
        private Guna.UI2.WinForms.Guna2TextBox adressText;
        private Guna.UI2.WinForms.Guna2TextBox textEamil;
        private Guna.UI2.WinForms.Guna2TextBox textPhone;
        private Guna.UI2.WinForms.Guna2TextBox textName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button labelAddSup;
        private Guna.UI2.WinForms.Guna2Button Deletesup;
        private Guna.UI2.WinForms.Guna2Button UpdatesupBtn;
    }
}

