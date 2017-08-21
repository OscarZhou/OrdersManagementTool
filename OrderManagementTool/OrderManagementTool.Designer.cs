namespace OrderManagementTool
{
    partial class OrderManagementTool
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderManagementTool));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnOpenDataImporter = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.lbTotalProfit = new System.Windows.Forms.Label();
            this.dgvTransaction = new System.Windows.Forms.DataGridView();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUndoneOrders = new System.Windows.Forms.Button();
            this.btnDataAnalysis = new System.Windows.Forms.Button();
            this.cmbSorting = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnView = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnPriceKit = new System.Windows.Forms.Button();
            this.lbVersion = new System.Windows.Forms.Label();
            this.btnOrderText = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbLogo = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbAuthor = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.Location = new System.Drawing.Point(877, 14);
            this.tbSearch.MaxLength = 20;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(149, 31);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Input Name";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(1032, 10);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 40);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOpenDataImporter
            // 
            this.btnOpenDataImporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnOpenDataImporter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnOpenDataImporter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenDataImporter.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnOpenDataImporter.ForeColor = System.Drawing.Color.White;
            this.btnOpenDataImporter.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenDataImporter.Image")));
            this.btnOpenDataImporter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenDataImporter.Location = new System.Drawing.Point(7, 583);
            this.btnOpenDataImporter.Name = "btnOpenDataImporter";
            this.btnOpenDataImporter.Size = new System.Drawing.Size(202, 42);
            this.btnOpenDataImporter.TabIndex = 4;
            this.btnOpenDataImporter.Text = "    Data Exchange";
            this.btnOpenDataImporter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpenDataImporter.UseVisualStyleBackColor = false;
            this.btnOpenDataImporter.Click += new System.EventHandler(this.btnOpenDataImporter_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAddOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAddOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddOrder.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnAddOrder.Image")));
            this.btnAddOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrder.Location = new System.Drawing.Point(7, 15);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(202, 42);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = "    Create Order";
            this.btnAddOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lbTotalProfit
            // 
            this.lbTotalProfit.AutoSize = true;
            this.lbTotalProfit.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalProfit.ForeColor = System.Drawing.Color.White;
            this.lbTotalProfit.Location = new System.Drawing.Point(511, 14);
            this.lbTotalProfit.Name = "lbTotalProfit";
            this.lbTotalProfit.Size = new System.Drawing.Size(63, 30);
            this.lbTotalProfit.TabIndex = 7;
            this.lbTotalProfit.Text = "Profit";
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowDrop = true;
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AllowUserToResizeColumns = false;
            this.dgvTransaction.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PapayaWhip;
            this.dgvTransaction.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaction.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.dgvTransaction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvTransaction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNo,
            this.Purchaser,
            this.SellingPrice,
            this.PurchasePrice,
            this.Profit,
            this.CreateTime});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransaction.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTransaction.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.dgvTransaction.Location = new System.Drawing.Point(16, 52);
            this.dgvTransaction.MultiSelect = false;
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransaction.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvTransaction.RowHeadersVisible = false;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            this.dgvTransaction.RowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvTransaction.RowTemplate.Height = 30;
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(1126, 608);
            this.dgvTransaction.TabIndex = 6;
            this.dgvTransaction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellDoubleClick);
            this.dgvTransaction.Click += new System.EventHandler(this.dgvTransaction_Click);
            // 
            // OrderNo
            // 
            this.OrderNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OrderNo.DataPropertyName = "OrderNo";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.OrderNo.DefaultCellStyle = dataGridViewCellStyle3;
            this.OrderNo.FillWeight = 30F;
            this.OrderNo.HeaderText = "Order No";
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            this.OrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.OrderNo.Width = 106;
            // 
            // Purchaser
            // 
            this.Purchaser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Purchaser.DataPropertyName = "Purchaser";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.Purchaser.DefaultCellStyle = dataGridViewCellStyle4;
            this.Purchaser.FillWeight = 35.51238F;
            this.Purchaser.HeaderText = "Purchaser Name";
            this.Purchaser.Name = "Purchaser";
            this.Purchaser.ReadOnly = true;
            this.Purchaser.Width = 202;
            // 
            // SellingPrice
            // 
            this.SellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SellingPrice.DataPropertyName = "SellingPrice";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.NullValue = null;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.SellingPrice.DefaultCellStyle = dataGridViewCellStyle5;
            this.SellingPrice.FillWeight = 35.51238F;
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            this.SellingPrice.Width = 161;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.PurchasePrice.DefaultCellStyle = dataGridViewCellStyle6;
            this.PurchasePrice.FillWeight = 35.51238F;
            this.PurchasePrice.HeaderText = "Purchasing Price";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            this.PurchasePrice.Width = 202;
            // 
            // Profit
            // 
            this.Profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Profit.DataPropertyName = "Profit";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.NullValue = null;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.Profit.DefaultCellStyle = dataGridViewCellStyle7;
            this.Profit.FillWeight = 42.0718F;
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            this.Profit.Width = 99;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.CreateTime.DefaultCellStyle = dataGridViewCellStyle8;
            this.CreateTime.FillWeight = 42.0718F;
            this.CreateTime.HeaderText = "Date";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // btnUndoneOrders
            // 
            this.btnUndoneOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnUndoneOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnUndoneOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndoneOrders.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnUndoneOrders.ForeColor = System.Drawing.Color.White;
            this.btnUndoneOrders.Image = ((System.Drawing.Image)(resources.GetObject("btnUndoneOrders.Image")));
            this.btnUndoneOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndoneOrders.Location = new System.Drawing.Point(7, 64);
            this.btnUndoneOrders.Name = "btnUndoneOrders";
            this.btnUndoneOrders.Size = new System.Drawing.Size(202, 42);
            this.btnUndoneOrders.TabIndex = 2;
            this.btnUndoneOrders.Text = "    Undone Orders";
            this.btnUndoneOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUndoneOrders.UseVisualStyleBackColor = false;
            this.btnUndoneOrders.Click += new System.EventHandler(this.btnUndoneOrders_Click);
            // 
            // btnDataAnalysis
            // 
            this.btnDataAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnDataAnalysis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnDataAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDataAnalysis.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnDataAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnDataAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("btnDataAnalysis.Image")));
            this.btnDataAnalysis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataAnalysis.Location = new System.Drawing.Point(7, 631);
            this.btnDataAnalysis.Name = "btnDataAnalysis";
            this.btnDataAnalysis.Size = new System.Drawing.Size(202, 42);
            this.btnDataAnalysis.TabIndex = 5;
            this.btnDataAnalysis.Text = "    Data Analysis";
            this.btnDataAnalysis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDataAnalysis.UseVisualStyleBackColor = false;
            // 
            // cmbSorting
            // 
            this.cmbSorting.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSorting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbSorting.ForeColor = System.Drawing.Color.Black;
            this.cmbSorting.FormattingEnabled = true;
            this.cmbSorting.Location = new System.Drawing.Point(127, 17);
            this.cmbSorting.Name = "cmbSorting";
            this.cmbSorting.Size = new System.Drawing.Size(164, 33);
            this.cmbSorting.TabIndex = 8;
            this.cmbSorting.SelectedIndexChanged += new System.EventHandler(this.cmbSorting_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sorting:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnView.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Image = ((System.Drawing.Image)(resources.GetObject("btnView.Image")));
            this.btnView.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.Location = new System.Drawing.Point(7, 113);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(202, 42);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "    View Order";
            this.btnView.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.BtnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEdit.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("BtnEdit.Image")));
            this.BtnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.Location = new System.Drawing.Point(7, 162);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(202, 42);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "    Edit Order";
            this.BtnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnDeleteOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnDeleteOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteOrder.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteOrder.Image")));
            this.btnDeleteOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteOrder.Location = new System.Drawing.Point(7, 211);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(202, 42);
            this.btnDeleteOrder.TabIndex = 2;
            this.btnDeleteOrder.Text = "    Delete Order";
            this.btnDeleteOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnPriceKit
            // 
            this.btnPriceKit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnPriceKit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnPriceKit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPriceKit.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnPriceKit.ForeColor = System.Drawing.Color.White;
            this.btnPriceKit.Image = ((System.Drawing.Image)(resources.GetObject("btnPriceKit.Image")));
            this.btnPriceKit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPriceKit.Location = new System.Drawing.Point(7, 260);
            this.btnPriceKit.Name = "btnPriceKit";
            this.btnPriceKit.Size = new System.Drawing.Size(202, 42);
            this.btnPriceKit.TabIndex = 2;
            this.btnPriceKit.Text = "    Price Kit";
            this.btnPriceKit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPriceKit.UseVisualStyleBackColor = false;
            this.btnPriceKit.Click += new System.EventHandler(this.btnPriceKit_Click);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lbVersion.ForeColor = System.Drawing.Color.White;
            this.lbVersion.Location = new System.Drawing.Point(1301, 12);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(79, 30);
            this.lbVersion.TabIndex = 7;
            this.lbVersion.Text = "version";
            // 
            // btnOrderText
            // 
            this.btnOrderText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnOrderText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnOrderText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrderText.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnOrderText.ForeColor = System.Drawing.Color.White;
            this.btnOrderText.Image = ((System.Drawing.Image)(resources.GetObject("btnOrderText.Image")));
            this.btnOrderText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderText.Location = new System.Drawing.Point(7, 309);
            this.btnOrderText.Name = "btnOrderText";
            this.btnOrderText.Size = new System.Drawing.Size(202, 42);
            this.btnOrderText.TabIndex = 2;
            this.btnOrderText.Text = "    Order Text";
            this.btnOrderText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrderText.UseVisualStyleBackColor = false;
            this.btnOrderText.Click += new System.EventHandler(this.btnOrderText_Click);
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
            this.panelTop.Size = new System.Drawing.Size(1400, 72);
            this.panelTop.TabIndex = 10;
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
            this.btnClose.Location = new System.Drawing.Point(1356, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(41, 43);
            this.btnClose.TabIndex = 2;
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
            this.lbLogo.Location = new System.Drawing.Point(21, 9);
            this.lbLogo.Name = "lbLogo";
            this.lbLogo.Size = new System.Drawing.Size(457, 48);
            this.lbLogo.TabIndex = 0;
            this.lbLogo.Text = "Order Management Tool";
            this.lbLogo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lbLogo_MouseDown);
            this.lbLogo.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lbLogo_MouseMove);
            this.lbLogo.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lbLogo_MouseUp);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(78)))), ((int)(((byte)(111)))));
            this.panel2.Controls.Add(this.lbAuthor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.lbVersion);
            this.panel2.Controls.Add(this.lbTotalProfit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 778);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 52);
            this.panel2.TabIndex = 11;
            // 
            // lbAuthor
            // 
            this.lbAuthor.AutoSize = true;
            this.lbAuthor.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.lbAuthor.Location = new System.Drawing.Point(150, 14);
            this.lbAuthor.Name = "lbAuthor";
            this.lbAuthor.Size = new System.Drawing.Size(74, 30);
            this.lbAuthor.TabIndex = 10;
            this.lbAuthor.Text = "author";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.label5.Image = ((System.Drawing.Image)(resources.GetObject("label5.Image")));
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label5.Location = new System.Drawing.Point(29, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Author: ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(1184, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Version: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(364, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total Profit: ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // splitContainer
            // 
            this.splitContainer.IsSplitterFixed = true;
            this.splitContainer.Location = new System.Drawing.Point(14, 78);
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer.Panel1.Controls.Add(this.label6);
            this.splitContainer.Panel1.Controls.Add(this.cmbSorting);
            this.splitContainer.Panel1.Controls.Add(this.dgvTransaction);
            this.splitContainer.Panel1.Controls.Add(this.btnSearch);
            this.splitContainer.Panel1.Controls.Add(this.tbSearch);
            this.splitContainer.Panel1.Controls.Add(this.label1);
            this.splitContainer.Panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(109)))), ((int)(((byte)(176)))));
            this.splitContainer.Panel2.Controls.Add(this.btnAddOrder);
            this.splitContainer.Panel2.Controls.Add(this.btnUndoneOrders);
            this.splitContainer.Panel2.Controls.Add(this.btnDataAnalysis);
            this.splitContainer.Panel2.Controls.Add(this.btnTransaction);
            this.splitContainer.Panel2.Controls.Add(this.btnOrderText);
            this.splitContainer.Panel2.Controls.Add(this.btnOpenDataImporter);
            this.splitContainer.Panel2.Controls.Add(this.btnView);
            this.splitContainer.Panel2.Controls.Add(this.btnPriceKit);
            this.splitContainer.Panel2.Controls.Add(this.BtnEdit);
            this.splitContainer.Panel2.Controls.Add(this.btnDeleteOrder);
            this.splitContainer.Size = new System.Drawing.Size(1383, 691);
            this.splitContainer.SplitterDistance = 1161;
            this.splitContainer.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(14, 49);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1128, 2);
            this.label6.TabIndex = 10;
            this.label6.Text = "label6";
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransaction.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnTransaction.Image")));
            this.btnTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.Location = new System.Drawing.Point(7, 358);
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.Size = new System.Drawing.Size(202, 42);
            this.btnTransaction.TabIndex = 2;
            this.btnTransaction.Text = "    Transactions";
            this.btnTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
            // 
            // OrderManagementTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(181)))), ((int)(((byte)(211)))));
            this.ClientSize = new System.Drawing.Size(1400, 830);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.splitContainer);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderManagementTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management Tool";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderManagementTool_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOpenDataImporter;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lbTotalProfit;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.Button btnUndoneOrders;
        private System.Windows.Forms.Button btnDataAnalysis;
        private System.Windows.Forms.ComboBox cmbSorting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnPriceKit;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Button btnOrderText;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lbLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbAuthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.Button btnTransaction;
    }
}

