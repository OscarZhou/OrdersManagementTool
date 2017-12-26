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
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbEndDate = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.lbFromDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnTransaction = new System.Windows.Forms.Button();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            resources.ApplyResources(this.tbSearch, "tbSearch");
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Click += new System.EventHandler(this.tbSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.White;
            resources.ApplyResources(this.btnSearch, "btnSearch");
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOpenDataImporter
            // 
            this.btnOpenDataImporter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnOpenDataImporter.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnOpenDataImporter, "btnOpenDataImporter");
            this.btnOpenDataImporter.ForeColor = System.Drawing.Color.White;
            this.btnOpenDataImporter.Name = "btnOpenDataImporter";
            this.btnOpenDataImporter.UseVisualStyleBackColor = false;
            this.btnOpenDataImporter.Click += new System.EventHandler(this.btnOpenDataImporter_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnAddOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnAddOrder, "btnAddOrder");
            this.btnAddOrder.ForeColor = System.Drawing.Color.White;
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.UseVisualStyleBackColor = false;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lbTotalProfit
            // 
            resources.ApplyResources(this.lbTotalProfit, "lbTotalProfit");
            this.lbTotalProfit.ForeColor = System.Drawing.Color.White;
            this.lbTotalProfit.Name = "lbTotalProfit";
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
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
            resources.ApplyResources(this.dgvTransaction, "dgvTransaction");
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
            this.dgvTransaction.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTransaction_CellDoubleClick);
            this.dgvTransaction.Click += new System.EventHandler(this.dgvTransaction_Click);
            // 
            // btnUndoneOrders
            // 
            this.btnUndoneOrders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnUndoneOrders.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnUndoneOrders, "btnUndoneOrders");
            this.btnUndoneOrders.ForeColor = System.Drawing.Color.White;
            this.btnUndoneOrders.Name = "btnUndoneOrders";
            this.btnUndoneOrders.UseVisualStyleBackColor = false;
            this.btnUndoneOrders.Click += new System.EventHandler(this.btnUndoneOrders_Click);
            // 
            // btnDataAnalysis
            // 
            this.btnDataAnalysis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnDataAnalysis.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnDataAnalysis, "btnDataAnalysis");
            this.btnDataAnalysis.ForeColor = System.Drawing.Color.White;
            this.btnDataAnalysis.Name = "btnDataAnalysis";
            this.btnDataAnalysis.UseVisualStyleBackColor = false;
            // 
            // cmbSorting
            // 
            this.cmbSorting.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.cmbSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cmbSorting, "cmbSorting");
            this.cmbSorting.ForeColor = System.Drawing.Color.Black;
            this.cmbSorting.FormattingEnabled = true;
            this.cmbSorting.Name = "cmbSorting";
            this.cmbSorting.SelectedIndexChanged += new System.EventHandler(this.cmbSorting_SelectedIndexChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Name = "label1";
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnView.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnView, "btnView");
            this.btnView.ForeColor = System.Drawing.Color.White;
            this.btnView.Name = "btnView";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.BtnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.BtnEdit, "BtnEdit");
            this.BtnEdit.ForeColor = System.Drawing.Color.White;
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.UseVisualStyleBackColor = false;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnDeleteOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnDeleteOrder, "btnDeleteOrder");
            this.btnDeleteOrder.ForeColor = System.Drawing.Color.White;
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.UseVisualStyleBackColor = false;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnPriceKit
            // 
            this.btnPriceKit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnPriceKit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnPriceKit, "btnPriceKit");
            this.btnPriceKit.ForeColor = System.Drawing.Color.White;
            this.btnPriceKit.Name = "btnPriceKit";
            this.btnPriceKit.UseVisualStyleBackColor = false;
            this.btnPriceKit.Click += new System.EventHandler(this.btnPriceKit_Click);
            // 
            // lbVersion
            // 
            resources.ApplyResources(this.lbVersion, "lbVersion");
            this.lbVersion.ForeColor = System.Drawing.Color.White;
            this.lbVersion.Name = "lbVersion";
            // 
            // btnOrderText
            // 
            this.btnOrderText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnOrderText.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnOrderText, "btnOrderText");
            this.btnOrderText.ForeColor = System.Drawing.Color.White;
            this.btnOrderText.Name = "btnOrderText";
            this.btnOrderText.UseVisualStyleBackColor = false;
            this.btnOrderText.Click += new System.EventHandler(this.btnOrderText_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackgroundImage = global::OrderManagementTool.Properties.Resources.zd;
            resources.ApplyResources(this.panelTop, "panelTop");
            this.panelTop.Controls.Add(this.btnClose);
            this.panelTop.Controls.Add(this.lbLogo);
            this.panelTop.Name = "panelTop";
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(54)))), ((int)(((byte)(112)))));
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbLogo
            // 
            resources.ApplyResources(this.lbLogo, "lbLogo");
            this.lbLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(62)))), ((int)(((byte)(125)))));
            this.lbLogo.ForeColor = System.Drawing.SystemColors.Control;
            this.lbLogo.Name = "lbLogo";
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
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            // 
            // lbAuthor
            // 
            resources.ApplyResources(this.lbAuthor, "lbAuthor");
            this.lbAuthor.Name = "lbAuthor";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label4
            // 
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label4, "label4");
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Name = "label4";
            // 
            // label3
            // 
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            resources.ApplyResources(this.label3, "label3");
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Name = "label3";
            // 
            // splitContainer
            // 
            this.splitContainer.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.splitContainer.Panel1.Controls.Add(this.dtpEndDate);
            this.splitContainer.Panel1.Controls.Add(this.lbEndDate);
            this.splitContainer.Panel1.Controls.Add(this.dtpFromDate);
            this.splitContainer.Panel1.Controls.Add(this.lbFromDate);
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
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpEndDate, "dtpEndDate");
            this.dtpEndDate.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.ValueChanged += new System.EventHandler(this.dtpEndDate_ValueChanged);
            // 
            // lbEndDate
            // 
            resources.ApplyResources(this.lbEndDate, "lbEndDate");
            this.lbEndDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbEndDate.Name = "lbEndDate";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dtpFromDate, "dtpFromDate");
            this.dtpFromDate.MinDate = new System.DateTime(2016, 1, 1, 0, 0, 0, 0);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Value = new System.DateTime(2017, 12, 18, 0, 0, 0, 0);
            this.dtpFromDate.ValueChanged += new System.EventHandler(this.dtpFromDate_ValueChanged);
            // 
            // lbFromDate
            // 
            resources.ApplyResources(this.lbFromDate, "lbFromDate");
            this.lbFromDate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbFromDate.Name = "lbFromDate";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnTransaction
            // 
            this.btnTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnTransaction, "btnTransaction");
            this.btnTransaction.ForeColor = System.Drawing.Color.White;
            this.btnTransaction.Name = "btnTransaction";
            this.btnTransaction.UseVisualStyleBackColor = false;
            this.btnTransaction.Click += new System.EventHandler(this.btnTransaction_Click);
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
            resources.ApplyResources(this.OrderNo, "OrderNo");
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            this.OrderNo.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            resources.ApplyResources(this.Purchaser, "Purchaser");
            this.Purchaser.Name = "Purchaser";
            this.Purchaser.ReadOnly = true;
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
            resources.ApplyResources(this.SellingPrice, "SellingPrice");
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
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
            resources.ApplyResources(this.PurchasePrice, "PurchasePrice");
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
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
            resources.ApplyResources(this.Profit, "Profit");
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
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
            resources.ApplyResources(this.CreateTime, "CreateTime");
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // OrderManagementTool
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Application;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(181)))), ((int)(((byte)(211)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.splitContainer);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderManagementTool";
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
        private System.Windows.Forms.Button btnTransaction;
        private System.Windows.Forms.Label lbFromDate;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.Label lbEndDate;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
    }
}

