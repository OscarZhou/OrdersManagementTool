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
            this.btnExportTransaction = new System.Windows.Forms.Button();
            this.BtnEdit = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).BeginInit();
            this.SuspendLayout();
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(36, 28);
            this.tbSearch.MaxLength = 20;
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(206, 28);
            this.tbSearch.TabIndex = 0;
            this.tbSearch.Text = "Input Name";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(267, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 39);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnOpenDataImporter
            // 
            this.btnOpenDataImporter.Location = new System.Drawing.Point(36, 699);
            this.btnOpenDataImporter.Name = "btnOpenDataImporter";
            this.btnOpenDataImporter.Size = new System.Drawing.Size(138, 43);
            this.btnOpenDataImporter.TabIndex = 4;
            this.btnOpenDataImporter.Text = "Data Import";
            this.btnOpenDataImporter.UseVisualStyleBackColor = true;
            this.btnOpenDataImporter.Click += new System.EventHandler(this.btnOpenDataImporter_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(1220, 82);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(139, 42);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = "CreateOrder";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // lbTotalProfit
            // 
            this.lbTotalProfit.AutoSize = true;
            this.lbTotalProfit.Location = new System.Drawing.Point(800, 711);
            this.lbTotalProfit.Name = "lbTotalProfit";
            this.lbTotalProfit.Size = new System.Drawing.Size(179, 18);
            this.lbTotalProfit.TabIndex = 7;
            this.lbTotalProfit.Text = "The total profit is";
            // 
            // dgvTransaction
            // 
            this.dgvTransaction.AllowUserToAddRows = false;
            this.dgvTransaction.AllowUserToDeleteRows = false;
            this.dgvTransaction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTransaction.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNo,
            this.Purchaser,
            this.SellingPrice,
            this.PurchasePrice,
            this.Profit,
            this.CreateTime});
            this.dgvTransaction.Location = new System.Drawing.Point(36, 82);
            this.dgvTransaction.Name = "dgvTransaction";
            this.dgvTransaction.ReadOnly = true;
            this.dgvTransaction.RowTemplate.Height = 30;
            this.dgvTransaction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTransaction.Size = new System.Drawing.Size(1160, 591);
            this.dgvTransaction.TabIndex = 6;
            // 
            // OrderNo
            // 
            this.OrderNo.DataPropertyName = "OrderNo";
            this.OrderNo.FillWeight = 30F;
            this.OrderNo.HeaderText = "Order No";
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            // 
            // Purchaser
            // 
            this.Purchaser.DataPropertyName = "Purchaser";
            this.Purchaser.FillWeight = 35.51238F;
            this.Purchaser.HeaderText = "Purchaser Name";
            this.Purchaser.Name = "Purchaser";
            this.Purchaser.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.FillWeight = 35.51238F;
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.FillWeight = 35.51238F;
            this.PurchasePrice.HeaderText = "Purchasing Price";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            this.Profit.FillWeight = 42.0718F;
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.FillWeight = 42.0718F;
            this.CreateTime.HeaderText = "Date";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // btnUndoneOrders
            // 
            this.btnUndoneOrders.Location = new System.Drawing.Point(1220, 137);
            this.btnUndoneOrders.Name = "btnUndoneOrders";
            this.btnUndoneOrders.Size = new System.Drawing.Size(139, 42);
            this.btnUndoneOrders.TabIndex = 2;
            this.btnUndoneOrders.Text = "Undone Orders";
            this.btnUndoneOrders.UseVisualStyleBackColor = true;
            this.btnUndoneOrders.Click += new System.EventHandler(this.btnUndoneOrders_Click);
            // 
            // btnDataAnalysis
            // 
            this.btnDataAnalysis.Location = new System.Drawing.Point(387, 700);
            this.btnDataAnalysis.Name = "btnDataAnalysis";
            this.btnDataAnalysis.Size = new System.Drawing.Size(178, 43);
            this.btnDataAnalysis.TabIndex = 5;
            this.btnDataAnalysis.Text = "Data Analysis";
            this.btnDataAnalysis.UseVisualStyleBackColor = true;
            // 
            // cmbSorting
            // 
            this.cmbSorting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSorting.FormattingEnabled = true;
            this.cmbSorting.Location = new System.Drawing.Point(481, 29);
            this.cmbSorting.Name = "cmbSorting";
            this.cmbSorting.Size = new System.Drawing.Size(164, 26);
            this.cmbSorting.TabIndex = 8;
            this.cmbSorting.SelectedIndexChanged += new System.EventHandler(this.cmbSorting_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(389, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Sorting:";
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(1220, 196);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(139, 42);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View Order";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnExportTransaction
            // 
            this.btnExportTransaction.Location = new System.Drawing.Point(180, 700);
            this.btnExportTransaction.Name = "btnExportTransaction";
            this.btnExportTransaction.Size = new System.Drawing.Size(201, 42);
            this.btnExportTransaction.TabIndex = 2;
            this.btnExportTransaction.Text = "Transaction Export";
            this.btnExportTransaction.UseVisualStyleBackColor = true;
            this.btnExportTransaction.Click += new System.EventHandler(this.btnExportTransaction_Click);
            // 
            // BtnEdit
            // 
            this.BtnEdit.Location = new System.Drawing.Point(1220, 255);
            this.BtnEdit.Name = "BtnEdit";
            this.BtnEdit.Size = new System.Drawing.Size(139, 42);
            this.BtnEdit.TabIndex = 2;
            this.BtnEdit.Text = "Edit Order";
            this.BtnEdit.UseVisualStyleBackColor = true;
            this.BtnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(1220, 314);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(139, 42);
            this.btnDeleteOrder.TabIndex = 2;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // OrderManagementTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1371, 766);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSorting);
            this.Controls.Add(this.lbTotalProfit);
            this.Controls.Add(this.dgvTransaction);
            this.Controls.Add(this.btnExportTransaction);
            this.Controls.Add(this.btnDeleteOrder);
            this.Controls.Add(this.BtnEdit);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnUndoneOrders);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnDataAnalysis);
            this.Controls.Add(this.btnOpenDataImporter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderManagementTool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Management Tool";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransaction)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnOpenDataImporter;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label lbTotalProfit;
        private System.Windows.Forms.DataGridView dgvTransaction;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn SellingPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.Button btnUndoneOrders;
        private System.Windows.Forms.Button btnDataAnalysis;
        private System.Windows.Forms.ComboBox cmbSorting;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnExportTransaction;
        private System.Windows.Forms.Button BtnEdit;
        private System.Windows.Forms.Button btnDeleteOrder;
    }
}

