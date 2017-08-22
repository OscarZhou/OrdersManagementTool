namespace OrderManagementTool
{
    partial class DataImportingPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataImportingPage));
            this.btnImportRecords = new System.Windows.Forms.Button();
            this.prbImport = new System.Windows.Forms.ProgressBar();
            this.lbProcessing = new System.Windows.Forms.Label();
            this.bkgWorkForImporting = new System.ComponentModel.BackgroundWorker();
            this.lbProgress = new System.Windows.Forms.Label();
            this.lbFolder = new System.Windows.Forms.Label();
            this.btnImportTransaction = new System.Windows.Forms.Button();
            this.bkgWorkForTransaction = new System.ComponentModel.BackgroundWorker();
            this.btnExportTransaction = new System.Windows.Forms.Button();
            this.bkgWorkForExporting = new System.ComponentModel.BackgroundWorker();
            this.label11 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImportRecords
            // 
            this.btnImportRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnImportRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnImportRecords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportRecords.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImportRecords.Image = ((System.Drawing.Image)(resources.GetObject("btnImportRecords.Image")));
            this.btnImportRecords.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportRecords.Location = new System.Drawing.Point(506, 15);
            this.btnImportRecords.Name = "btnImportRecords";
            this.btnImportRecords.Size = new System.Drawing.Size(183, 40);
            this.btnImportRecords.TabIndex = 0;
            this.btnImportRecords.Text = "ImportRecords";
            this.btnImportRecords.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportRecords.UseVisualStyleBackColor = false;
            this.btnImportRecords.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // prbImport
            // 
            this.prbImport.Location = new System.Drawing.Point(28, 172);
            this.prbImport.Name = "prbImport";
            this.prbImport.Size = new System.Drawing.Size(1037, 28);
            this.prbImport.TabIndex = 1;
            // 
            // lbProcessing
            // 
            this.lbProcessing.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbProcessing.Image = ((System.Drawing.Image)(resources.GetObject("lbProcessing.Image")));
            this.lbProcessing.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbProcessing.Location = new System.Drawing.Point(49, 118);
            this.lbProcessing.Name = "lbProcessing";
            this.lbProcessing.Size = new System.Drawing.Size(1049, 27);
            this.lbProcessing.TabIndex = 2;
            this.lbProcessing.Text = "     Current Processing:";
            this.lbProcessing.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bkgWorkForImporting
            // 
            this.bkgWorkForImporting.WorkerReportsProgress = true;
            this.bkgWorkForImporting.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorkForImporting_DoWork);
            this.bkgWorkForImporting.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorkForImporting_ProgressChanged);
            this.bkgWorkForImporting.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bkgWorkForImporting_RunWorkerCompleted);
            // 
            // lbProgress
            // 
            this.lbProgress.AutoSize = true;
            this.lbProgress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbProgress.Location = new System.Drawing.Point(1078, 174);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(37, 25);
            this.lbProgress.TabIndex = 3;
            this.lbProgress.Text = "0%";
            // 
            // lbFolder
            // 
            this.lbFolder.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbFolder.Image = ((System.Drawing.Image)(resources.GetObject("lbFolder.Image")));
            this.lbFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbFolder.Location = new System.Drawing.Point(48, 69);
            this.lbFolder.Name = "lbFolder";
            this.lbFolder.Size = new System.Drawing.Size(1050, 27);
            this.lbFolder.TabIndex = 4;
            this.lbFolder.Text = "     Selected Directory:";
            this.lbFolder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnImportTransaction
            // 
            this.btnImportTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnImportTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnImportTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImportTransaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnImportTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnImportTransaction.Image")));
            this.btnImportTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImportTransaction.Location = new System.Drawing.Point(717, 15);
            this.btnImportTransaction.Name = "btnImportTransaction";
            this.btnImportTransaction.Size = new System.Drawing.Size(198, 40);
            this.btnImportTransaction.TabIndex = 1;
            this.btnImportTransaction.Text = "ImportTransaction";
            this.btnImportTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImportTransaction.UseVisualStyleBackColor = false;
            this.btnImportTransaction.Click += new System.EventHandler(this.btnImportTransaction_Click);
            // 
            // bkgWorkForTransaction
            // 
            this.bkgWorkForTransaction.WorkerReportsProgress = true;
            this.bkgWorkForTransaction.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorkForTransaction_DoWork);
            this.bkgWorkForTransaction.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorkForTransaction_ProgressChanged);
            // 
            // btnExportTransaction
            // 
            this.btnExportTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnExportTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnExportTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExportTransaction.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExportTransaction.Image = ((System.Drawing.Image)(resources.GetObject("btnExportTransaction.Image")));
            this.btnExportTransaction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportTransaction.Location = new System.Drawing.Point(943, 15);
            this.btnExportTransaction.Name = "btnExportTransaction";
            this.btnExportTransaction.Size = new System.Drawing.Size(199, 40);
            this.btnExportTransaction.TabIndex = 1;
            this.btnExportTransaction.Text = "Export Transaction";
            this.btnExportTransaction.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportTransaction.UseVisualStyleBackColor = false;
            this.btnExportTransaction.Click += new System.EventHandler(this.btnExportTransaction_Click);
            // 
            // bkgWorkForExporting
            // 
            this.bkgWorkForExporting.WorkerReportsProgress = true;
            this.bkgWorkForExporting.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorkForExporting_DoWork);
            this.bkgWorkForExporting.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorkForExporting_ProgressChanged);
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(22, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1124, 1);
            this.label11.TabIndex = 13;
            this.label11.Text = "label11";
            // 
            // DataImportingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1218, 706);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExportTransaction);
            this.Controls.Add(this.btnImportTransaction);
            this.Controls.Add(this.lbFolder);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.lbProcessing);
            this.Controls.Add(this.prbImport);
            this.Controls.Add(this.btnImportRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataImportingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Importing";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DataImportingPage_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportRecords;
        private System.Windows.Forms.ProgressBar prbImport;
        private System.Windows.Forms.Label lbProcessing;
        private System.ComponentModel.BackgroundWorker bkgWorkForImporting;
        private System.Windows.Forms.Label lbProgress;
        private System.Windows.Forms.Label lbFolder;
        private System.Windows.Forms.Button btnImportTransaction;
        private System.ComponentModel.BackgroundWorker bkgWorkForTransaction;
        private System.Windows.Forms.Button btnExportTransaction;
        private System.ComponentModel.BackgroundWorker bkgWorkForExporting;
        private System.Windows.Forms.Label label11;
    }
}