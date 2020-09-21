namespace Project_GymMembershipApp
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listBoxMembers = new System.Windows.Forms.ListBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblMembStart = new System.Windows.Forms.Label();
            this.lblMembEnd = new System.Windows.Forms.Label();
            this.lblDays = new System.Windows.Forms.Label();
            this.lblMembType = new System.Windows.Forms.Label();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblReceipt = new System.Windows.Forms.Label();
            this.lblReceiptOut = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bttnPrintReceipt = new System.Windows.Forms.Button();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelStartHelp = new System.Windows.Forms.Panel();
            this.lblStartHelp = new System.Windows.Forms.Label();
            this.pictureBoxStartHelp = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttnMain = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.bttnAbout = new System.Windows.Forms.Button();
            this.bttnMoreInfo = new System.Windows.Forms.Button();
            this.bttnTerms = new System.Windows.Forms.Button();
            this.bttnExit = new System.Windows.Forms.Button();
            this.bttnSearchMenu = new System.Windows.Forms.Button();
            this.panelSearchMenu = new System.Windows.Forms.Panel();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.bttnSearch = new System.Windows.Forms.Button();
            this.bttnMenu = new System.Windows.Forms.Button();
            this.panelMemberMenu = new System.Windows.Forms.Panel();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.panelApp = new System.Windows.Forms.Panel();
            this.lblBMITitle = new System.Windows.Forms.Label();
            this.lblRecTitle = new System.Windows.Forms.Label();
            this.lblBMIOut = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            this.panelStartHelp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartHelp)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelSearchMenu.SuspendLayout();
            this.panelMemberMenu.SuspendLayout();
            this.panelApp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxMembers
            // 
            this.listBoxMembers.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.listBoxMembers.FormattingEnabled = true;
            this.listBoxMembers.ItemHeight = 14;
            this.listBoxMembers.Location = new System.Drawing.Point(5, 38);
            this.listBoxMembers.Name = "listBoxMembers";
            this.listBoxMembers.Size = new System.Drawing.Size(1055, 536);
            this.listBoxMembers.TabIndex = 13;
            this.listBoxMembers.SelectedIndexChanged += new System.EventHandler(this.listBoxMembers_SelectedIndexChanged);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblID.Location = new System.Drawing.Point(3, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(88, 21);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "Member ID";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblFullName.Location = new System.Drawing.Point(141, 14);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(52, 21);
            this.lblFullName.TabIndex = 15;
            this.lblFullName.Text = "Name";
            // 
            // lblMembStart
            // 
            this.lblMembStart.AutoSize = true;
            this.lblMembStart.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMembStart.Location = new System.Drawing.Point(274, 14);
            this.lblMembStart.Name = "lblMembStart";
            this.lblMembStart.Size = new System.Drawing.Size(132, 21);
            this.lblMembStart.TabIndex = 17;
            this.lblMembStart.Text = "Membership date";
            // 
            // lblMembEnd
            // 
            this.lblMembEnd.AutoSize = true;
            this.lblMembEnd.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMembEnd.Location = new System.Drawing.Point(443, 14);
            this.lblMembEnd.Name = "lblMembEnd";
            this.lblMembEnd.Size = new System.Drawing.Size(135, 21);
            this.lblMembEnd.TabIndex = 18;
            this.lblMembEnd.Text = "Membership ends";
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDays.Location = new System.Drawing.Point(901, 14);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(154, 21);
            this.lblDays.TabIndex = 19;
            this.lblDays.Text = "Days of membership";
            // 
            // lblMembType
            // 
            this.lblMembType.AutoSize = true;
            this.lblMembType.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblMembType.Location = new System.Drawing.Point(653, 14);
            this.lblMembType.Name = "lblMembType";
            this.lblMembType.Size = new System.Drawing.Size(42, 21);
            this.lblMembType.TabIndex = 20;
            this.lblMembType.Text = "Type";
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblLocation.Location = new System.Drawing.Point(769, 14);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(69, 21);
            this.lblLocation.TabIndex = 21;
            this.lblLocation.Text = "Location";
            // 
            // lblReceipt
            // 
            this.lblReceipt.AutoSize = true;
            this.lblReceipt.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblReceipt.Location = new System.Drawing.Point(1158, 529);
            this.lblReceipt.Name = "lblReceipt";
            this.lblReceipt.Size = new System.Drawing.Size(61, 21);
            this.lblReceipt.TabIndex = 22;
            this.lblReceipt.Text = "Receipt";
            // 
            // lblReceiptOut
            // 
            this.lblReceiptOut.BackColor = System.Drawing.SystemColors.Window;
            this.lblReceiptOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReceiptOut.Location = new System.Drawing.Point(1066, 361);
            this.lblReceiptOut.Name = "lblReceiptOut";
            this.lblReceiptOut.Size = new System.Drawing.Size(231, 158);
            this.lblReceiptOut.TabIndex = 24;
            // 
            // bttnPrintReceipt
            // 
            this.bttnPrintReceipt.BackColor = System.Drawing.Color.SeaShell;
            this.bttnPrintReceipt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttnPrintReceipt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnPrintReceipt.Location = new System.Drawing.Point(1066, 527);
            this.bttnPrintReceipt.Name = "bttnPrintReceipt";
            this.bttnPrintReceipt.Size = new System.Drawing.Size(231, 47);
            this.bttnPrintReceipt.TabIndex = 25;
            this.bttnPrintReceipt.Text = "Print Receipt";
            this.bttnPrintReceipt.UseVisualStyleBackColor = false;
            this.bttnPrintReceipt.Click += new System.EventHandler(this.bttnPrintReceipt_Click);
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
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Ivory;
            this.panelMain.Controls.Add(this.panelStartHelp);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.bttnMain);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1321, 56);
            this.panelMain.TabIndex = 26;
            // 
            // panelStartHelp
            // 
            this.panelStartHelp.Controls.Add(this.lblStartHelp);
            this.panelStartHelp.Controls.Add(this.pictureBoxStartHelp);
            this.panelStartHelp.Location = new System.Drawing.Point(62, 3);
            this.panelStartHelp.Name = "panelStartHelp";
            this.panelStartHelp.Size = new System.Drawing.Size(271, 53);
            this.panelStartHelp.TabIndex = 2;
            // 
            // lblStartHelp
            // 
            this.lblStartHelp.AutoSize = true;
            this.lblStartHelp.Font = new System.Drawing.Font("Segoe UI Symbol", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartHelp.Location = new System.Drawing.Point(52, 16);
            this.lblStartHelp.Name = "lblStartHelp";
            this.lblStartHelp.Size = new System.Drawing.Size(206, 21);
            this.lblStartHelp.TabIndex = 1;
            this.lblStartHelp.Text = "Click to open main menu";
            // 
            // pictureBoxStartHelp
            // 
            this.pictureBoxStartHelp.Image = global::Project_GymMembershipApp.Properties.Resources.icons8_arrow_48;
            this.pictureBoxStartHelp.Location = new System.Drawing.Point(0, 6);
            this.pictureBoxStartHelp.Name = "pictureBoxStartHelp";
            this.pictureBoxStartHelp.Size = new System.Drawing.Size(56, 47);
            this.pictureBoxStartHelp.TabIndex = 0;
            this.pictureBoxStartHelp.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(440, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "The Buget Gym Application";
            // 
            // bttnMain
            // 
            this.bttnMain.Image = global::Project_GymMembershipApp.Properties.Resources.icons8_menu_48;
            this.bttnMain.Location = new System.Drawing.Point(12, 12);
            this.bttnMain.Name = "bttnMain";
            this.bttnMain.Size = new System.Drawing.Size(44, 39);
            this.bttnMain.TabIndex = 0;
            this.bttnMain.UseVisualStyleBackColor = true;
            this.bttnMain.Click += new System.EventHandler(this.bttnMain_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.panelMenu.Controls.Add(this.bttnAbout);
            this.panelMenu.Controls.Add(this.bttnMoreInfo);
            this.panelMenu.Controls.Add(this.bttnTerms);
            this.panelMenu.Controls.Add(this.bttnExit);
            this.panelMenu.Controls.Add(this.bttnSearchMenu);
            this.panelMenu.Controls.Add(this.panelSearchMenu);
            this.panelMenu.Controls.Add(this.bttnMenu);
            this.panelMenu.Controls.Add(this.panelMemberMenu);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMenu.Location = new System.Drawing.Point(0, 56);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(1321, 133);
            this.panelMenu.TabIndex = 27;
            // 
            // bttnAbout
            // 
            this.bttnAbout.BackColor = System.Drawing.Color.Peru;
            this.bttnAbout.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttnAbout.FlatAppearance.BorderSize = 0;
            this.bttnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAbout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnAbout.Location = new System.Drawing.Point(930, 0);
            this.bttnAbout.Name = "bttnAbout";
            this.bttnAbout.Size = new System.Drawing.Size(129, 133);
            this.bttnAbout.TabIndex = 8;
            this.bttnAbout.Text = "About";
            this.bttnAbout.UseVisualStyleBackColor = false;
            this.bttnAbout.Click += new System.EventHandler(this.bttnAbout_Click);
            // 
            // bttnMoreInfo
            // 
            this.bttnMoreInfo.BackColor = System.Drawing.Color.Peru;
            this.bttnMoreInfo.Dock = System.Windows.Forms.DockStyle.Left;
            this.bttnMoreInfo.FlatAppearance.BorderSize = 0;
            this.bttnMoreInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMoreInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMoreInfo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnMoreInfo.Location = new System.Drawing.Point(645, 0);
            this.bttnMoreInfo.Name = "bttnMoreInfo";
            this.bttnMoreInfo.Size = new System.Drawing.Size(75, 133);
            this.bttnMoreInfo.TabIndex = 7;
            this.bttnMoreInfo.Text = "More Info";
            this.bttnMoreInfo.UseVisualStyleBackColor = false;
            this.bttnMoreInfo.Click += new System.EventHandler(this.bttnMoreInfo_Click_1);
            // 
            // bttnTerms
            // 
            this.bttnTerms.BackColor = System.Drawing.Color.Peru;
            this.bttnTerms.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttnTerms.FlatAppearance.BorderSize = 0;
            this.bttnTerms.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnTerms.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnTerms.Location = new System.Drawing.Point(1059, 0);
            this.bttnTerms.Name = "bttnTerms";
            this.bttnTerms.Size = new System.Drawing.Size(129, 133);
            this.bttnTerms.TabIndex = 6;
            this.bttnTerms.Text = "Terms of Service";
            this.bttnTerms.UseVisualStyleBackColor = false;
            this.bttnTerms.Click += new System.EventHandler(this.bttnTerms_Click);
            // 
            // bttnExit
            // 
            this.bttnExit.BackColor = System.Drawing.Color.Peru;
            this.bttnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.bttnExit.FlatAppearance.BorderSize = 0;
            this.bttnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnExit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnExit.Location = new System.Drawing.Point(1188, 0);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(133, 133);
            this.bttnExit.TabIndex = 5;
            this.bttnExit.Text = "Exit Application";
            this.bttnExit.UseVisualStyleBackColor = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click_2);
            // 
            // bttnSearchMenu
            // 
            this.bttnSearchMenu.BackColor = System.Drawing.Color.Peru;
            this.bttnSearchMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.bttnSearchMenu.FlatAppearance.BorderSize = 0;
            this.bttnSearchMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSearchMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSearchMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnSearchMenu.Location = new System.Drawing.Point(570, 0);
            this.bttnSearchMenu.Name = "bttnSearchMenu";
            this.bttnSearchMenu.Size = new System.Drawing.Size(75, 133);
            this.bttnSearchMenu.TabIndex = 3;
            this.bttnSearchMenu.Text = "Search Member Menu";
            this.bttnSearchMenu.UseVisualStyleBackColor = false;
            this.bttnSearchMenu.Click += new System.EventHandler(this.bttnSearchMenu_Click_1);
            // 
            // panelSearchMenu
            // 
            this.panelSearchMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.panelSearchMenu.Controls.Add(this.txtBoxSearch);
            this.panelSearchMenu.Controls.Add(this.bttnSearch);
            this.panelSearchMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSearchMenu.Location = new System.Drawing.Point(370, 0);
            this.panelSearchMenu.Name = "panelSearchMenu";
            this.panelSearchMenu.Size = new System.Drawing.Size(200, 133);
            this.panelSearchMenu.TabIndex = 2;
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(0, 3);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(200, 20);
            this.txtBoxSearch.TabIndex = 9;
            // 
            // bttnSearch
            // 
            this.bttnSearch.BackColor = System.Drawing.Color.SandyBrown;
            this.bttnSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnSearch.FlatAppearance.BorderSize = 0;
            this.bttnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnSearch.Location = new System.Drawing.Point(0, 26);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Size = new System.Drawing.Size(200, 107);
            this.bttnSearch.TabIndex = 8;
            this.bttnSearch.Text = "Search Member";
            this.bttnSearch.UseVisualStyleBackColor = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click_1);
            // 
            // bttnMenu
            // 
            this.bttnMenu.BackColor = System.Drawing.Color.Peru;
            this.bttnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.bttnMenu.FlatAppearance.BorderSize = 0;
            this.bttnMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnMenu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnMenu.Location = new System.Drawing.Point(295, 0);
            this.bttnMenu.Name = "bttnMenu";
            this.bttnMenu.Size = new System.Drawing.Size(75, 133);
            this.bttnMenu.TabIndex = 1;
            this.bttnMenu.Text = "Member Menu";
            this.bttnMenu.UseVisualStyleBackColor = false;
            this.bttnMenu.Click += new System.EventHandler(this.bttnMenu_Click_1);
            // 
            // panelMemberMenu
            // 
            this.panelMemberMenu.BackColor = System.Drawing.Color.SandyBrown;
            this.panelMemberMenu.Controls.Add(this.bttnDelete);
            this.panelMemberMenu.Controls.Add(this.bttnEdit);
            this.panelMemberMenu.Controls.Add(this.bttnAdd);
            this.panelMemberMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMemberMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMemberMenu.Name = "panelMemberMenu";
            this.panelMemberMenu.Size = new System.Drawing.Size(295, 133);
            this.panelMemberMenu.TabIndex = 0;
            // 
            // bttnDelete
            // 
            this.bttnDelete.FlatAppearance.BorderSize = 0;
            this.bttnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnDelete.Location = new System.Drawing.Point(0, 87);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(295, 46);
            this.bttnDelete.TabIndex = 2;
            this.bttnDelete.Text = "Delete Member";
            this.bttnDelete.UseVisualStyleBackColor = false;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click_1);
            // 
            // bttnEdit
            // 
            this.bttnEdit.FlatAppearance.BorderSize = 0;
            this.bttnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnEdit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnEdit.Location = new System.Drawing.Point(0, 44);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(295, 43);
            this.bttnEdit.TabIndex = 1;
            this.bttnEdit.Text = "Edit Member";
            this.bttnEdit.UseVisualStyleBackColor = false;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click_1);
            // 
            // bttnAdd
            // 
            this.bttnAdd.FlatAppearance.BorderSize = 0;
            this.bttnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAdd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bttnAdd.Location = new System.Drawing.Point(0, 0);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(295, 43);
            this.bttnAdd.TabIndex = 0;
            this.bttnAdd.Text = "Add Member";
            this.bttnAdd.UseVisualStyleBackColor = false;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click_1);
            // 
            // panelApp
            // 
            this.panelApp.Controls.Add(this.lblBMITitle);
            this.panelApp.Controls.Add(this.lblRecTitle);
            this.panelApp.Controls.Add(this.lblBMIOut);
            this.panelApp.Controls.Add(this.lblDays);
            this.panelApp.Controls.Add(this.pictureBox1);
            this.panelApp.Controls.Add(this.lblID);
            this.panelApp.Controls.Add(this.bttnPrintReceipt);
            this.panelApp.Controls.Add(this.lblFullName);
            this.panelApp.Controls.Add(this.lblReceiptOut);
            this.panelApp.Controls.Add(this.lblMembStart);
            this.panelApp.Controls.Add(this.lblMembEnd);
            this.panelApp.Controls.Add(this.lblMembType);
            this.panelApp.Controls.Add(this.lblLocation);
            this.panelApp.Controls.Add(this.listBoxMembers);
            this.panelApp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelApp.Location = new System.Drawing.Point(0, 189);
            this.panelApp.Name = "panelApp";
            this.panelApp.Size = new System.Drawing.Size(1321, 583);
            this.panelApp.TabIndex = 29;
            // 
            // lblBMITitle
            // 
            this.lblBMITitle.AutoSize = true;
            this.lblBMITitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBMITitle.Location = new System.Drawing.Point(1168, 150);
            this.lblBMITitle.Name = "lblBMITitle";
            this.lblBMITitle.Size = new System.Drawing.Size(35, 20);
            this.lblBMITitle.TabIndex = 31;
            this.lblBMITitle.Text = "BMI";
            // 
            // lblRecTitle
            // 
            this.lblRecTitle.AutoSize = true;
            this.lblRecTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecTitle.Location = new System.Drawing.Point(1158, 340);
            this.lblRecTitle.Name = "lblRecTitle";
            this.lblRecTitle.Size = new System.Drawing.Size(59, 20);
            this.lblRecTitle.TabIndex = 30;
            this.lblRecTitle.Text = "Receipt";
            // 
            // lblBMIOut
            // 
            this.lblBMIOut.BackColor = System.Drawing.SystemColors.Window;
            this.lblBMIOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBMIOut.Location = new System.Drawing.Point(1066, 170);
            this.lblBMIOut.Name = "lblBMIOut";
            this.lblBMIOut.Size = new System.Drawing.Size(231, 158);
            this.lblBMIOut.TabIndex = 29;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project_GymMembershipApp.Properties.Resources.BudgetGymLogo;
            this.pictureBox1.InitialImage = global::Project_GymMembershipApp.Properties.Resources.BudgetGymLogo;
            this.pictureBox1.Location = new System.Drawing.Point(1086, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 110);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1321, 789);
            this.Controls.Add(this.panelApp);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.lblReceipt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Budget Gym";
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.panelStartHelp.ResumeLayout(false);
            this.panelStartHelp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxStartHelp)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelSearchMenu.ResumeLayout(false);
            this.panelSearchMenu.PerformLayout();
            this.panelMemberMenu.ResumeLayout(false);
            this.panelApp.ResumeLayout(false);
            this.panelApp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxMembers;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblMembStart;
        private System.Windows.Forms.Label lblMembEnd;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label lblMembType;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblReceipt;
        private System.Windows.Forms.Label lblReceiptOut;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bttnPrintReceipt;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button bttnMain;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button bttnMenu;
        private System.Windows.Forms.Panel panelMemberMenu;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Panel panelSearchMenu;
        private System.Windows.Forms.Button bttnMoreInfo;
        private System.Windows.Forms.Button bttnTerms;
        private System.Windows.Forms.Button bttnExit;
        private System.Windows.Forms.Button bttnSearchMenu;
        private System.Windows.Forms.TextBox txtBoxSearch;
        private System.Windows.Forms.Button bttnSearch;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelApp;
        private System.Windows.Forms.Button bttnAbout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelStartHelp;
        private System.Windows.Forms.PictureBox pictureBoxStartHelp;
        private System.Windows.Forms.Label lblStartHelp;
        private System.Windows.Forms.Label lblBMITitle;
        private System.Windows.Forms.Label lblRecTitle;
        private System.Windows.Forms.Label lblBMIOut;
    }
}

