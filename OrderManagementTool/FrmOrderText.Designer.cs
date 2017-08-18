namespace OrderManagementTool
{
    partial class FrmOrderText
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrderText));
            this.tbOrderContent = new System.Windows.Forms.TextBox();
            this.btnCopyToClipboard = new System.Windows.Forms.Button();
            this.btnRegenerate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbOrderContent
            // 
            this.tbOrderContent.Location = new System.Drawing.Point(36, 28);
            this.tbOrderContent.Multiline = true;
            this.tbOrderContent.Name = "tbOrderContent";
            this.tbOrderContent.Size = new System.Drawing.Size(433, 449);
            this.tbOrderContent.TabIndex = 0;
            // 
            // btnCopyToClipboard
            // 
            this.btnCopyToClipboard.Location = new System.Drawing.Point(385, 500);
            this.btnCopyToClipboard.Name = "btnCopyToClipboard";
            this.btnCopyToClipboard.Size = new System.Drawing.Size(84, 35);
            this.btnCopyToClipboard.TabIndex = 1;
            this.btnCopyToClipboard.Text = "Copy";
            this.btnCopyToClipboard.UseVisualStyleBackColor = true;
            this.btnCopyToClipboard.Click += new System.EventHandler(this.btnCopyToClipboard_Click);
            // 
            // btnRegenerate
            // 
            this.btnRegenerate.Location = new System.Drawing.Point(36, 500);
            this.btnRegenerate.Name = "btnRegenerate";
            this.btnRegenerate.Size = new System.Drawing.Size(268, 35);
            this.btnRegenerate.TabIndex = 1;
            this.btnRegenerate.Text = "Re-generate based on order";
            this.btnRegenerate.UseVisualStyleBackColor = true;
            this.btnRegenerate.Click += new System.EventHandler(this.btnRegenerate_Click);
            // 
            // FrmOrderText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 563);
            this.Controls.Add(this.btnRegenerate);
            this.Controls.Add(this.btnCopyToClipboard);
            this.Controls.Add(this.tbOrderContent);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmOrderText";
            this.Text = "Order Text";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmOrderText_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbOrderContent;
        private System.Windows.Forms.Button btnCopyToClipboard;
        private System.Windows.Forms.Button btnRegenerate;
    }
}