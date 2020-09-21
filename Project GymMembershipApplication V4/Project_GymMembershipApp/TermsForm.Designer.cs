namespace Project_GymMembershipApp
{
    partial class TermsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TermsForm));
            this.lblTerms = new System.Windows.Forms.Label();
            this.bttnClose = new System.Windows.Forms.Button();
            this.bttnPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.lblTermsOut = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTerms
            // 
            this.lblTerms.AutoSize = true;
            this.lblTerms.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerms.Location = new System.Drawing.Point(12, 9);
            this.lblTerms.Name = "lblTerms";
            this.lblTerms.Size = new System.Drawing.Size(261, 30);
            this.lblTerms.TabIndex = 1;
            this.lblTerms.Text = "Terms of service document";
            // 
            // bttnClose
            // 
            this.bttnClose.Location = new System.Drawing.Point(12, 410);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(201, 39);
            this.bttnClose.TabIndex = 2;
            this.bttnClose.Text = "Close";
            this.bttnClose.UseVisualStyleBackColor = true;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // bttnPrint
            // 
            this.bttnPrint.Location = new System.Drawing.Point(219, 410);
            this.bttnPrint.Name = "bttnPrint";
            this.bttnPrint.Size = new System.Drawing.Size(197, 39);
            this.bttnPrint.TabIndex = 3;
            this.bttnPrint.Text = "Print Terms";
            this.bttnPrint.UseVisualStyleBackColor = true;
            this.bttnPrint.Click += new System.EventHandler(this.bttnPrint_Click);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // lblTermsOut
            // 
            this.lblTermsOut.BackColor = System.Drawing.SystemColors.Window;
            this.lblTermsOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTermsOut.Location = new System.Drawing.Point(12, 45);
            this.lblTermsOut.Name = "lblTermsOut";
            this.lblTermsOut.Size = new System.Drawing.Size(404, 362);
            this.lblTermsOut.TabIndex = 25;
            // 
            // TermsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 461);
            this.Controls.Add(this.lblTermsOut);
            this.Controls.Add(this.bttnPrint);
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.lblTerms);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TermsForm";
            this.Text = "Terms";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblTerms;
        private System.Windows.Forms.Button bttnClose;
        private System.Windows.Forms.Button bttnPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label lblTermsOut;
    }
}