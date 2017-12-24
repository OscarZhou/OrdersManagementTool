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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvUndoneOrders = new System.Windows.Forms.DataGridView();
            this.OrderNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SellingPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCompleteOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUndoneOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // dgvUndoneOrders
            // 
            this.dgvUndoneOrders.AllowUserToAddRows = false;
            this.dgvUndoneOrders.AllowUserToDeleteRows = false;
            this.dgvUndoneOrders.AllowUserToResizeColumns = false;
            this.dgvUndoneOrders.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.PapayaWhip;
            this.dgvUndoneOrders.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUndoneOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUndoneOrders.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.dgvUndoneOrders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUndoneOrders.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUndoneOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUndoneOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUndoneOrders.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrderNo,
            this.Purchaser,
            this.SellingPrice,
            this.PurchasePrice,
            this.Profit,
            this.CreateTime});
            resources.ApplyResources(this.dgvUndoneOrders, "dgvUndoneOrders");
            this.dgvUndoneOrders.MultiSelect = false;
            this.dgvUndoneOrders.Name = "dgvUndoneOrders";
            this.dgvUndoneOrders.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Format = "SimSun, 9pt";
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUndoneOrders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUndoneOrders.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvUndoneOrders.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvUndoneOrders.RowTemplate.Height = 30;
            this.dgvUndoneOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUndoneOrders.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUndoneOrders_CellDoubleClick);
            // 
            // OrderNo
            // 
            this.OrderNo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.OrderNo.DataPropertyName = "OrderNo";
            this.OrderNo.FillWeight = 30F;
            resources.ApplyResources(this.OrderNo, "OrderNo");
            this.OrderNo.Name = "OrderNo";
            this.OrderNo.ReadOnly = true;
            // 
            // Purchaser
            // 
            this.Purchaser.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Purchaser.DataPropertyName = "Purchaser";
            this.Purchaser.FillWeight = 30F;
            resources.ApplyResources(this.Purchaser, "Purchaser");
            this.Purchaser.Name = "Purchaser";
            this.Purchaser.ReadOnly = true;
            // 
            // SellingPrice
            // 
            this.SellingPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.SellingPrice.DataPropertyName = "SellingPrice";
            this.SellingPrice.FillWeight = 30F;
            resources.ApplyResources(this.SellingPrice, "SellingPrice");
            this.SellingPrice.Name = "SellingPrice";
            this.SellingPrice.ReadOnly = true;
            // 
            // PurchasePrice
            // 
            this.PurchasePrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.PurchasePrice.DataPropertyName = "PurchasePrice";
            this.PurchasePrice.FillWeight = 30F;
            resources.ApplyResources(this.PurchasePrice, "PurchasePrice");
            this.PurchasePrice.Name = "PurchasePrice";
            this.PurchasePrice.ReadOnly = true;
            // 
            // Profit
            // 
            this.Profit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Profit.DataPropertyName = "Profit";
            this.Profit.FillWeight = 30F;
            resources.ApplyResources(this.Profit, "Profit");
            this.Profit.Name = "Profit";
            this.Profit.ReadOnly = true;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CreateTime.DataPropertyName = "CreateTime";
            this.CreateTime.FillWeight = 30F;
            resources.ApplyResources(this.CreateTime, "CreateTime");
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            // 
            // btnCompleteOrder
            // 
            this.btnCompleteOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnCompleteOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnCompleteOrder, "btnCompleteOrder");
            this.btnCompleteOrder.Name = "btnCompleteOrder";
            this.btnCompleteOrder.UseVisualStyleBackColor = false;
            this.btnCompleteOrder.Click += new System.EventHandler(this.btnCompleteOrder_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // UndoneOrdersPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.dgvUndoneOrders);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnCompleteOrder);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UndoneOrdersPage";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.UndoneOrdersPage_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUndoneOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button btnCompleteOrder;
        private Label label6;
        private DataGridView dgvUndoneOrders;
        private DataGridViewTextBoxColumn OrderNo;
        private DataGridViewTextBoxColumn Purchaser;
        private DataGridViewTextBoxColumn SellingPrice;
        private DataGridViewTextBoxColumn PurchasePrice;
        private DataGridViewTextBoxColumn Profit;
        private DataGridViewTextBoxColumn CreateTime;
    }
}