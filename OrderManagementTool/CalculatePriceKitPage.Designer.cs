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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Opt = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.UnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CreateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPriceHistory)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // tbNZPrice
            // 
            resources.ApplyResources(this.tbNZPrice, "tbNZPrice");
            this.tbNZPrice.Name = "tbNZPrice";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // cboExchangeRate
            // 
            this.cboExchangeRate.FormattingEnabled = true;
            this.cboExchangeRate.Items.AddRange(new object[] {
            resources.GetString("cboExchangeRate.Items"),
            resources.GetString("cboExchangeRate.Items1"),
            resources.GetString("cboExchangeRate.Items2"),
            resources.GetString("cboExchangeRate.Items3"),
            resources.GetString("cboExchangeRate.Items4"),
            resources.GetString("cboExchangeRate.Items5"),
            resources.GetString("cboExchangeRate.Items6"),
            resources.GetString("cboExchangeRate.Items7"),
            resources.GetString("cboExchangeRate.Items8")});
            resources.ApplyResources(this.cboExchangeRate, "cboExchangeRate");
            this.cboExchangeRate.Name = "cboExchangeRate";
            this.cboExchangeRate.SelectionChangeCommitted += new System.EventHandler(this.cboExchangeRate_SelectionChangeCommitted);
            // 
            // cboProfitMargin
            // 
            this.cboProfitMargin.FormattingEnabled = true;
            this.cboProfitMargin.Items.AddRange(new object[] {
            resources.GetString("cboProfitMargin.Items"),
            resources.GetString("cboProfitMargin.Items1"),
            resources.GetString("cboProfitMargin.Items2"),
            resources.GetString("cboProfitMargin.Items3"),
            resources.GetString("cboProfitMargin.Items4"),
            resources.GetString("cboProfitMargin.Items5")});
            resources.ApplyResources(this.cboProfitMargin, "cboProfitMargin");
            this.cboProfitMargin.Name = "cboProfitMargin";
            this.cboProfitMargin.SelectionChangeCommitted += new System.EventHandler(this.cboProfitMargin_SelectionChangeCommitted);
            // 
            // lbResult
            // 
            this.lbResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.lbResult, "lbResult");
            this.lbResult.Name = "lbResult";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnReset.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnSave, "btnSave");
            this.btnSave.Name = "btnSave";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Name = "label8";
            // 
            // dgvPriceHistory
            // 
            resources.ApplyResources(this.dgvPriceHistory, "dgvPriceHistory");
            this.dgvPriceHistory.AllowUserToAddRows = false;
            this.dgvPriceHistory.AllowUserToDeleteRows = false;
            this.dgvPriceHistory.AllowUserToResizeColumns = false;
            this.dgvPriceHistory.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.PapayaWhip;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.PapayaWhip;
            this.dgvPriceHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvPriceHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(227)))), ((int)(((byte)(227)))));
            this.dgvPriceHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPriceHistory.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.LightSeaGreen;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPriceHistory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvPriceHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPriceHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Opt,
            this.UnitPrice,
            this.ItemDescription,
            this.CreateTime});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPriceHistory.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvPriceHistory.MultiSelect = false;
            this.dgvPriceHistory.Name = "dgvPriceHistory";
            this.dgvPriceHistory.ReadOnly = true;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPriceHistory.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvPriceHistory.RowHeadersVisible = false;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.dgvPriceHistory.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvPriceHistory.RowTemplate.Height = 30;
            this.dgvPriceHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPriceHistory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPriceHistory_CellClick);
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // btnClearPrice
            // 
            this.btnClearPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnClearPrice.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnClearPrice, "btnClearPrice");
            this.btnClearPrice.Name = "btnClearPrice";
            this.btnClearPrice.UseVisualStyleBackColor = false;
            this.btnClearPrice.Click += new System.EventHandler(this.btnClearPrice_Click);
            // 
            // btnImportToOrder
            // 
            this.btnImportToOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnImportToOrder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnImportToOrder, "btnImportToOrder");
            this.btnImportToOrder.Name = "btnImportToOrder";
            this.btnImportToOrder.UseVisualStyleBackColor = false;
            this.btnImportToOrder.Click += new System.EventHandler(this.btnImportToOrder_Click);
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // tbItem
            // 
            resources.ApplyResources(this.tbItem, "tbItem");
            this.tbItem.Name = "tbItem";
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
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
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            resources.ApplyResources(this.label12, "label12");
            this.label12.Name = "label12";
            // 
            // lbError
            // 
            resources.ApplyResources(this.lbError, "lbError");
            this.lbError.Name = "lbError";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnEdit, "btnEdit");
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.UseVisualStyleBackColor = false;
            // 
            // Opt
            // 
            this.Opt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.NullValue = false;
            this.Opt.DefaultCellStyle = dataGridViewCellStyle12;
            resources.ApplyResources(this.Opt, "Opt");
            this.Opt.Name = "Opt";
            this.Opt.ReadOnly = true;
            // 
            // UnitPrice
            // 
            this.UnitPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.UnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.UnitPrice.DefaultCellStyle = dataGridViewCellStyle13;
            resources.ApplyResources(this.UnitPrice, "UnitPrice");
            this.UnitPrice.Name = "UnitPrice";
            this.UnitPrice.ReadOnly = true;
            this.UnitPrice.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.UnitPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ItemDescription
            // 
            this.ItemDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ItemDescription.DataPropertyName = "ItemDescription";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.ItemDescription.DefaultCellStyle = dataGridViewCellStyle14;
            resources.ApplyResources(this.ItemDescription, "ItemDescription");
            this.ItemDescription.Name = "ItemDescription";
            this.ItemDescription.ReadOnly = true;
            this.ItemDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ItemDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CreateTime
            // 
            this.CreateTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.CreateTime.DataPropertyName = "CreateTime";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            this.CreateTime.DefaultCellStyle = dataGridViewCellStyle15;
            resources.ApplyResources(this.CreateTime, "CreateTime");
            this.CreateTime.Name = "CreateTime";
            this.CreateTime.ReadOnly = true;
            this.CreateTime.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CreateTime.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CalculatePriceKitPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CalculatePriceKitPage";
            this.TopMost = true;
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
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Opt;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreateTime;
    }
}