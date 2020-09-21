namespace Project_GymMembershipApp
{
    partial class MembershipForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MembershipForm));
            this.grpBoxName = new System.Windows.Forms.GroupBox();
            this.txtBoxPersonalNmbr = new System.Windows.Forms.TextBox();
            this.lblPersonalNmbr = new System.Windows.Forms.Label();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBoxEmailPhone = new System.Windows.Forms.GroupBox();
            this.txtBoxPhone = new System.Windows.Forms.TextBox();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.grpBoxDuration = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.lblEnd = new System.Windows.Forms.Label();
            this.lblStart = new System.Windows.Forms.Label();
            this.grpBoxMemberDetails = new System.Windows.Forms.GroupBox();
            this.cmboBoxLocation = new System.Windows.Forms.ComboBox();
            this.cmboBoxType = new System.Windows.Forms.ComboBox();
            this.lblLocation = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.bttnOK = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpBoxAddress = new System.Windows.Forms.GroupBox();
            this.txtBoxZipCode = new System.Windows.Forms.TextBox();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.lblZipCode = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.grpBoxBMI = new System.Windows.Forms.GroupBox();
            this.lblCM = new System.Windows.Forms.Label();
            this.lblKG = new System.Windows.Forms.Label();
            this.txtBoxHeight = new System.Windows.Forms.TextBox();
            this.txtBoxWeight = new System.Windows.Forms.TextBox();
            this.lblHeight = new System.Windows.Forms.Label();
            this.lblWeight = new System.Windows.Forms.Label();
            this.grpBoxName.SuspendLayout();
            this.grpBoxEmailPhone.SuspendLayout();
            this.grpBoxDuration.SuspendLayout();
            this.grpBoxMemberDetails.SuspendLayout();
            this.grpBoxAddress.SuspendLayout();
            this.grpBoxBMI.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxName
            // 
            this.grpBoxName.Controls.Add(this.txtBoxPersonalNmbr);
            this.grpBoxName.Controls.Add(this.lblPersonalNmbr);
            this.grpBoxName.Controls.Add(this.txtBoxLastName);
            this.grpBoxName.Controls.Add(this.txtBoxFirstName);
            this.grpBoxName.Controls.Add(this.lblLastName);
            this.grpBoxName.Controls.Add(this.lblFirstName);
            this.grpBoxName.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpBoxName.Location = new System.Drawing.Point(12, 12);
            this.grpBoxName.Name = "grpBoxName";
            this.grpBoxName.Size = new System.Drawing.Size(520, 177);
            this.grpBoxName.TabIndex = 0;
            this.grpBoxName.TabStop = false;
            this.grpBoxName.Text = "Name";
            // 
            // txtBoxPersonalNmbr
            // 
            this.txtBoxPersonalNmbr.Location = new System.Drawing.Point(134, 129);
            this.txtBoxPersonalNmbr.Name = "txtBoxPersonalNmbr";
            this.txtBoxPersonalNmbr.Size = new System.Drawing.Size(380, 29);
            this.txtBoxPersonalNmbr.TabIndex = 3;
            this.txtBoxPersonalNmbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPersonalNmbr_KeyPress);
            // 
            // lblPersonalNmbr
            // 
            this.lblPersonalNmbr.AutoSize = true;
            this.lblPersonalNmbr.Location = new System.Drawing.Point(6, 132);
            this.lblPersonalNmbr.Name = "lblPersonalNmbr";
            this.lblPersonalNmbr.Size = new System.Drawing.Size(131, 21);
            this.lblPersonalNmbr.TabIndex = 4;
            this.lblPersonalNmbr.Text = "Personal Number";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(134, 82);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(380, 29);
            this.txtBoxLastName.TabIndex = 2;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(134, 38);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(380, 29);
            this.txtBoxFirstName.TabIndex = 1;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(8, 85);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(84, 21);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(6, 38);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(86, 21);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name";
            // 
            // grpBoxEmailPhone
            // 
            this.grpBoxEmailPhone.Controls.Add(this.txtBoxPhone);
            this.grpBoxEmailPhone.Controls.Add(this.txtBoxEmail);
            this.grpBoxEmailPhone.Controls.Add(this.lblPhone);
            this.grpBoxEmailPhone.Controls.Add(this.lblEmail);
            this.grpBoxEmailPhone.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpBoxEmailPhone.Location = new System.Drawing.Point(543, 12);
            this.grpBoxEmailPhone.Name = "grpBoxEmailPhone";
            this.grpBoxEmailPhone.Size = new System.Drawing.Size(520, 139);
            this.grpBoxEmailPhone.TabIndex = 1;
            this.grpBoxEmailPhone.TabStop = false;
            this.grpBoxEmailPhone.Text = "Email and Phone";
            // 
            // txtBoxPhone
            // 
            this.txtBoxPhone.Location = new System.Drawing.Point(128, 74);
            this.txtBoxPhone.Name = "txtBoxPhone";
            this.txtBoxPhone.Size = new System.Drawing.Size(378, 29);
            this.txtBoxPhone.TabIndex = 5;
            this.txtBoxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxPhone_KeyPress);
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(128, 28);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(378, 29);
            this.txtBoxEmail.TabIndex = 4;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 77);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(116, 21);
            this.lblPhone.TabIndex = 2;
            this.lblPhone.Text = "Phone Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 31);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(108, 21);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email Address";
            // 
            // grpBoxDuration
            // 
            this.grpBoxDuration.Controls.Add(this.dateTimePickerEnd);
            this.grpBoxDuration.Controls.Add(this.dateTimePickerStart);
            this.grpBoxDuration.Controls.Add(this.lblEnd);
            this.grpBoxDuration.Controls.Add(this.lblStart);
            this.grpBoxDuration.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpBoxDuration.Location = new System.Drawing.Point(543, 302);
            this.grpBoxDuration.Name = "grpBoxDuration";
            this.grpBoxDuration.Size = new System.Drawing.Size(520, 152);
            this.grpBoxDuration.TabIndex = 2;
            this.grpBoxDuration.TabStop = false;
            this.grpBoxDuration.Text = "Membership Duration";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(282, 76);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(232, 29);
            this.dateTimePickerEnd.TabIndex = 11;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(10, 76);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(251, 29);
            this.dateTimePickerStart.TabIndex = 10;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(335, 46);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(138, 21);
            this.lblEnd.TabIndex = 1;
            this.lblEnd.Text = "Membership Ends:";
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(54, 46);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(143, 21);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "Membership starts:";
            // 
            // grpBoxMemberDetails
            // 
            this.grpBoxMemberDetails.Controls.Add(this.cmboBoxLocation);
            this.grpBoxMemberDetails.Controls.Add(this.cmboBoxType);
            this.grpBoxMemberDetails.Controls.Add(this.lblLocation);
            this.grpBoxMemberDetails.Controls.Add(this.lblType);
            this.grpBoxMemberDetails.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpBoxMemberDetails.Location = new System.Drawing.Point(543, 157);
            this.grpBoxMemberDetails.Name = "grpBoxMemberDetails";
            this.grpBoxMemberDetails.Size = new System.Drawing.Size(520, 139);
            this.grpBoxMemberDetails.TabIndex = 4;
            this.grpBoxMemberDetails.TabStop = false;
            this.grpBoxMemberDetails.Text = "Membership Details";
            // 
            // cmboBoxLocation
            // 
            this.cmboBoxLocation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBoxLocation.FormattingEnabled = true;
            this.cmboBoxLocation.Location = new System.Drawing.Point(138, 81);
            this.cmboBoxLocation.Name = "cmboBoxLocation";
            this.cmboBoxLocation.Size = new System.Drawing.Size(368, 29);
            this.cmboBoxLocation.TabIndex = 9;
            // 
            // cmboBoxType
            // 
            this.cmboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBoxType.FormattingEnabled = true;
            this.cmboBoxType.Location = new System.Drawing.Point(138, 38);
            this.cmboBoxType.Name = "cmboBoxType";
            this.cmboBoxType.Size = new System.Drawing.Size(368, 29);
            this.cmboBoxType.TabIndex = 8;
            // 
            // lblLocation
            // 
            this.lblLocation.AutoSize = true;
            this.lblLocation.Location = new System.Drawing.Point(6, 84);
            this.lblLocation.Name = "lblLocation";
            this.lblLocation.Size = new System.Drawing.Size(69, 21);
            this.lblLocation.TabIndex = 1;
            this.lblLocation.Text = "Location";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(6, 41);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(126, 21);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "Membeship type";
            // 
            // bttnOK
            // 
            this.bttnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttnOK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnOK.Location = new System.Drawing.Point(0, 503);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(1075, 43);
            this.bttnOK.TabIndex = 13;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnCancel.Location = new System.Drawing.Point(0, 460);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(1075, 43);
            this.bttnCancel.TabIndex = 12;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // grpBoxAddress
            // 
            this.grpBoxAddress.Controls.Add(this.txtBoxZipCode);
            this.grpBoxAddress.Controls.Add(this.txtBoxStreet);
            this.grpBoxAddress.Controls.Add(this.lblZipCode);
            this.grpBoxAddress.Controls.Add(this.lblStreet);
            this.grpBoxAddress.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpBoxAddress.Location = new System.Drawing.Point(12, 195);
            this.grpBoxAddress.Name = "grpBoxAddress";
            this.grpBoxAddress.Size = new System.Drawing.Size(520, 139);
            this.grpBoxAddress.TabIndex = 7;
            this.grpBoxAddress.TabStop = false;
            this.grpBoxAddress.Text = "Billing Information";
            // 
            // txtBoxZipCode
            // 
            this.txtBoxZipCode.Location = new System.Drawing.Point(98, 82);
            this.txtBoxZipCode.Name = "txtBoxZipCode";
            this.txtBoxZipCode.Size = new System.Drawing.Size(416, 29);
            this.txtBoxZipCode.TabIndex = 7;
            this.txtBoxZipCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxZipCode_KeyPress);
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(98, 38);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(416, 29);
            this.txtBoxStreet.TabIndex = 6;
            // 
            // lblZipCode
            // 
            this.lblZipCode.AutoSize = true;
            this.lblZipCode.Location = new System.Drawing.Point(6, 85);
            this.lblZipCode.Name = "lblZipCode";
            this.lblZipCode.Size = new System.Drawing.Size(72, 21);
            this.lblZipCode.TabIndex = 1;
            this.lblZipCode.Text = "Zip Code";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(6, 41);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(50, 21);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street";
            // 
            // grpBoxBMI
            // 
            this.grpBoxBMI.Controls.Add(this.lblCM);
            this.grpBoxBMI.Controls.Add(this.lblKG);
            this.grpBoxBMI.Controls.Add(this.txtBoxHeight);
            this.grpBoxBMI.Controls.Add(this.txtBoxWeight);
            this.grpBoxBMI.Controls.Add(this.lblHeight);
            this.grpBoxBMI.Controls.Add(this.lblWeight);
            this.grpBoxBMI.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpBoxBMI.Location = new System.Drawing.Point(12, 340);
            this.grpBoxBMI.Name = "grpBoxBMI";
            this.grpBoxBMI.Size = new System.Drawing.Size(520, 114);
            this.grpBoxBMI.TabIndex = 8;
            this.grpBoxBMI.TabStop = false;
            this.grpBoxBMI.Text = "Optional Information";
            // 
            // lblCM
            // 
            this.lblCM.AutoSize = true;
            this.lblCM.Location = new System.Drawing.Point(240, 80);
            this.lblCM.Name = "lblCM";
            this.lblCM.Size = new System.Drawing.Size(94, 21);
            this.lblCM.TabIndex = 9;
            this.lblCM.Text = "Centimeters";
            // 
            // lblKG
            // 
            this.lblKG.AutoSize = true;
            this.lblKG.Location = new System.Drawing.Point(240, 36);
            this.lblKG.Name = "lblKG";
            this.lblKG.Size = new System.Drawing.Size(80, 21);
            this.lblKG.TabIndex = 8;
            this.lblKG.Text = "Kilograms";
            // 
            // txtBoxHeight
            // 
            this.txtBoxHeight.Location = new System.Drawing.Point(98, 77);
            this.txtBoxHeight.Name = "txtBoxHeight";
            this.txtBoxHeight.Size = new System.Drawing.Size(136, 29);
            this.txtBoxHeight.TabIndex = 7;
            this.txtBoxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxHeight_KeyPress);
            // 
            // txtBoxWeight
            // 
            this.txtBoxWeight.Location = new System.Drawing.Point(98, 33);
            this.txtBoxWeight.Name = "txtBoxWeight";
            this.txtBoxWeight.Size = new System.Drawing.Size(136, 29);
            this.txtBoxWeight.TabIndex = 6;
            this.txtBoxWeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxWeight_KeyPress);
            // 
            // lblHeight
            // 
            this.lblHeight.AutoSize = true;
            this.lblHeight.Location = new System.Drawing.Point(22, 80);
            this.lblHeight.Name = "lblHeight";
            this.lblHeight.Size = new System.Drawing.Size(56, 21);
            this.lblHeight.TabIndex = 1;
            this.lblHeight.Text = "Height";
            // 
            // lblWeight
            // 
            this.lblWeight.AutoSize = true;
            this.lblWeight.Location = new System.Drawing.Point(19, 36);
            this.lblWeight.Name = "lblWeight";
            this.lblWeight.Size = new System.Drawing.Size(59, 21);
            this.lblWeight.TabIndex = 0;
            this.lblWeight.Text = "Weight";
            // 
            // MembershipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(1075, 546);
            this.Controls.Add(this.grpBoxBMI);
            this.Controls.Add(this.grpBoxAddress);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.grpBoxMemberDetails);
            this.Controls.Add(this.grpBoxDuration);
            this.Controls.Add(this.grpBoxEmailPhone);
            this.Controls.Add(this.grpBoxName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MembershipForm";
            this.Text = "MembershipForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MembershipForm_FormClosing);
            this.grpBoxName.ResumeLayout(false);
            this.grpBoxName.PerformLayout();
            this.grpBoxEmailPhone.ResumeLayout(false);
            this.grpBoxEmailPhone.PerformLayout();
            this.grpBoxDuration.ResumeLayout(false);
            this.grpBoxDuration.PerformLayout();
            this.grpBoxMemberDetails.ResumeLayout(false);
            this.grpBoxMemberDetails.PerformLayout();
            this.grpBoxAddress.ResumeLayout(false);
            this.grpBoxAddress.PerformLayout();
            this.grpBoxBMI.ResumeLayout(false);
            this.grpBoxBMI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpBoxEmailPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtBoxPhone;
        private System.Windows.Forms.TextBox txtBoxEmail;
        private System.Windows.Forms.GroupBox grpBoxDuration;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.GroupBox grpBoxMemberDetails;
        private System.Windows.Forms.ComboBox cmboBoxLocation;
        private System.Windows.Forms.ComboBox cmboBoxType;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Button bttnOK;
        private System.Windows.Forms.Button bttnCancel;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox grpBoxAddress;
        private System.Windows.Forms.TextBox txtBoxZipCode;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.Label lblZipCode;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtBoxPersonalNmbr;
        private System.Windows.Forms.Label lblPersonalNmbr;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox grpBoxBMI;
        private System.Windows.Forms.TextBox txtBoxHeight;
        private System.Windows.Forms.TextBox txtBoxWeight;
        private System.Windows.Forms.Label lblHeight;
        private System.Windows.Forms.Label lblWeight;
        private System.Windows.Forms.Label lblCM;
        private System.Windows.Forms.Label lblKG;
    }
}