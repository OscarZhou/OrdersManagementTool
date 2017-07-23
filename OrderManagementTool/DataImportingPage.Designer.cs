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
            this.SuspendLayout();
            // 
            // btnImportRecords
            // 
            this.btnImportRecords.Location = new System.Drawing.Point(93, 29);
            this.btnImportRecords.Name = "btnImportRecords";
            this.btnImportRecords.Size = new System.Drawing.Size(150, 34);
            this.btnImportRecords.TabIndex = 0;
            this.btnImportRecords.Text = "ImportRecords";
            this.btnImportRecords.UseVisualStyleBackColor = true;
            this.btnImportRecords.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // prbImport
            // 
            this.prbImport.Location = new System.Drawing.Point(90, 171);
            this.prbImport.Name = "prbImport";
            this.prbImport.Size = new System.Drawing.Size(852, 28);
            this.prbImport.TabIndex = 1;
            // 
            // lbProcessing
            // 
            this.lbProcessing.AutoSize = true;
            this.lbProcessing.Location = new System.Drawing.Point(87, 129);
            this.lbProcessing.Name = "lbProcessing";
            this.lbProcessing.Size = new System.Drawing.Size(188, 18);
            this.lbProcessing.TabIndex = 2;
            this.lbProcessing.Text = "Current Processing :";
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
            this.lbProgress.Location = new System.Drawing.Point(961, 180);
            this.lbProgress.Name = "lbProgress";
            this.lbProgress.Size = new System.Drawing.Size(26, 18);
            this.lbProgress.TabIndex = 3;
            this.lbProgress.Text = "0%";
            // 
            // lbFolder
            // 
            this.lbFolder.AutoSize = true;
            this.lbFolder.Location = new System.Drawing.Point(90, 92);
            this.lbFolder.Name = "lbFolder";
            this.lbFolder.Size = new System.Drawing.Size(179, 18);
            this.lbFolder.TabIndex = 4;
            this.lbFolder.Text = "Selected Directory:";
            // 
            // btnImportTransaction
            // 
            this.btnImportTransaction.Location = new System.Drawing.Point(351, 29);
            this.btnImportTransaction.Name = "btnImportTransaction";
            this.btnImportTransaction.Size = new System.Drawing.Size(206, 34);
            this.btnImportTransaction.TabIndex = 1;
            this.btnImportTransaction.Text = "ImportTransaction";
            this.btnImportTransaction.UseVisualStyleBackColor = true;
            this.btnImportTransaction.Click += new System.EventHandler(this.btnImportTransaction_Click);
            // 
            // bkgWorkForTransaction
            // 
            this.bkgWorkForTransaction.WorkerReportsProgress = true;
            this.bkgWorkForTransaction.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bkgWorkForTransaction_DoWork);
            this.bkgWorkForTransaction.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bkgWorkForTransaction_ProgressChanged);
            // 
            // DataImportingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 230);
            this.Controls.Add(this.btnImportTransaction);
            this.Controls.Add(this.lbFolder);
            this.Controls.Add(this.lbProgress);
            this.Controls.Add(this.lbProcessing);
            this.Controls.Add(this.prbImport);
            this.Controls.Add(this.btnImportRecords);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataImportingPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Data Importing";
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
    }
}