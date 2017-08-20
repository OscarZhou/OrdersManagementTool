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
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(36, 225);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Price($NZ)";
            // 
            // tbNZPrice
            // 
            this.tbNZPrice.Location = new System.Drawing.Point(39, 261);
            this.tbNZPrice.Multiline = true;
            this.tbNZPrice.Name = "tbNZPrice";
            this.tbNZPrice.Size = new System.Drawing.Size(118, 28);
            this.tbNZPrice.TabIndex = 1;
            this.tbNZPrice.Leave += new System.EventHandler(this.tbNZPrice_Leave);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(214, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "ER";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(164, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 31);
            this.label3.TabIndex = 0;
            this.label3.Text = "x";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(367, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 31);
            this.label4.TabIndex = 0;
            this.label4.Text = "PM";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(305, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 31);
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
            this.cboExchangeRate.Location = new System.Drawing.Point(194, 258);
            this.cboExchangeRate.Name = "cboExchangeRate";
            this.cboExchangeRate.Size = new System.Drawing.Size(97, 26);
            this.cboExchangeRate.TabIndex = 3;
            this.cboExchangeRate.SelectionChangeCommitted += new System.EventHandler(this.cboExchangeRate_SelectionChangeCommitted);
            // 
            // cboProfitMargin
            // 
            this.cboProfitMargin.FormattingEnabled = true;
            this.cboProfitMargin.Items.AddRange(new object[] {
            "1.1",
            "1.2",
            "1.3",
            "1.4",
            "1.5"});
            this.cboProfitMargin.Location = new System.Drawing.Point(338, 258);
            this.cboProfitMargin.Name = "cboProfitMargin";
            this.cboProfitMargin.Size = new System.Drawing.Size(98, 26);
            this.cboProfitMargin.TabIndex = 4;
            this.cboProfitMargin.SelectionChangeCommitted += new System.EventHandler(this.cboProfitMargin_SelectionChangeCommitted);
            // 
            // lbResult
            // 
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbResult.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbResult.Location = new System.Drawing.Point(491, 257);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(104, 31);
            this.lbResult.TabIndex = 0;
            this.lbResult.Text = "0";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(448, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 31);
            this.label7.TabIndex = 0;
            this.label7.Text = "=";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(459, 225);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 31);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price(￥RMB)";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnReset.Location = new System.Drawing.Point(224, 12);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(104, 40);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.Location = new System.Drawing.Point(336, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 40);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(230, 336);
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
            this.dgvPriceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPriceHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Opt,
            this.UnitPrice,
            this.ItemDescription,
            this.CreateTime});
            this.dgvPriceHistory.Location = new System.Drawing.Point(20, 357);
            this.dgvPriceHistory.Name = "dgvPriceHistory";
            this.dgvPriceHistory.RowTemplate.Height = 30;
            this.dgvPriceHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPriceHistory.Size = new System.Drawing.Size(610, 189);
            this.dgvPriceHistory.TabIndex = 7;
            this.dgvPriceHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPriceHistory_CellClick);
            // 
            // Opt
            // 
            this.Opt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Opt.HeaderText = "Opt.";
            this.Opt.Name = "Opt";
            this.Opt.Width = 50;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.UnitPrice.Width = 59;
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDescription.DataPropertyName = "ItemDescription";
            this.ItemDescription.HeaderText = "Item";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            this.ItemDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ItemDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.HeaderText = "Date";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CreateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CreateTime.Width = 50;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(34, 336);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Price History";
            // 
            // btnClearPrice
            // 
            this.btnClearPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnClearPrice.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnClearPrice.Location = new System.Drawing.Point(90, 12);
            this.btnClearPrice.Name = "btnClearPrice";
            this.btnClearPrice.Size = new System.Drawing.Size(126, 40);
            this.btnClearPrice.TabIndex = 5;
            this.btnClearPrice.Text = "Clear Price";
            this.btnClearPrice.UseVisualStyleBackColor = false;
            this.btnClearPrice.Click += new System.EventHandler(this.btnClearPrice_Click);
            // 
            // btnImportToOrder
            // 
            this.btnImportToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnImportToOrder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImportToOrder.Location = new System.Drawing.Point(446, 12);
            this.btnImportToOrder.Name = "btnImportToOrder";
            this.btnImportToOrder.Size = new System.Drawing.Size(174, 40);
            this.btnImportToOrder.TabIndex = 5;
            this.btnImportToOrder.Text = "Move To Order";
            this.btnImportToOrder.UseVisualStyleBackColor = false;
            this.btnImportToOrder.Click += new System.EventHandler(this.btnImportToOrder_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(50, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "Item:";
            // 
            // tbItem
            // 
            this.tbItem.Location = new System.Drawing.Point(110, 151);
            this.tbItem.Multiline = true;
            this.tbItem.Name = "tbItem";
            this.tbItem.Size = new System.Drawing.Size(520, 28);
            this.tbItem.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(35, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(462, 2);
            this.label11.TabIndex = 11;
            this.label11.Text = "label11";
            // 
            // CalculatePriceKitPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(658, 660);
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn Opt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbItem;
        private System.Windows.Forms.Label label11;
    }
}