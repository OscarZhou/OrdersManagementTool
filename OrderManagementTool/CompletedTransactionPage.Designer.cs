namespace OrderManagementTool
{
    partial class CompletedTransactionPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CompletedTransactionPage));
            this.label1 = new System.Windows.Forms.Label();
            this.tbOrderNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPurchaser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbSellingPrice = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPurchasingPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbProfit = new System.Windows.Forms.TextBox();
            this.btnOkay = new System.Windows.Forms.Button();
            this.lbError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Order No.:";
            // 
            // tbOrderNo
            // 
            this.tbOrderNo.Enabled = false;
            this.tbOrderNo.Location = new System.Drawing.Point(175, 49);
            this.tbOrderNo.Name = "tbOrderNo";
            this.tbOrderNo.Size = new System.Drawing.Size(158, 28);
            this.tbOrderNo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Purchaser:";
            // 
            // tbPurchaser
            // 
            this.tbPurchaser.Enabled = false;
            this.tbPurchaser.Location = new System.Drawing.Point(175, 98);
            this.tbPurchaser.Name = "tbPurchaser";
            this.tbPurchaser.Size = new System.Drawing.Size(158, 28);
            this.tbPurchaser.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "Selling Price:";
            // 
            // tbSellingPrice
            // 
            this.tbSellingPrice.Location = new System.Drawing.Point(248, 149);
            this.tbSellingPrice.Name = "tbSellingPrice";
            this.tbSellingPrice.Size = new System.Drawing.Size(158, 28);
            this.tbSellingPrice.TabIndex = 0;
            this.tbSellingPrice.Leave += new System.EventHandler(this.tbSellingPrice_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 18);
            this.label4.TabIndex = 9;
            this.label4.Text = "Purchasing Price:";
            // 
            // tbPurchasingPrice
            // 
            this.tbPurchasingPrice.Location = new System.Drawing.Point(248, 201);
            this.tbPurchasingPrice.Name = "tbPurchasingPrice";
            this.tbPurchasingPrice.Size = new System.Drawing.Size(158, 28);
            this.tbPurchasingPrice.TabIndex = 1;
            this.tbPurchasingPrice.Leave += new System.EventHandler(this.tbPurchasingPrice_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Profit:";
            // 
            // tbProfit
            // 
            this.tbProfit.Enabled = false;
            this.tbProfit.Location = new System.Drawing.Point(176, 255);
            this.tbProfit.Name = "tbProfit";
            this.tbProfit.Size = new System.Drawing.Size(158, 28);
            this.tbProfit.TabIndex = 4;
            // 
            // btnOkay
            // 
            this.btnOkay.Location = new System.Drawing.Point(145, 350);
            this.btnOkay.Name = "btnOkay";
            this.btnOkay.Size = new System.Drawing.Size(86, 31);
            this.btnOkay.TabIndex = 5;
            this.btnOkay.Text = "Okay";
            this.btnOkay.UseVisualStyleBackColor = true;
            this.btnOkay.Click += new System.EventHandler(this.btnOkay_Click);
            // 
            // lbError
            // 
            this.lbError.AutoSize = true;
            this.lbError.Location = new System.Drawing.Point(70, 311);
            this.lbError.Name = "lbError";
            this.lbError.Size = new System.Drawing.Size(62, 18);
            this.lbError.TabIndex = 11;
            this.lbError.Text = "label6";
            // 
            // CompletedTransactionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 413);
            this.Controls.Add(this.lbError);
            this.Controls.Add(this.btnOkay);
            this.Controls.Add(this.tbProfit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbPurchasingPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbSellingPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPurchaser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbOrderNo);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CompletedTransactionPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Completed Transaction";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CompletedTransactionPage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOrderNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPurchaser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbSellingPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPurchasingPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbProfit;
        private System.Windows.Forms.Button btnOkay;
        private System.Windows.Forms.Label lbError;
    }
}