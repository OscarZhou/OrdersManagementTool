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
            this.btnExportRecords = new System.Windows.Forms.Button();
            this.bkgWorkForExportingRecords = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // btnImportRecords
            // 
            this.btnImportRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnImportRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnImportRecords, "btnImportRecords");
            this.btnImportRecords.Name = "btnImportRecords";
            this.btnImportRecords.UseVisualStyleBackColor = false;
            this.btnImportRecords.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // prbImport
            // 
            resources.ApplyResources(this.prbImport, "prbImport");
            this.prbImport.Name = "prbImport";
            // 
            // lbProcessing
            // 
            resources.ApplyResources(this.lbProcessing, "lbProcessing");
            this.lbProcessing.Name = "lbProcessing";
            // 
            // bkgWorkForImporting
            // 
            this.bkgWorkForImporting.WorkerReportsProgress = true;
            this.bkgWorkForImporting.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorkForImporting_DoWork);
            this.bkgWorkForImporting.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorkForImporting_ProgressChanged);
            // 
            // lbProgress
            // 
            resources.ApplyResources(this.lbProgress, "lbProgress");
            this.lbProgress.Name = "lbProgress";
            // 
            // lbFolder
            // 
            resources.ApplyResources(this.lbFolder, "lbFolder");
            this.lbFolder.Name = "lbFolder";
            // 
            // btnImportTransaction
            // 
            this.btnImportTransaction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnImportTransaction.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnImportTransaction, "btnImportTransaction");
            this.btnImportTransaction.Name = "btnImportTransaction";
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
            resources.ApplyResources(this.btnExportTransaction, "btnExportTransaction");
            this.btnExportTransaction.Name = "btnExportTransaction";
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
            resources.ApplyResources(this.label11, "label11");
            this.label11.Name = "label11";
            // 
            // btnExportRecords
            // 
            this.btnExportRecords.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            this.btnExportRecords.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(163)))), ((int)(((byte)(220)))));
            resources.ApplyResources(this.btnExportRecords, "btnExportRecords");
            this.btnExportRecords.Name = "btnExportRecords";
            this.btnExportRecords.UseVisualStyleBackColor = false;
            this.btnExportRecords.Click += new System.EventHandler(this.btnExportRecords_Click);
            // 
            // bkgWorkForExportingRecords
            // 
            this.bkgWorkForExportingRecords.WorkerReportsProgress = true;
            this.bkgWorkForExportingRecords.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorkForExportingRecords_DoWork);
            this.bkgWorkForExportingRecords.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorkForExportingRecords_ProgressChanged);
            // 
            // DataImportingPage
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnExportTransaction);
            this.Controls.Add(this.btnImportTransaction);
            this.Controls.Add(this.lbFolder);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.lbProcessing);
            this.Controls.Add(this.prbImport);
            this.Controls.Add(this.btnExportRecords);
            this.Controls.Add(this.btnImportRecords);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DataImportingPage";
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
        private System.Windows.Forms.Button btnExportRecords;
        private System.ComponentModel.BackgroundWorker bkgWorkForExportingRecords;
    }
}