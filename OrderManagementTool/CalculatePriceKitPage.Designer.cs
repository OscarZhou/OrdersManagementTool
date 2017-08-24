namespace OrderManagementTool
{
    partial class CalculatePriceKitPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatePriceKitPage));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNZPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboExchangeRate = new System.Windows.Forms.ComboBox();
            this.cboProfitMargin = new System.Windows.Forms.ComboBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvPriceHistory = new System.Windows.Forms.DataGridView();
            this.Opt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.btnClearPrice = new System.Windows.Forms.Button();
            this.btnImportToOrder = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbItem = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbLogo = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbError = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceHistory)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.Location = new System.Drawing.Point(58, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price($NZ)";
            // 
            // tbNZPrice
            // 
            this.tbNZPrice.Location = new System.Drawing.Point(48, 215);
            this.tbNZPrice.Multiline = true;
            this.tbNZPrice.Name = "tbNZPrice";
            this.tbNZPrice.Size = new System.Drawing.Size(118, 28);
            this.tbNZPrice.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.Location = new System.Drawing.Point(237, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "ER";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.Location = new System.Drawing.Point(173, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.Location = new System.Drawing.Point(376, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "PM";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label5.Location = new System.Drawing.Point(314, 212);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 31);
            this.label5.TabIndex = 0;
            this.label5.Text = "x";
            // 
            // cboExchangeRate
            // 
            this.cboExchangeRate.FormattingEnabled = true;
            this.cboExchangeRate.Items.AddRange(new object[] {
            "5.0",
            "5.1",
            "5.2",
            "5.3",
            "5.4",
            "5.5",
            "5.6",
            "5.7",
            "5.8"});
            this.cboExchangeRate.Location = new System.Drawing.Point(203, 215);
            this.cboExchangeRate.Name = "cboExchangeRate";
            this.cboExchangeRate.Size = new System.Drawing.Size(97, 26);
            this.cboExchangeRate.TabIndex = 3;
            this.cboExchangeRate.SelectionChangeCommitted += new System.EventHandler(this.cboExchangeRate_SelectionChangeCommitted);
            // 
            // cboProfitMargin
            // 
            this.cboProfitMargin.FormattingEnabled = true;
            this.cboProfitMargin.Items.AddRange(new object[] {
            "1.0",
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5"});
            this.cboProfitMargin.Location = new System.Drawing.Point(347, 215);
            this.cboProfitMargin.Name = "cboProfitMargin";
            this.cboProfitMargin.Size = new System.Drawing.Size(98, 26);
            this.cboProfitMargin.TabIndex = 4;
            this.cboProfitMargin.SelectionChangeCommitted += new System.EventHandler(this.cboProfitMargin_SelectionChangeCommitted);
            // 
            // lbResult
            // 
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbResult.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbResult.Location = new System.Drawing.Point(500, 215);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(104, 31);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "0";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label7.Location = new System.Drawing.Point(457, 212);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "=";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label6.Location = new System.Drawing.Point(496, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price(￥RMB)";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReset.Location = new System.Drawing.Point(467, 82);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(85, 40);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(562, 82);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(84, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(17, 633);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 18);
            this.label8.TabIndex = 6;
            this.label8.Text = "ER: Exchange Rate; PM: Profit Margin";
            // 
            // dgvPriceHistory
            // 
            this.dgvPriceHistory.AccessibleName = "";
            this.dgvPriceHistory.AllowUserToAddRows = false;
            this.dgvPriceHistory.AllowUserToDeleteRows = false;
            this.dgvPriceHistory.AllowUserToResizeColumns = false;
            this.dgvPriceHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PapayaWhip;
            this.dgvPriceHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPriceHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.dgvPriceHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPriceHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPriceHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPriceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPriceHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Opt,
            this.UnitPrice,
            this.ItemDescription,
            this.CreateTime});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPriceHistory.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvPriceHistory.Location = new System.Drawing.Point(20, 309);
            this.dgvPriceHistory.MultiSelect = false;
            this.dgvPriceHistory.Name = "dgvPriceHistory";
            this.dgvPriceHistory.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPriceHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvPriceHistory.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvPriceHistory.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvPriceHistory.RowTemplate.Height = 30;
            this.dgvPriceHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPriceHistory.Size = new System.Drawing.Size(620, 312);
            this.dgvPriceHistory.TabIndex = 7;
            this.dgvPriceHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPriceHistory_CellClick);
            // 
            // Opt
            // 
            this.Opt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.NullValue = false;
            this.Opt.DefaultCellStyle = dataGridViewCellStyle3;
            this.Opt.HeaderText = "Opt.";
            this.Opt.Name = "Opt";
            this.Opt.ReadOnly = true;
            this.Opt.Visible = false;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            this.UnitPrice.HeaderText = "Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UnitPrice.Width = 64;
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDescription.DataPropertyName = "ItemDescription";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.ItemDescription.DefaultCellStyle = dataGridViewCellStyle5;
            this.ItemDescription.HeaderText = "Item";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            this.ItemDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.CreateTime.DefaultCellStyle = dataGridViewCellStyle6;
            this.CreateTime.HeaderText = "Date";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CreateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CreateTime.Width = 63;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label9.Location = new System.Drawing.Point(30, 275);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(111, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price History";
            // 
            // btnClearPrice
            // 
            this.btnClearPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnClearPrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnClearPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearPrice.Image = ((System.Drawing.Image)(resources.GetObject("btnClearPrice.Image")));
            this.btnClearPrice.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClearPrice.Location = new System.Drawing.Point(371, 82);
            this.btnClearPrice.Name = "btnClearPrice";
            this.btnClearPrice.Size = new System.Drawing.Size(86, 40);
            this.btnClearPrice.TabIndex = 5;
            this.btnClearPrice.Text = "Clear";
            this.btnClearPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClearPrice.UseVisualStyleBackColor = false;
            this.btnClearPrice.Click += new System.EventHandler(this.btnClearPrice_Click);
            // 
            // btnImportToOrder
            // 
            this.btnImportToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnImportToOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnImportToOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportToOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImportToOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnImportToOrder.Image")));
            this.btnImportToOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportToOrder.Location = new System.Drawing.Point(16, 82);
            this.btnImportToOrder.Name = "btnImportToOrder";
            this.btnImportToOrder.Size = new System.Drawing.Size(160, 40);
            this.btnImportToOrder.TabIndex = 5;
            this.btnImportToOrder.Text = "Move To Order";
            this.btnImportToOrder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportToOrder.UseVisualStyleBackColor = false;
            this.btnImportToOrder.Click += new System.EventHandler(this.btnImportToOrder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label10.Location = new System.Drawing.Point(28, 135);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 25);
            this.label10.TabIndex = 8;
            this.label10.Text = "Item:";
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(93, 136);
            this.tbItem.Multiline = true;
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(537, 28);
            this.tbItem.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(16, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(633, 2);
            this.label11.TabIndex = 11;
            this.label11.Text = "label11";
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::OrderManagementTool.Properties.Resources.zd;
            this.panelTop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.lbLogo);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(658, 67);
            this.panelTop.TabIndex = 12;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(614, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 43);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "x";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbLogo
            // 
            this.lbLogo.AutoSize = true;
            this.lbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.lbLogo.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLogo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbLogo.Location = new System.Drawing.Point(12, 9);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(378, 48);
            this.lbLogo.TabIndex = 1;
            this.lbLogo.Text = "Calculation Price Kit";
            this.lbLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbLogo_MouseDown);
            this.lbLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbLogo_MouseMove);
            this.lbLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbLogo_MouseUp);
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(13, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(633, 2);
            this.label12.TabIndex = 13;
            this.label12.Text = "label12";
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(329, 275);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(71, 18);
            this.lbError.TabIndex = 14;
            this.lbError.Text = "label13";
            // 
            // CalculatePriceKitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(658, 660);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbItem);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvPriceHistory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnImportToOrder);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClearPrice);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.cboProfitMargin);
            this.Controls.Add(this.cboExchangeRate);
            this.Controls.Add(this.tbNZPrice);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(800, 600);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculatePriceKitPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Price Calculation Kit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CalculatePriceKitPage_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CalculatePriceKitPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceHistory)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNZPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboExchangeRate;
        private System.Windows.Forms.ComboBox cboProfitMargin;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvPriceHistory;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnClearPrice;
        private System.Windows.Forms.Button btnImportToOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Opt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
    }
}