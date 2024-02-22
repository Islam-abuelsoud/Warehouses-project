namespace Warehouses
{
    partial class OrdersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.total = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.CustoComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SuppliersComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.StateComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.TypeComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ItemsDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.prodNameComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ProdpriceTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ProdQuantityTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.UpdatesupBtn = new Guna.UI2.WinForms.Guna2Button();
            this.Deletesup = new Guna.UI2.WinForms.Guna2Button();
            this.Addlabel = new Guna.UI2.WinForms.Guna2Button();
            this.SaveOrderButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.total.Location = new System.Drawing.Point(120, 402);
            this.total.Name = "total";
            this.total.PasswordChar = '\0';
            this.total.PlaceholderText = "";
            this.total.ReadOnly = true;
            this.total.SelectedText = "";
            this.total.Size = new System.Drawing.Size(200, 36);
            this.total.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 411);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "TotalCost";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(1305, 39);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(200, 36);
            this.guna2DateTimePicker1.TabIndex = 27;
            this.guna2DateTimePicker1.Value = new System.DateTime(2024, 2, 12, 23, 29, 42, 858);
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
            this.CustoComboBox.Location = new System.Drawing.Point(1161, 39);
            this.CustoComboBox.Name = "CustoComboBox";
            this.CustoComboBox.Size = new System.Drawing.Size(119, 36);
            this.CustoComboBox.TabIndex = 28;
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
            this.SuppliersComboBox.Location = new System.Drawing.Point(993, 39);
            this.SuppliersComboBox.Name = "SuppliersComboBox";
            this.SuppliersComboBox.Size = new System.Drawing.Size(119, 36);
            this.SuppliersComboBox.TabIndex = 29;
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
            this.StateComboBox.Location = new System.Drawing.Point(809, 39);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.Size = new System.Drawing.Size(119, 36);
            this.StateComboBox.TabIndex = 30;
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
            this.TypeComboBox.Location = new System.Drawing.Point(628, 40);
            this.TypeComboBox.Name = "TypeComboBox";
            this.TypeComboBox.Size = new System.Drawing.Size(119, 36);
            this.TypeComboBox.TabIndex = 31;
            this.TypeComboBox.SelectedIndexChanged += new System.EventHandler(this.TypeComboBox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1182, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "Customer";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1011, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 20);
            this.label3.TabIndex = 33;
            this.label3.Text = "Supplaiyer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(844, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 34;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(657, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 20);
            this.label5.TabIndex = 35;
            this.label5.Text = "Type";
            // 
            // ItemsDataGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ItemsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ItemsDataGridView.ColumnHeadersHeight = 4;
            this.ItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemsDataGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.ItemsDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDataGridView.Location = new System.Drawing.Point(766, 91);
            this.ItemsDataGridView.Name = "ItemsDataGridView";
            this.ItemsDataGridView.RowHeadersVisible = false;
            this.ItemsDataGridView.Size = new System.Drawing.Size(682, 329);
            this.ItemsDataGridView.TabIndex = 36;
            this.ItemsDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ItemsDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ItemsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ItemsDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ItemsDataGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ItemsDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.ItemsDataGridView.ThemeStyle.ReadOnly = false;
            this.ItemsDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ItemsDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ItemsDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemsDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ItemsDataGridView.ThemeStyle.RowsStyle.Height = 22;
            this.ItemsDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ItemsDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Perpetua Titling MT", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(167, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 18);
            this.label6.TabIndex = 37;
            this.label6.Text = "Product info";
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
            this.prodNameComboBox.Location = new System.Drawing.Point(184, 91);
            this.prodNameComboBox.Name = "prodNameComboBox";
            this.prodNameComboBox.Size = new System.Drawing.Size(119, 36);
            this.prodNameComboBox.TabIndex = 38;
            this.prodNameComboBox.SelectedIndexChanged += new System.EventHandler(this.prodNameComboBox_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(41, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 20);
            this.label7.TabIndex = 39;
            this.label7.Text = "Product Name";
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
            this.ProdpriceTextBox.Location = new System.Drawing.Point(184, 151);
            this.ProdpriceTextBox.Name = "ProdpriceTextBox";
            this.ProdpriceTextBox.PasswordChar = '\0';
            this.ProdpriceTextBox.PlaceholderText = "";
            this.ProdpriceTextBox.ReadOnly = true;
            this.ProdpriceTextBox.SelectedText = "";
            this.ProdpriceTextBox.Size = new System.Drawing.Size(200, 36);
            this.ProdpriceTextBox.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(40, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Product Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(40, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 20);
            this.label9.TabIndex = 43;
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
            this.ProdQuantityTextBox.Location = new System.Drawing.Point(184, 221);
            this.ProdQuantityTextBox.Name = "ProdQuantityTextBox";
            this.ProdQuantityTextBox.PasswordChar = '\0';
            this.ProdQuantityTextBox.PlaceholderText = "";
            this.ProdQuantityTextBox.SelectedText = "";
            this.ProdQuantityTextBox.Size = new System.Drawing.Size(200, 36);
            this.ProdQuantityTextBox.TabIndex = 42;
            this.ProdQuantityTextBox.Leave += new System.EventHandler(this.ProdQuantityTextBox_TextChanged);
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
            this.UpdatesupBtn.Location = new System.Drawing.Point(182, 305);
            this.UpdatesupBtn.Name = "UpdatesupBtn";
            this.UpdatesupBtn.Size = new System.Drawing.Size(85, 45);
            this.UpdatesupBtn.TabIndex = 47;
            this.UpdatesupBtn.Text = "Update";
            this.UpdatesupBtn.Click += new System.EventHandler(this.updateBtn_Click);
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
            this.Deletesup.Location = new System.Drawing.Point(300, 305);
            this.Deletesup.Name = "Deletesup";
            this.Deletesup.Size = new System.Drawing.Size(85, 45);
            this.Deletesup.TabIndex = 46;
            this.Deletesup.Text = "Delete";
            this.Deletesup.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // Addlabel
            // 
            this.Addlabel.BorderRadius = 10;
            this.Addlabel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Addlabel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Addlabel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Addlabel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Addlabel.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addlabel.ForeColor = System.Drawing.Color.White;
            this.Addlabel.Location = new System.Drawing.Point(66, 305);
            this.Addlabel.Name = "Addlabel";
            this.Addlabel.Size = new System.Drawing.Size(85, 45);
            this.Addlabel.TabIndex = 45;
            this.Addlabel.Text = "Add";
            this.Addlabel.Click += new System.EventHandler(this.Addlabel_Click);
            // 
            // SaveOrderButton
            // 
            this.SaveOrderButton.BorderRadius = 10;
            this.SaveOrderButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveOrderButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveOrderButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveOrderButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveOrderButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SaveOrderButton.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveOrderButton.ForeColor = System.Drawing.Color.White;
            this.SaveOrderButton.Location = new System.Drawing.Point(445, 402);
            this.SaveOrderButton.Name = "SaveOrderButton";
            this.SaveOrderButton.Size = new System.Drawing.Size(204, 45);
            this.SaveOrderButton.TabIndex = 48;
            this.SaveOrderButton.Text = "Save Order";
            this.SaveOrderButton.Click += new System.EventHandler(this.SaveOrderButton_Click);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1549, 450);
            this.Controls.Add(this.SaveOrderButton);
            this.Controls.Add(this.UpdatesupBtn);
            this.Controls.Add(this.Deletesup);
            this.Controls.Add(this.Addlabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ProdQuantityTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ProdpriceTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.prodNameComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ItemsDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TypeComboBox);
            this.Controls.Add(this.StateComboBox);
            this.Controls.Add(this.SuppliersComboBox);
            this.Controls.Add(this.CustoComboBox);
            this.Controls.Add(this.guna2DateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total);
            this.Name = "OrdersForm";
            this.Text = "OrdersForm";
            ((System.ComponentModel.ISupportInitialize)(this.ItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox total;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2ComboBox CustoComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox SuppliersComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox StateComboBox;
        private Guna.UI2.WinForms.Guna2ComboBox TypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2DataGridView ItemsDataGridView;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox prodNameComboBox;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox ProdpriceTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox ProdQuantityTextBox;
        private Guna.UI2.WinForms.Guna2Button UpdatesupBtn;
        private Guna.UI2.WinForms.Guna2Button Deletesup;
        private Guna.UI2.WinForms.Guna2Button Addlabel;
        private Guna.UI2.WinForms.Guna2Button SaveOrderButton;
    }
}