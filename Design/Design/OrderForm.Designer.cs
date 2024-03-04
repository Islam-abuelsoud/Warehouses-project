namespace Design
{
    partial class OrderForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.StateComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuppliersComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.CustoComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.Deletesup = new Guna.UI2.WinForms.Guna2Button();
            this.Addlabel = new Guna.UI2.WinForms.Guna2Button();
            this.label9 = new System.Windows.Forms.Label();
            this.ProdQuantityTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ProdpriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.prodNameComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveOrderButton = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.total = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(38, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(201, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "State";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(350, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 24);
            this.label3.TabIndex = 44;
            this.label3.Text = "Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(350, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 43;
            this.label2.Text = "Customer";
            // 
            // TypeComboBox
            // 
            this.TypeComboBox.BackColor = System.Drawing.Color.Transparent;
            this.TypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TypeComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TypeComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.TypeComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.TypeComboBox.ItemHeight = 30;
            this.TypeComboBox.Location = new System.Drawing.Point(10, 126);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(119, 36);
            this.TypeComboBox.TabIndex = 42;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // StateComboBox
            // 
            this.StateComboBox.BackColor = System.Drawing.Color.Transparent;
            this.StateComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.StateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StateComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StateComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.StateComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.StateComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.StateComboBox.ItemHeight = 30;
            this.StateComboBox.Location = new System.Drawing.Point(160, 126);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(119, 36);
            this.StateComboBox.TabIndex = 41;
            this.StateComboBox.SelectedIndexChanged += new System.EventHandler(this.StateComboBox_SelectedIndexChanged);
            // 
            // SuppliersComboBox
            // 
            this.SuppliersComboBox.BackColor = System.Drawing.Color.Transparent;
            this.SuppliersComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SuppliersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SuppliersComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SuppliersComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.SuppliersComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.SuppliersComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.SuppliersComboBox.ItemHeight = 30;
            this.SuppliersComboBox.Location = new System.Drawing.Point(322, 126);
            this.SuppliersComboBox.Name = "SuppliersComboBox";
            this.SuppliersComboBox.Size = new System.Drawing.Size(119, 36);
            this.SuppliersComboBox.TabIndex = 40;
            // 
            // CustoComboBox
            // 
            this.CustoComboBox.BackColor = System.Drawing.Color.Transparent;
            this.CustoComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CustoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CustoComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustoComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CustoComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CustoComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CustoComboBox.ItemHeight = 30;
            this.CustoComboBox.Location = new System.Drawing.Point(322, 126);
            this.CustoComboBox.Name = "CustoComboBox";
            this.CustoComboBox.Size = new System.Drawing.Size(119, 36);
            this.CustoComboBox.TabIndex = 39;
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(505, 94);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(286, 38);
            this.guna2DateTimePicker1.TabIndex = 38;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 2, 12, 23, 29, 42, 858);
            this.guna2DateTimePicker1.ValueChanged += new System.EventHandler(this.guna2DateTimePicker1_ValueChanged);
            // 
            // Deletesup
            // 
            this.Deletesup.BorderRadius = 10;
            this.Deletesup.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Deletesup.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Deletesup.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Deletesup.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Deletesup.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Deletesup.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletesup.ForeColor = System.Drawing.Color.White;
            this.Deletesup.Location = new System.Drawing.Point(681, 434);
            this.Deletesup.Name = "Deletesup";
            this.Deletesup.Size = new System.Drawing.Size(85, 45);
            this.Deletesup.TabIndex = 56;
            this.Deletesup.Text = "Delete";
            this.Deletesup.Click += new System.EventHandler(this.Deletesup_Click);
            // 
            // Addlabel
            // 
            this.Addlabel.BorderRadius = 10;
            this.Addlabel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Addlabel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Addlabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Addlabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Addlabel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.Addlabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addlabel.ForeColor = System.Drawing.Color.White;
            this.Addlabel.Location = new System.Drawing.Point(523, 434);
            this.Addlabel.Name = "Addlabel";
            this.Addlabel.Size = new System.Drawing.Size(85, 45);
            this.Addlabel.TabIndex = 55;
            this.Addlabel.Text = "Add";
            this.Addlabel.Click += new System.EventHandler(this.Addlabel_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label9.Location = new System.Drawing.Point(519, 379);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 54;
            this.label9.Text = "Product Quantity";
            // 
            // ProdQuantityTextBox
            // 
            this.ProdQuantityTextBox.BorderRadius = 10;
            this.ProdQuantityTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdQuantityTextBox.DefaultText = "";
            this.ProdQuantityTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdQuantityTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdQuantityTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdQuantityTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdQuantityTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdQuantityTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProdQuantityTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdQuantityTextBox.Location = new System.Drawing.Point(681, 363);
            this.ProdQuantityTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProdQuantityTextBox.Name = "ProdQuantityTextBox";
            this.ProdQuantityTextBox.PasswordChar = '\0';
            this.ProdQuantityTextBox.PlaceholderText = "";
            this.ProdQuantityTextBox.SelectedText = "";
            this.ProdQuantityTextBox.Size = new System.Drawing.Size(118, 36);
            this.ProdQuantityTextBox.TabIndex = 53;
            this.ProdQuantityTextBox.TextChanged += new System.EventHandler(this.ProdQuantityTextBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(519, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 52;
            this.label8.Text = "Product Price";
            // 
            // ProdpriceTextBox
            // 
            this.ProdpriceTextBox.BorderRadius = 10;
            this.ProdpriceTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProdpriceTextBox.DefaultText = "";
            this.ProdpriceTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.ProdpriceTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.ProdpriceTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdpriceTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.ProdpriceTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdpriceTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ProdpriceTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.ProdpriceTextBox.Location = new System.Drawing.Point(681, 301);
            this.ProdpriceTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ProdpriceTextBox.Name = "ProdpriceTextBox";
            this.ProdpriceTextBox.PasswordChar = '\0';
            this.ProdpriceTextBox.PlaceholderText = "";
            this.ProdpriceTextBox.ReadOnly = true;
            this.ProdpriceTextBox.SelectedText = "";
            this.ProdpriceTextBox.Size = new System.Drawing.Size(118, 36);
            this.ProdpriceTextBox.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(519, 251);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Product Name";
            // 
            // prodNameComboBox
            // 
            this.prodNameComboBox.BackColor = System.Drawing.Color.Transparent;
            this.prodNameComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.prodNameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.prodNameComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodNameComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.prodNameComboBox.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.prodNameComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.prodNameComboBox.ItemHeight = 30;
            this.prodNameComboBox.Location = new System.Drawing.Point(681, 242);
            this.prodNameComboBox.Name = "prodNameComboBox";
            this.prodNameComboBox.Size = new System.Drawing.Size(119, 36);
            this.prodNameComboBox.TabIndex = 49;
            this.prodNameComboBox.SelectedIndexChanged += new System.EventHandler(this.prodNameComboBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(589, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 48;
            this.label6.Text = "Product info";
            // 
            // SaveOrderButton
            // 
            this.SaveOrderButton.BorderRadius = 10;
            this.SaveOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveOrderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.SaveOrderButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveOrderButton.ForeColor = System.Drawing.Color.White;
            this.SaveOrderButton.Location = new System.Drawing.Point(60, 503);
            this.SaveOrderButton.Name = "SaveOrderButton";
            this.SaveOrderButton.Size = new System.Drawing.Size(204, 45);
            this.SaveOrderButton.TabIndex = 60;
            this.SaveOrderButton.Text = "Save Order";
            this.SaveOrderButton.Click += new System.EventHandler(this.SaveOrderButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(509, 521);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 59;
            this.label1.Text = "TotalCost";
            // 
            // total
            // 
            this.total.BorderRadius = 10;
            this.total.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.total.DefaultText = "";
            this.total.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.total.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.total.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.total.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.total.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.total.Location = new System.Drawing.Point(632, 512);
            this.total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.PlaceholderText = "";
            this.total.ReadOnly = true;
            this.total.SelectedText = "";
            this.total.Size = new System.Drawing.Size(200, 36);
            this.total.TabIndex = 58;
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(354, 24);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(112, 41);
            this.guna2HtmlLabel1.TabIndex = 115;
            this.guna2HtmlLabel1.Text = "Orders";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(12, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 249);
            this.dataGridView1.TabIndex = 116;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // OrderForm
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Cell;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 567);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.SaveOrderButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.Deletesup);
            this.Controls.Add(this.Addlabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProdQuantityTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProdpriceTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prodNameComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.StateComboBox);
            this.Controls.Add(this.SuppliersComboBox);
            this.Controls.Add(this.CustoComboBox);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(990, 567);
            this.MinimumSize = new System.Drawing.Size(990, 567);
            this.Name = "OrderForm";
            this.Text = "Order";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.OrderForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox TypeComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox StateComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox SuppliersComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox CustoComboBox;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Button Deletesup;
        private Guna.UI2.WinForms.Guna2Button Addlabel;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox ProdQuantityTextBox;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2TextBox ProdpriceTextBox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox prodNameComboBox;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button SaveOrderButton;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox total;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}