
namespace Warehouses
{
    partial class CustomarForm
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
            this.nameText = new System.Windows.Forms.Label();
            this.labelId = new System.Windows.Forms.Label();
            this.adressText = new System.Windows.Forms.Label();
            this.emailText = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.Label();
            this.idText = new System.Windows.Forms.TextBox();
            this.textAdress = new System.Windows.Forms.TextBox();
            this.textEamil = new System.Windows.Forms.TextBox();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.textName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.showbtn = new System.Windows.Forms.Button();
            this.labelAddCus = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.emailValdiation = new System.Windows.Forms.Label();
            this.phonevaldiation = new System.Windows.Forms.Label();
            this.idValdiation = new System.Windows.Forms.Label();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // nameText
            // 
            this.nameText.AutoSize = true;
            this.nameText.Location = new System.Drawing.Point(79, 107);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(35, 13);
            this.nameText.TabIndex = 0;
            this.nameText.Text = "Name";
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Location = new System.Drawing.Point(79, 58);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(16, 13);
            this.labelId.TabIndex = 1;
            this.labelId.Text = "Id";
            // 
            // adressText
            // 
            this.adressText.AutoSize = true;
            this.adressText.Location = new System.Drawing.Point(79, 278);
            this.adressText.Name = "adressText";
            this.adressText.Size = new System.Drawing.Size(39, 13);
            this.adressText.TabIndex = 2;
            this.adressText.Text = "Adress";
            // 
            // emailText
            // 
            this.emailText.AutoSize = true;
            this.emailText.Location = new System.Drawing.Point(79, 216);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(38, 13);
            this.emailText.TabIndex = 3;
            this.emailText.Text = "E- mail";
            // 
            // phoneText
            // 
            this.phoneText.AutoSize = true;
            this.phoneText.Location = new System.Drawing.Point(79, 166);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(41, 13);
            this.phoneText.TabIndex = 4;
            this.phoneText.Text = "Phone ";
            // 
            // idText
            // 
            this.idText.Location = new System.Drawing.Point(156, 58);
            this.idText.Name = "idText";
            this.idText.Size = new System.Drawing.Size(100, 20);
            this.idText.TabIndex = 5;
            // 
            // textAdress
            // 
            this.textAdress.Location = new System.Drawing.Point(156, 278);
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(100, 20);
            this.textAdress.TabIndex = 6;
            // 
            // textEamil
            // 
            this.textEamil.Location = new System.Drawing.Point(156, 216);
            this.textEamil.Name = "textEamil";
            this.textEamil.Size = new System.Drawing.Size(100, 20);
            this.textEamil.TabIndex = 7;
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(156, 166);
            this.textPhone.Name = "textPhone";
            this.textPhone.Size = new System.Drawing.Size(100, 20);
            this.textPhone.TabIndex = 8;
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(156, 107);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(100, 20);
            this.textName.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(703, 292);
            this.dataGridView1.TabIndex = 10;
            // 
            // showbtn
            // 
            this.showbtn.Location = new System.Drawing.Point(443, 372);
            this.showbtn.Name = "showbtn";
            this.showbtn.Size = new System.Drawing.Size(155, 23);
            this.showbtn.TabIndex = 11;
            this.showbtn.Text = "Show Customer\r\n";
            this.showbtn.UseVisualStyleBackColor = true;
            this.showbtn.Click += new System.EventHandler(this.showbtn_Click);
            // 
            // labelAddCus
            // 
            this.labelAddCus.Location = new System.Drawing.Point(82, 337);
            this.labelAddCus.Name = "labelAddCus";
            this.labelAddCus.Size = new System.Drawing.Size(160, 23);
            this.labelAddCus.TabIndex = 12;
            this.labelAddCus.Text = "Add Customer ";
            this.labelAddCus.UseVisualStyleBackColor = true;
            this.labelAddCus.Click += new System.EventHandler(this.labelAddCus_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(274, 337);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(115, 23);
            this.updateBtn.TabIndex = 13;
            this.updateBtn.Text = "Update Customer ";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(187, 372);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(148, 23);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete Customer";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // emailValdiation
            // 
            this.emailValdiation.AutoSize = true;
            this.emailValdiation.ForeColor = System.Drawing.Color.Red;
            this.emailValdiation.Location = new System.Drawing.Point(129, 239);
            this.emailValdiation.Name = "emailValdiation";
            this.emailValdiation.Size = new System.Drawing.Size(127, 13);
            this.emailValdiation.TabIndex = 15;
            this.emailValdiation.Text = "Eamil Must Be Contain @";
            this.emailValdiation.Visible = false;
            // 
            // phonevaldiation
            // 
            this.phonevaldiation.AutoSize = true;
            this.phonevaldiation.ForeColor = System.Drawing.Color.Red;
            this.phonevaldiation.Location = new System.Drawing.Point(157, 189);
            this.phonevaldiation.Name = "phonevaldiation";
            this.phonevaldiation.Size = new System.Drawing.Size(99, 13);
            this.phonevaldiation.TabIndex = 16;
            this.phonevaldiation.Text = "Number must be 12";
            this.phonevaldiation.Visible = false;
            // 
            // idValdiation
            // 
            this.idValdiation.AutoSize = true;
            this.idValdiation.ForeColor = System.Drawing.Color.Red;
            this.idValdiation.Location = new System.Drawing.Point(174, 81);
            this.idValdiation.Name = "idValdiation";
            this.idValdiation.Size = new System.Drawing.Size(68, 13);
            this.idValdiation.TabIndex = 17;
            this.idValdiation.Text = "Id is frequent";
            this.idValdiation.Visible = false;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(676, 371);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(92, 23);
            this.searchBtn.TabIndex = 18;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // textSearch
            // 
            this.textSearch.Location = new System.Drawing.Point(774, 374);
            this.textSearch.Name = "textSearch";
            this.textSearch.Size = new System.Drawing.Size(131, 20);
            this.textSearch.TabIndex = 19;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 407);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.idValdiation);
            this.Controls.Add(this.phonevaldiation);
            this.Controls.Add(this.emailValdiation);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.labelAddCus);
            this.Controls.Add(this.showbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.textPhone);
            this.Controls.Add(this.textEamil);
            this.Controls.Add(this.textAdress);
            this.Controls.Add(this.idText);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.emailText);
            this.Controls.Add(this.adressText);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.nameText);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameText;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label adressText;
        private System.Windows.Forms.Label emailText;
        private System.Windows.Forms.Label phoneText;
        private System.Windows.Forms.TextBox idText;
        private System.Windows.Forms.TextBox textAdress;
        private System.Windows.Forms.TextBox textEamil;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.TextBox textName;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button showbtn;
        private System.Windows.Forms.Button labelAddCus;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Label emailValdiation;
        private System.Windows.Forms.Label phonevaldiation;
        private System.Windows.Forms.Label idValdiation;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textSearch;
    }
}

