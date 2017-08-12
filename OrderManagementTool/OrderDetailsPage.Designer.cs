namespace OrderManagementTool
{
    partial class OrderDetailsPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderDetailsPage));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFromPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPurchaser = new System.Windows.Forms.TextBox();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbToPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbOrderNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbSellingPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPurchasePrice = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbCardNo = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.btnEditItem = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tbProfit = new System.Windows.Forms.TextBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(538, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "发件人：";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(624, 23);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(122, 28);
            this.tbFrom.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(790, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "电话：";
            // 
            // tbFromPhone
            // 
            this.tbFromPhone.Location = new System.Drawing.Point(868, 23);
            this.tbFromPhone.Name = "tbFromPhone";
            this.tbFromPhone.Size = new System.Drawing.Size(122, 28);
            this.tbFromPhone.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "下单人：";
            // 
            // tbPurchaser
            // 
            this.tbPurchaser.Location = new System.Drawing.Point(387, 23);
            this.tbPurchaser.Name = "tbPurchaser";
            this.tbPurchaser.Size = new System.Drawing.Size(122, 28);
            this.tbPurchaser.TabIndex = 0;
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemDescription,
            this.Quantity,
            this.UnitPrice,
            this.TotalPrice,
            this.ItemNo});
            this.dgvItemList.Location = new System.Drawing.Point(72, 175);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowTemplate.Height = 30;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(957, 381);
            this.dgvItemList.TabIndex = 2;
            this.dgvItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemList_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(86, 588);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "收件人：";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(172, 583);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(122, 28);
            this.tbTo.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 588);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "电话：";
            // 
            // tbToPhone
            // 
            this.tbToPhone.Location = new System.Drawing.Point(416, 583);
            this.tbToPhone.Name = "tbToPhone";
            this.tbToPhone.Size = new System.Drawing.Size(122, 28);
            this.tbToPhone.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(86, 636);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "地址：";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(172, 631);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(818, 28);
            this.tbAddress.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "订单号：";
            // 
            // tbOrderNo
            // 
            this.tbOrderNo.Enabled = false;
            this.tbOrderNo.Location = new System.Drawing.Point(141, 25);
            this.tbOrderNo.Name = "tbOrderNo";
            this.tbOrderNo.Size = new System.Drawing.Size(122, 28);
            this.tbOrderNo.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(86, 691);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "收款：";
            // 
            // tbSellingPrice
            // 
            this.tbSellingPrice.Location = new System.Drawing.Point(172, 686);
            this.tbSellingPrice.Name = "tbSellingPrice";
            this.tbSellingPrice.Size = new System.Drawing.Size(122, 28);
            this.tbSellingPrice.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 691);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "付款：";
            // 
            // tbPurchasePrice
            // 
            this.tbPurchasePrice.Location = new System.Drawing.Point(416, 686);
            this.tbPurchasePrice.Name = "tbPurchasePrice";
            this.tbPurchasePrice.Size = new System.Drawing.Size(122, 28);
            this.tbPurchasePrice.TabIndex = 11;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(836, 681);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(204, 38);
            this.btnModify.TabIndex = 13;
            this.btnModify.Text = "Confirm Modification";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(569, 588);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(98, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "身份证号：";
            // 
            // tbCardNo
            // 
            this.tbCardNo.Location = new System.Drawing.Point(665, 583);
            this.tbCardNo.Name = "tbCardNo";
            this.tbCardNo.Size = new System.Drawing.Size(258, 28);
            this.tbCardNo.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(55, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 18);
            this.label11.TabIndex = 0;
            this.label11.Text = "数量：";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(141, 122);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(122, 28);
            this.tbQuantity.TabIndex = 4;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(301, 125);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "价格：";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(384, 120);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(122, 28);
            this.tbPrice.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(55, 80);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "产品名称：";
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(159, 75);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(831, 28);
            this.tbProductName.TabIndex = 3;
            // 
            // btnEditItem
            // 
            this.btnEditItem.Location = new System.Drawing.Point(892, 117);
            this.btnEditItem.Name = "btnEditItem";
            this.btnEditItem.Size = new System.Drawing.Size(126, 38);
            this.btnEditItem.TabIndex = 12;
            this.btnEditItem.Text = "Edit Item";
            this.btnEditItem.UseVisualStyleBackColor = true;
            this.btnEditItem.Click += new System.EventHandler(this.btnEditItem_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(538, 130);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(71, 18);
            this.lbError.TabIndex = 11;
            this.lbError.Text = "label14";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(586, 691);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "利润：";
            // 
            // tbProfit
            // 
            this.tbProfit.Enabled = false;
            this.tbProfit.Location = new System.Drawing.Point(664, 686);
            this.tbProfit.Name = "tbProfit";
            this.tbProfit.Size = new System.Drawing.Size(122, 28);
            this.tbProfit.TabIndex = 8;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(824, 681);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(149, 38);
            this.btnCreateOrder.TabIndex = 14;
            this.btnCreateOrder.Text = "CreateOrder";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            this.btnCreateOrder.Click += new System.EventHandler(this.btnCreateOrder_Click);
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDescription.DataPropertyName = "ItemDescription";
            this.ItemDescription.HeaderText = "Product Name";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 116;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Unit Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 134;
            // 
            // TotalPrice
            // 
            this.TotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TotalPrice.DataPropertyName = "TotalPrice";
            this.TotalPrice.HeaderText = "Product Total Price";
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.ReadOnly = true;
            this.TotalPrice.Width = 156;
            // 
            // ItemNo
            // 
            this.ItemNo.DataPropertyName = "ItemNo";
            this.ItemNo.HeaderText = "Item No";
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.ReadOnly = true;
            this.ItemNo.Visible = false;
            // 
            // OrderDetailsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 761);
            this.Controls.Add(this.btnCreateOrder);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnEditItem);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.tbProfit);
            this.Controls.Add(this.tbPurchasePrice);
            this.Controls.Add(this.tbCardNo);
            this.Controls.Add(this.tbToPhone);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbFromPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.tbPurchaser);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbSellingPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.tbProductName);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbOrderNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderDetailsPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Detail";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderDetailsPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbFromPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPurchaser;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbToPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbOrderNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbSellingPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPurchasePrice;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbCardNo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.Button btnEditItem;
        private System.Windows.Forms.Label lbError;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbProfit;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
    }
}