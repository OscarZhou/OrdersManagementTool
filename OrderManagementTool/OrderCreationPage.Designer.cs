namespace OrderManagementTool
{
    partial class OrderCreationPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderCreationPage));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbFromPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbItemDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbQuantity = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvItemList = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbToPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.tbOrderContent = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.lbItemError = new System.Windows.Forms.Label();
            this.lbUserError = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbPurchaser = new System.Windows.Forms.TextBox();
            this.chkLock = new System.Windows.Forms.CheckBox();
            this.btnTxtFile = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.tbTotalPrice = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbIdentityCard = new System.Windows.Forms.TextBox();
            this.btnPriceKit = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "From:";
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(133, 36);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(128, 28);
            this.tbFrom.TabIndex = 10;
            this.tbFrom.Text = "Oscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Phone:";
            // 
            // tbFromPhone
            // 
            this.tbFromPhone.Location = new System.Drawing.Point(385, 36);
            this.tbFromPhone.Name = "tbFromPhone";
            this.tbFromPhone.Size = new System.Drawing.Size(128, 28);
            this.tbFromPhone.TabIndex = 11;
            this.tbFromPhone.Text = "0211376664";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(23, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1124, 1);
            this.label3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Product Name:";
            // 
            // tbItemDescription
            // 
            this.tbItemDescription.BackColor = System.Drawing.SystemColors.Window;
            this.tbItemDescription.Location = new System.Drawing.Point(205, 108);
            this.tbItemDescription.Name = "tbItemDescription";
            this.tbItemDescription.Size = new System.Drawing.Size(818, 28);
            this.tbItemDescription.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(73, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Quantity:";
            // 
            // tbQuantity
            // 
            this.tbQuantity.Location = new System.Drawing.Point(168, 157);
            this.tbQuantity.Name = "tbQuantity";
            this.tbQuantity.Size = new System.Drawing.Size(128, 28);
            this.tbQuantity.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(323, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Price:";
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(402, 157);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(128, 28);
            this.tbPrice.TabIndex = 3;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(948, 157);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(85, 33);
            this.btnAddItem.TabIndex = 7;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(23, 446);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(1124, 1);
            this.label7.TabIndex = 4;
            // 
            // dgvItemList
            // 
            this.dgvItemList.AllowUserToAddRows = false;
            this.dgvItemList.AllowUserToDeleteRows = false;
            this.dgvItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemDescription,
            this.ItemNo,
            this.Quantity,
            this.UnitPrice});
            this.dgvItemList.Location = new System.Drawing.Point(76, 202);
            this.dgvItemList.Name = "dgvItemList";
            this.dgvItemList.ReadOnly = true;
            this.dgvItemList.RowTemplate.Height = 30;
            this.dgvItemList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvItemList.Size = new System.Drawing.Size(1015, 228);
            this.dgvItemList.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(73, 478);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "To:";
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(133, 473);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(128, 28);
            this.tbTo.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(306, 478);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 18);
            this.label9.TabIndex = 0;
            this.label9.Text = "Phone:";
            // 
            // tbToPhone
            // 
            this.tbToPhone.Location = new System.Drawing.Point(385, 473);
            this.tbToPhone.Name = "tbToPhone";
            this.tbToPhone.Size = new System.Drawing.Size(128, 28);
            this.tbToPhone.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(74, 576);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Address:";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(167, 573);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(735, 28);
            this.tbAddress.TabIndex = 6;
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(991, 517);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(133, 35);
            this.btnAddOrder.TabIndex = 8;
            this.btnAddOrder.Text = "Place Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // label11
            // 
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(1162, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1, 590);
            this.label11.TabIndex = 6;
            this.label11.Text = "label11";
            // 
            // tbOrderContent
            // 
            this.tbOrderContent.Enabled = false;
            this.tbOrderContent.Location = new System.Drawing.Point(1193, 41);
            this.tbOrderContent.Multiline = true;
            this.tbOrderContent.Name = "tbOrderContent";
            this.tbOrderContent.Size = new System.Drawing.Size(430, 443);
            this.tbOrderContent.TabIndex = 7;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(1193, 515);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(183, 35);
            this.btnCopy.TabIndex = 9;
            this.btnCopy.Text = "Copy To Clipboard";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // lbItemError
            // 
            this.lbItemError.AutoSize = true;
            this.lbItemError.Location = new System.Drawing.Point(582, 163);
            this.lbItemError.Name = "lbItemError";
            this.lbItemError.Size = new System.Drawing.Size(71, 18);
            this.lbItemError.TabIndex = 12;
            this.lbItemError.Text = "label12";
            // 
            // lbUserError
            // 
            this.lbUserError.AutoSize = true;
            this.lbUserError.Location = new System.Drawing.Point(563, 476);
            this.lbUserError.Name = "lbUserError";
            this.lbUserError.Size = new System.Drawing.Size(71, 18);
            this.lbUserError.TabIndex = 12;
            this.lbUserError.Text = "label12";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(778, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 18);
            this.label12.TabIndex = 0;
            this.label12.Text = "Purchaser Name:";
            // 
            // tbPurchaser
            // 
            this.tbPurchaser.Location = new System.Drawing.Point(928, 38);
            this.tbPurchaser.Name = "tbPurchaser";
            this.tbPurchaser.Size = new System.Drawing.Size(142, 28);
            this.tbPurchaser.TabIndex = 0;
            // 
            // chkLock
            // 
            this.chkLock.AutoSize = true;
            this.chkLock.Checked = true;
            this.chkLock.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkLock.Location = new System.Drawing.Point(547, 38);
            this.chkLock.Name = "chkLock";
            this.chkLock.Size = new System.Drawing.Size(88, 22);
            this.chkLock.TabIndex = 13;
            this.chkLock.Text = "Unlock";
            this.chkLock.UseVisualStyleBackColor = true;
            this.chkLock.CheckedChanged += new System.EventHandler(this.chkLock_CheckedChanged);
            // 
            // btnTxtFile
            // 
            this.btnTxtFile.Location = new System.Drawing.Point(1399, 515);
            this.btnTxtFile.Name = "btnTxtFile";
            this.btnTxtFile.Size = new System.Drawing.Size(183, 35);
            this.btnTxtFile.TabIndex = 10;
            this.btnTxtFile.Text = "Generate .txt File";
            this.btnTxtFile.UseVisualStyleBackColor = true;
            this.btnTxtFile.Click += new System.EventHandler(this.btnTxtFile_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(916, 473);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(107, 18);
            this.label13.TabIndex = 0;
            this.label13.Text = "TotalPrice:";
            // 
            // tbTotalPrice
            // 
            this.tbTotalPrice.Enabled = false;
            this.tbTotalPrice.Location = new System.Drawing.Point(1029, 470);
            this.tbTotalPrice.Name = "tbTotalPrice";
            this.tbTotalPrice.Size = new System.Drawing.Size(93, 28);
            this.tbTotalPrice.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(75, 525);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(134, 18);
            this.label14.TabIndex = 0;
            this.label14.Text = "Identity Card:";
            // 
            // tbIdentityCard
            // 
            this.tbIdentityCard.Location = new System.Drawing.Point(215, 522);
            this.tbIdentityCard.Name = "tbIdentityCard";
            this.tbIdentityCard.Size = new System.Drawing.Size(315, 28);
            this.tbIdentityCard.TabIndex = 6;
            // 
            // btnPriceKit
            // 
            this.btnPriceKit.Location = new System.Drawing.Point(991, 568);
            this.btnPriceKit.Name = "btnPriceKit";
            this.btnPriceKit.Size = new System.Drawing.Size(133, 35);
            this.btnPriceKit.TabIndex = 8;
            this.btnPriceKit.Text = "Price Kit";
            this.btnPriceKit.UseVisualStyleBackColor = true;
            this.btnPriceKit.Click += new System.EventHandler(this.btnPriceKit_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(1054, 157);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(85, 33);
            this.btnDeleteItem.TabIndex = 7;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDescription.DataPropertyName = "ItemDescription";
            this.ItemDescription.HeaderText = "Product Name";
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            // 
            // ItemNo
            // 
            this.ItemNo.DataPropertyName = "ItemNo";
            this.ItemNo.HeaderText = "Item No";
            this.ItemNo.Name = "ItemNo";
            this.ItemNo.ReadOnly = true;
            this.ItemNo.Visible = false;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Quantity.DataPropertyName = "Quantity";
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 116;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            this.UnitPrice.HeaderText = "Price";
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Width = 89;
            // 
            // OrderCreationPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1659, 643);
            this.Controls.Add(this.chkLock);
            this.Controls.Add(this.lbUserError);
            this.Controls.Add(this.lbItemError);
            this.Controls.Add(this.btnTxtFile);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.tbOrderContent);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dgvItemList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnPriceKit);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbToPhone);
            this.Controls.Add(this.tbPurchaser);
            this.Controls.Add(this.tbFromPhone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbIdentityCard);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tbItemDescription);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbQuantity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbTo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTotalPrice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrderCreationPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creating Order";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OrderCreationPage_KeyDown);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbItemDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbQuantity;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvItemList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbToPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbOrderContent;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label lbItemError;
        private System.Windows.Forms.Label lbUserError;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbPurchaser;
        private System.Windows.Forms.CheckBox chkLock;
        private System.Windows.Forms.Button btnTxtFile;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbTotalPrice;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbIdentityCard;
        private System.Windows.Forms.Button btnPriceKit;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;

    }
}