namespace Project_GymMembershipApp
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblAboutTxt = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.bttnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(192, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "About The Gym Application Version 4.0";
            // 
            // lblAboutTxt
            // 
            this.lblAboutTxt.AllowDrop = true;
            this.lblAboutTxt.AutoSize = true;
            this.lblAboutTxt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAboutTxt.Location = new System.Drawing.Point(12, 31);
            this.lblAboutTxt.Name = "lblAboutTxt";
            this.lblAboutTxt.Size = new System.Drawing.Size(254, 93);
            this.lblAboutTxt.TabIndex = 1;
            this.lblAboutTxt.Text = "By: Theodor Emanuelsson\r\nFor Course in C# at Malmö University\r\n\r\n\r\nThe icons used" +
    " for this project has been\r\ntaken from icons8.com. Please see the link below to\r" +
    "\naccess their website\r\n";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(12, 138);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(97, 13);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "https://icons8.com";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // bttnClose
            // 
            this.bttnClose.Location = new System.Drawing.Point(191, 138);
            this.bttnClose.Name = "bttnClose";
            this.bttnClose.Size = new System.Drawing.Size(75, 49);
            this.bttnClose.TabIndex = 3;
            this.bttnClose.Text = "Close";
            this.bttnClose.UseVisualStyleBackColor = true;
            this.bttnClose.Click += new System.EventHandler(this.bttnClose_Click);
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 219);
            this.Controls.Add(this.bttnClose);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lblAboutTxt);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.Text = "AboutForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblAboutTxt;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button bttnClose;
    }
}