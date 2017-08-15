using System.ComponentModel;
using System.Windows.Forms;

namespace OrderManagementTool
{
    partial class UndoneOrdersPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UndoneOrdersPage));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvUndoneOrders = new System.Windows.Forms.DataGridView();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUndoneOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Undone Orders:";
            // 
            // dgvUndoneOrders
            // 
            this.dgvUndoneOrders.AllowUserToAddRows = false;
            this.dgvUndoneOrders.AllowUserToDeleteRows = false;
            this.dgvUndoneOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUndoneOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUndoneOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNo,
            this.Purchaser,
            this.SellingPrice,
            this.PurchasePrice,
            this.Profit,
            this.CreateTime});
            this.dgvUndoneOrders.Location = new System.Drawing.Point(32, 56);
            this.dgvUndoneOrders.Name = "dgvUndoneOrders";
            this.dgvUndoneOrders.ReadOnly = true;
            this.dgvUndoneOrders.RowTemplate.Height = 30;
            this.dgvUndoneOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUndoneOrders.Size = new System.Drawing.Size(869, 341);
            this.dgvUndoneOrders.TabIndex = 1;
            this.dgvUndoneOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUndoneOrders_CellDoubleClick);
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
            this.Purchaser.FillWeight = 30F;
            this.Purchaser.HeaderText = "Purchaser Name";
            this.Purchaser.Name = "Purchaser";
            this.Purchaser.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.FillWeight = 30F;
            this.SellingPrice.HeaderText = "Selling Price";
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.FillWeight = 30F;
            this.PurchasePrice.HeaderText = "Purchasing Price";
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.DataPropertyName = "Profit";
            this.Profit.FillWeight = 30F;
            this.Profit.HeaderText = "Profit";
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.FillWeight = 30F;
            this.CreateTime.HeaderText = "Date";
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.Location = new System.Drawing.Point(754, 423);
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.Size = new System.Drawing.Size(147, 44);
            this.btnCompleteOrder.TabIndex = 2;
            this.btnCompleteOrder.Text = "Complete Order";
            this.btnCompleteOrder.UseVisualStyleBackColor = true;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // UndoneOrdersPage
            // 
            this.ClientSize = new System.Drawing.Size(943, 489);
            this.Controls.Add(this.btnCompleteOrder);
            this.Controls.Add(this.dgvUndoneOrders);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UndoneOrdersPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Undone Orders";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UndoneOrdersPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUndoneOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvUndoneOrders;
        private Button btnCompleteOrder;
        private DataGridViewTextBoxColumn OrderNo;
        private DataGridViewTextBoxColumn Purchaser;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewTextBoxColumn PurchasePrice;
        private DataGridViewTextBoxColumn Profit;
        private DataGridViewTextBoxColumn CreateTime;
    }
}