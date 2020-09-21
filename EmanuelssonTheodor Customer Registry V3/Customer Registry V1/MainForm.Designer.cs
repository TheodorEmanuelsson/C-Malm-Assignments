namespace Customer_Registry_V1
{
    partial class MainForm
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
            this.listBoxCustomers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panelSearchMenu = new System.Windows.Forms.Panel();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.bttnSearchMenu = new System.Windows.Forms.Button();
            this.panelCustomerMenu = new System.Windows.Forms.Panel();
            this.BttnDelete = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnMenu = new System.Windows.Forms.Button();
            this.panelTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelSide.SuspendLayout();
            this.panelSearchMenu.SuspendLayout();
            this.panelCustomerMenu.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxCustomers
            // 
            this.listBoxCustomers.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.listBoxCustomers.FormattingEnabled = true;
            this.listBoxCustomers.ItemHeight = 14;
            this.listBoxCustomers.Location = new System.Drawing.Point(260, 47);
            this.listBoxCustomers.Name = "listBoxCustomers";
            this.listBoxCustomers.Size = new System.Drawing.Size(1055, 536);
            this.listBoxCustomers.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Customer Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Address Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(857, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Work and Home Phone";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1143, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email Addresses";
            // 
            // panelSide
            // 
            this.panelSide.AutoScroll = true;
            this.panelSide.BackColor = System.Drawing.Color.SlateGray;
            this.panelSide.Controls.Add(this.panelSearchMenu);
            this.panelSide.Controls.Add(this.bttnSearchMenu);
            this.panelSide.Controls.Add(this.panelCustomerMenu);
            this.panelSide.Controls.Add(this.bttnMenu);
            this.panelSide.Controls.Add(this.panelTitle);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSide.Location = new System.Drawing.Point(0, 0);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(250, 588);
            this.panelSide.TabIndex = 11;
            // 
            // panelSearchMenu
            // 
            this.panelSearchMenu.Controls.Add(this.bttnSearch);
            this.panelSearchMenu.Controls.Add(this.txtBoxSearch);
            this.panelSearchMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearchMenu.Location = new System.Drawing.Point(0, 298);
            this.panelSearchMenu.Name = "panelSearchMenu";
            this.panelSearchMenu.Size = new System.Drawing.Size(250, 63);
            this.panelSearchMenu.TabIndex = 15;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.Color.LightSlateGray;
            this.bttnSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnSearch.FlatAppearance.BorderSize = 0;
            this.bttnSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnSearch.Location = new System.Drawing.Point(0, 24);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bttnSearch.Size = new System.Drawing.Size(250, 35);
            this.bttnSearch.TabIndex = 16;
            this.bttnSearch.Text = "Search For Customer";
            this.bttnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click_1);
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtBoxSearch.Font = new System.Drawing.Font("Corbel", 10F);
            this.txtBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(250, 24);
            this.txtBoxSearch.TabIndex = 15;
            // 
            // bttnSearchMenu
            // 
            this.bttnSearchMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnSearchMenu.FlatAppearance.BorderSize = 0;
            this.bttnSearchMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSearchMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnSearchMenu.Location = new System.Drawing.Point(0, 253);
            this.bttnSearchMenu.Name = "bttnSearchMenu";
            this.bttnSearchMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bttnSearchMenu.Size = new System.Drawing.Size(250, 45);
            this.bttnSearchMenu.TabIndex = 15;
            this.bttnSearchMenu.Text = "Search Customer Menu";
            this.bttnSearchMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnSearchMenu.UseVisualStyleBackColor = true;
            this.bttnSearchMenu.Click += new System.EventHandler(this.bttnSearchMenu_Click_1);
            // 
            // panelCustomerMenu
            // 
            this.panelCustomerMenu.BackColor = System.Drawing.Color.LightSlateGray;
            this.panelCustomerMenu.Controls.Add(this.BttnDelete);
            this.panelCustomerMenu.Controls.Add(this.bttnEdit);
            this.panelCustomerMenu.Controls.Add(this.bttnAdd);
            this.panelCustomerMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCustomerMenu.Location = new System.Drawing.Point(0, 145);
            this.panelCustomerMenu.Name = "panelCustomerMenu";
            this.panelCustomerMenu.Size = new System.Drawing.Size(250, 108);
            this.panelCustomerMenu.TabIndex = 14;
            // 
            // BttnDelete
            // 
            this.BttnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.BttnDelete.FlatAppearance.BorderSize = 0;
            this.BttnDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.BttnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BttnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BttnDelete.Location = new System.Drawing.Point(0, 70);
            this.BttnDelete.Name = "BttnDelete";
            this.BttnDelete.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.BttnDelete.Size = new System.Drawing.Size(250, 35);
            this.BttnDelete.TabIndex = 2;
            this.BttnDelete.Text = "Delete Customer";
            this.BttnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BttnDelete.UseVisualStyleBackColor = true;
            this.BttnDelete.Click += new System.EventHandler(this.BttnDelete_Click_1);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnEdit.FlatAppearance.BorderSize = 0;
            this.bttnEdit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bttnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnEdit.Location = new System.Drawing.Point(0, 35);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bttnEdit.Size = new System.Drawing.Size(250, 35);
            this.bttnEdit.TabIndex = 1;
            this.bttnEdit.Text = "Edit Customer";
            this.bttnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnEdit.UseVisualStyleBackColor = true;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click_1);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnAdd.FlatAppearance.BorderSize = 0;
            this.bttnAdd.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DimGray;
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnAdd.Location = new System.Drawing.Point(0, 0);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.bttnAdd.Size = new System.Drawing.Size(250, 35);
            this.bttnAdd.TabIndex = 0;
            this.bttnAdd.Text = "Add Customer";
            this.bttnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click_1);
            // 
            // bttnMenu
            // 
            this.bttnMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttnMenu.FlatAppearance.BorderSize = 0;
            this.bttnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bttnMenu.Location = new System.Drawing.Point(0, 100);
            this.bttnMenu.Name = "bttnMenu";
            this.bttnMenu.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.bttnMenu.Size = new System.Drawing.Size(250, 45);
            this.bttnMenu.TabIndex = 13;
            this.bttnMenu.Text = "Customer Menu";
            this.bttnMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bttnMenu.UseVisualStyleBackColor = true;
            this.bttnMenu.Click += new System.EventHandler(this.bttnMenu_Click);
            // 
            // panelTitle
            // 
            this.panelTitle.Controls.Add(this.lblTitle);
            this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(250, 100);
            this.panelTitle.TabIndex = 12;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Corbel", 20F);
            this.lblTitle.Location = new System.Drawing.Point(12, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(81, 33);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "TITLE";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1325, 588);
            this.Controls.Add(this.panelSide);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxCustomers);
            this.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "MainForm";
            this.Text = "Customer Registry";
            this.panelSide.ResumeLayout(false);
            this.panelSearchMenu.ResumeLayout(false);
            this.panelSearchMenu.PerformLayout();
            this.panelCustomerMenu.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.panelTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxCustomers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panelCustomerMenu;
        private System.Windows.Forms.Button BttnDelete;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnMenu;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.Panel panelSearchMenu;
        private System.Windows.Forms.Button bttnSearchMenu;
        private System.Windows.Forms.Label lblTitle;
    }
}

