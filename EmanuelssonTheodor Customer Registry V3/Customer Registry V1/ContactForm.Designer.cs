namespace Customer_Registry_V1
{
    partial class ContactForm
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
            this.grpBoxName = new System.Windows.Forms.GroupBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.lblNameLast = new System.Windows.Forms.Label();
            this.lblNameFirst = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.grpBoxEmailPhone = new System.Windows.Forms.GroupBox();
            this.txtBoxEmailPriv = new System.Windows.Forms.TextBox();
            this.txtBoxEmailBusi = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneCell = new System.Windows.Forms.TextBox();
            this.txtBoxPhoneHome = new System.Windows.Forms.TextBox();
            this.lblEmailPriv = new System.Windows.Forms.Label();
            this.lblEmailBusi = new System.Windows.Forms.Label();
            this.lblPhoneCell = new System.Windows.Forms.Label();
            this.lblPhoneHome = new System.Windows.Forms.Label();
            this.grpBoxAddress = new System.Windows.Forms.GroupBox();
            this.cmboBoxCountry = new System.Windows.Forms.ComboBox();
            this.txtBoxZip = new System.Windows.Forms.TextBox();
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.txtBoxStreet = new System.Windows.Forms.TextBox();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblZip = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.bttnOK = new System.Windows.Forms.Button();
            this.bttnCancel = new System.Windows.Forms.Button();
            this.grpBoxName.SuspendLayout();
            this.grpBoxEmailPhone.SuspendLayout();
            this.grpBoxAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxName
            // 
            this.grpBoxName.BackColor = System.Drawing.Color.LightSteelBlue;
            this.grpBoxName.Controls.Add(this.txtBoxLastName);
            this.grpBoxName.Controls.Add(this.txtBoxFirstName);
            this.grpBoxName.Controls.Add(this.lblNameLast);
            this.grpBoxName.Controls.Add(this.lblNameFirst);
            this.grpBoxName.Location = new System.Drawing.Point(18, 18);
            this.grpBoxName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxName.Name = "grpBoxName";
            this.grpBoxName.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxName.Size = new System.Drawing.Size(591, 146);
            this.grpBoxName.TabIndex = 0;
            this.grpBoxName.TabStop = false;
            this.grpBoxName.Text = "Name";
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(154, 79);
            this.txtBoxLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(426, 27);
            this.txtBoxLastName.TabIndex = 3;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(154, 37);
            this.txtBoxFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(426, 27);
            this.txtBoxFirstName.TabIndex = 2;
            // 
            // lblNameLast
            // 
            this.lblNameLast.AutoSize = true;
            this.lblNameLast.Location = new System.Drawing.Point(33, 83);
            this.lblNameLast.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameLast.Name = "lblNameLast";
            this.lblNameLast.Size = new System.Drawing.Size(80, 19);
            this.lblNameLast.TabIndex = 1;
            this.lblNameLast.Text = "Last Name";
            // 
            // lblNameFirst
            // 
            this.lblNameFirst.AutoSize = true;
            this.lblNameFirst.Location = new System.Drawing.Point(33, 41);
            this.lblNameFirst.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameFirst.Name = "lblNameFirst";
            this.lblNameFirst.Size = new System.Drawing.Size(81, 19);
            this.lblNameFirst.TabIndex = 0;
            this.lblNameFirst.Text = "First Name";
            // 
            // grpBoxEmailPhone
            // 
            this.grpBoxEmailPhone.Controls.Add(this.txtBoxEmailPriv);
            this.grpBoxEmailPhone.Controls.Add(this.txtBoxEmailBusi);
            this.grpBoxEmailPhone.Controls.Add(this.txtBoxPhoneCell);
            this.grpBoxEmailPhone.Controls.Add(this.txtBoxPhoneHome);
            this.grpBoxEmailPhone.Controls.Add(this.lblEmailPriv);
            this.grpBoxEmailPhone.Controls.Add(this.lblEmailBusi);
            this.grpBoxEmailPhone.Controls.Add(this.lblPhoneCell);
            this.grpBoxEmailPhone.Controls.Add(this.lblPhoneHome);
            this.grpBoxEmailPhone.Location = new System.Drawing.Point(18, 172);
            this.grpBoxEmailPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxEmailPhone.Name = "grpBoxEmailPhone";
            this.grpBoxEmailPhone.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxEmailPhone.Size = new System.Drawing.Size(591, 208);
            this.grpBoxEmailPhone.TabIndex = 1;
            this.grpBoxEmailPhone.TabStop = false;
            this.grpBoxEmailPhone.Text = "Email and Phone";
            // 
            // txtBoxEmailPriv
            // 
            this.txtBoxEmailPriv.Location = new System.Drawing.Point(154, 164);
            this.txtBoxEmailPriv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxEmailPriv.Name = "txtBoxEmailPriv";
            this.txtBoxEmailPriv.Size = new System.Drawing.Size(426, 27);
            this.txtBoxEmailPriv.TabIndex = 7;
            // 
            // txtBoxEmailBusi
            // 
            this.txtBoxEmailBusi.Location = new System.Drawing.Point(154, 121);
            this.txtBoxEmailBusi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxEmailBusi.Name = "txtBoxEmailBusi";
            this.txtBoxEmailBusi.Size = new System.Drawing.Size(426, 27);
            this.txtBoxEmailBusi.TabIndex = 6;
            // 
            // txtBoxPhoneCell
            // 
            this.txtBoxPhoneCell.Location = new System.Drawing.Point(154, 80);
            this.txtBoxPhoneCell.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPhoneCell.Name = "txtBoxPhoneCell";
            this.txtBoxPhoneCell.Size = new System.Drawing.Size(426, 27);
            this.txtBoxPhoneCell.TabIndex = 5;
            // 
            // txtBoxPhoneHome
            // 
            this.txtBoxPhoneHome.Location = new System.Drawing.Point(154, 42);
            this.txtBoxPhoneHome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxPhoneHome.Name = "txtBoxPhoneHome";
            this.txtBoxPhoneHome.Size = new System.Drawing.Size(426, 27);
            this.txtBoxPhoneHome.TabIndex = 4;
            // 
            // lblEmailPriv
            // 
            this.lblEmailPriv.AutoSize = true;
            this.lblEmailPriv.Location = new System.Drawing.Point(33, 168);
            this.lblEmailPriv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailPriv.Name = "lblEmailPriv";
            this.lblEmailPriv.Size = new System.Drawing.Size(97, 19);
            this.lblEmailPriv.TabIndex = 4;
            this.lblEmailPriv.Text = "Private Email";
            // 
            // lblEmailBusi
            // 
            this.lblEmailBusi.AutoSize = true;
            this.lblEmailBusi.Location = new System.Drawing.Point(33, 126);
            this.lblEmailBusi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmailBusi.Name = "lblEmailBusi";
            this.lblEmailBusi.Size = new System.Drawing.Size(106, 19);
            this.lblEmailBusi.TabIndex = 3;
            this.lblEmailBusi.Text = "Business Email";
            // 
            // lblPhoneCell
            // 
            this.lblPhoneCell.AutoSize = true;
            this.lblPhoneCell.Location = new System.Drawing.Point(33, 85);
            this.lblPhoneCell.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneCell.Name = "lblPhoneCell";
            this.lblPhoneCell.Size = new System.Drawing.Size(80, 19);
            this.lblPhoneCell.TabIndex = 2;
            this.lblPhoneCell.Text = "Cell Phone";
            // 
            // lblPhoneHome
            // 
            this.lblPhoneHome.AutoSize = true;
            this.lblPhoneHome.Location = new System.Drawing.Point(33, 47);
            this.lblPhoneHome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhoneHome.Name = "lblPhoneHome";
            this.lblPhoneHome.Size = new System.Drawing.Size(96, 19);
            this.lblPhoneHome.TabIndex = 1;
            this.lblPhoneHome.Text = "Home Phone";
            // 
            // grpBoxAddress
            // 
            this.grpBoxAddress.Controls.Add(this.cmboBoxCountry);
            this.grpBoxAddress.Controls.Add(this.txtBoxZip);
            this.grpBoxAddress.Controls.Add(this.txtBoxCity);
            this.grpBoxAddress.Controls.Add(this.txtBoxStreet);
            this.grpBoxAddress.Controls.Add(this.lblCountry);
            this.grpBoxAddress.Controls.Add(this.lblZip);
            this.grpBoxAddress.Controls.Add(this.lblCity);
            this.grpBoxAddress.Controls.Add(this.lblStreet);
            this.grpBoxAddress.Location = new System.Drawing.Point(18, 389);
            this.grpBoxAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxAddress.Name = "grpBoxAddress";
            this.grpBoxAddress.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBoxAddress.Size = new System.Drawing.Size(591, 212);
            this.grpBoxAddress.TabIndex = 2;
            this.grpBoxAddress.TabStop = false;
            this.grpBoxAddress.Text = "Address";
            // 
            // cmboBoxCountry
            // 
            this.cmboBoxCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBoxCountry.FormattingEnabled = true;
            this.cmboBoxCountry.Location = new System.Drawing.Point(154, 164);
            this.cmboBoxCountry.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmboBoxCountry.Name = "cmboBoxCountry";
            this.cmboBoxCountry.Size = new System.Drawing.Size(426, 27);
            this.cmboBoxCountry.TabIndex = 12;
            // 
            // txtBoxZip
            // 
            this.txtBoxZip.Location = new System.Drawing.Point(154, 123);
            this.txtBoxZip.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxZip.Name = "txtBoxZip";
            this.txtBoxZip.Size = new System.Drawing.Size(426, 27);
            this.txtBoxZip.TabIndex = 11;
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(154, 85);
            this.txtBoxCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(426, 27);
            this.txtBoxCity.TabIndex = 10;
            // 
            // txtBoxStreet
            // 
            this.txtBoxStreet.Location = new System.Drawing.Point(154, 41);
            this.txtBoxStreet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBoxStreet.Name = "txtBoxStreet";
            this.txtBoxStreet.Size = new System.Drawing.Size(426, 27);
            this.txtBoxStreet.TabIndex = 9;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(33, 168);
            this.lblCountry.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(62, 19);
            this.lblCountry.TabIndex = 8;
            this.lblCountry.Text = "Country";
            // 
            // lblZip
            // 
            this.lblZip.AutoSize = true;
            this.lblZip.Location = new System.Drawing.Point(33, 127);
            this.lblZip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblZip.Name = "lblZip";
            this.lblZip.Size = new System.Drawing.Size(68, 19);
            this.lblZip.TabIndex = 7;
            this.lblZip.Text = "Zip Code";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(33, 89);
            this.lblCity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(36, 19);
            this.lblCity.TabIndex = 6;
            this.lblCity.Text = "City";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(33, 45);
            this.lblStreet.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(51, 19);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "Street";
            // 
            // bttnOK
            // 
            this.bttnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttnOK.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnOK.Location = new System.Drawing.Point(0, 654);
            this.bttnOK.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnOK.Name = "bttnOK";
            this.bttnOK.Size = new System.Drawing.Size(628, 48);
            this.bttnOK.TabIndex = 3;
            this.bttnOK.Text = "OK";
            this.bttnOK.UseVisualStyleBackColor = true;
            this.bttnOK.Click += new System.EventHandler(this.bttnOK_Click);
            // 
            // bttnCancel
            // 
            this.bttnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bttnCancel.Location = new System.Drawing.Point(0, 606);
            this.bttnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(628, 48);
            this.bttnCancel.TabIndex = 4;
            this.bttnCancel.Text = "Cancel";
            this.bttnCancel.UseVisualStyleBackColor = true;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // ContactForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(628, 702);
            this.Controls.Add(this.bttnCancel);
            this.Controls.Add(this.bttnOK);
            this.Controls.Add(this.grpBoxAddress);
            this.Controls.Add(this.grpBoxEmailPhone);
            this.Controls.Add(this.grpBoxName);
            this.Font = new System.Drawing.Font("Corbel", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ContactForm";
            this.Text = "Customer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ContactForm_FormClosing);
            this.grpBoxName.ResumeLayout(false);
            this.grpBoxName.PerformLayout();
            this.grpBoxEmailPhone.ResumeLayout(false);
            this.grpBoxEmailPhone.PerformLayout();
            this.grpBoxAddress.ResumeLayout(false);
            this.grpBoxAddress.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxName;
        private System.Windows.Forms.TextBox txtBoxLastName;
        private System.Windows.Forms.TextBox txtBoxFirstName;
        private System.Windows.Forms.Label lblNameLast;
        private System.Windows.Forms.Label lblNameFirst;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox grpBoxEmailPhone;
        private System.Windows.Forms.TextBox txtBoxEmailPriv;
        private System.Windows.Forms.TextBox txtBoxEmailBusi;
        private System.Windows.Forms.TextBox txtBoxPhoneCell;
        private System.Windows.Forms.TextBox txtBoxPhoneHome;
        private System.Windows.Forms.Label lblEmailPriv;
        private System.Windows.Forms.Label lblEmailBusi;
        private System.Windows.Forms.Label lblPhoneCell;
        private System.Windows.Forms.Label lblPhoneHome;
        private System.Windows.Forms.GroupBox grpBoxAddress;
        private System.Windows.Forms.TextBox txtBoxZip;
        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.TextBox txtBoxStreet;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblZip;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.ComboBox cmboBoxCountry;
        private System.Windows.Forms.Button bttnOK;
        private System.Windows.Forms.Button bttnCancel;
    }
}