namespace Apu_s_Cook_Book
{
    partial class FormIngredient
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
            this.grpBoxIngredSub = new System.Windows.Forms.GroupBox();
            this.bttnDelIngredSub = new System.Windows.Forms.Button();
            this.bttnEditIngredSub = new System.Windows.Forms.Button();
            this.bttnAddIngredSub = new System.Windows.Forms.Button();
            this.listBoxIngredSub = new System.Windows.Forms.ListBox();
            this.txtBoxAddIngredSub = new System.Windows.Forms.TextBox();
            this.lblNoIngredSub = new System.Windows.Forms.Label();
            this.lblCurrNoIngredSub = new System.Windows.Forms.Label();
            this.bttnOKSub = new System.Windows.Forms.Button();
            this.bttnCancelSub = new System.Windows.Forms.Button();
            this.grpBoxIngredSub.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxIngredSub
            // 
            this.grpBoxIngredSub.Controls.Add(this.bttnDelIngredSub);
            this.grpBoxIngredSub.Controls.Add(this.bttnEditIngredSub);
            this.grpBoxIngredSub.Controls.Add(this.bttnAddIngredSub);
            this.grpBoxIngredSub.Controls.Add(this.listBoxIngredSub);
            this.grpBoxIngredSub.Controls.Add(this.txtBoxAddIngredSub);
            this.grpBoxIngredSub.Location = new System.Drawing.Point(12, 60);
            this.grpBoxIngredSub.Name = "grpBoxIngredSub";
            this.grpBoxIngredSub.Size = new System.Drawing.Size(470, 332);
            this.grpBoxIngredSub.TabIndex = 0;
            this.grpBoxIngredSub.TabStop = false;
            this.grpBoxIngredSub.Text = "Ingredient";
            // 
            // bttnDelIngredSub
            // 
            this.bttnDelIngredSub.Location = new System.Drawing.Point(389, 163);
            this.bttnDelIngredSub.Name = "bttnDelIngredSub";
            this.bttnDelIngredSub.Size = new System.Drawing.Size(75, 23);
            this.bttnDelIngredSub.TabIndex = 4;
            this.bttnDelIngredSub.Text = "Delete";
            this.bttnDelIngredSub.UseVisualStyleBackColor = true;
            this.bttnDelIngredSub.Click += new System.EventHandler(this.bttnDelIngredSub_Click);
            // 
            // bttnEditIngredSub
            // 
            this.bttnEditIngredSub.Location = new System.Drawing.Point(389, 134);
            this.bttnEditIngredSub.Name = "bttnEditIngredSub";
            this.bttnEditIngredSub.Size = new System.Drawing.Size(75, 23);
            this.bttnEditIngredSub.TabIndex = 3;
            this.bttnEditIngredSub.Text = "Edit";
            this.bttnEditIngredSub.UseVisualStyleBackColor = true;
            this.bttnEditIngredSub.Click += new System.EventHandler(this.bttnEditIngredSub_Click);
            // 
            // bttnAddIngredSub
            // 
            this.bttnAddIngredSub.Location = new System.Drawing.Point(389, 16);
            this.bttnAddIngredSub.Name = "bttnAddIngredSub";
            this.bttnAddIngredSub.Size = new System.Drawing.Size(75, 23);
            this.bttnAddIngredSub.TabIndex = 2;
            this.bttnAddIngredSub.Text = "Add";
            this.bttnAddIngredSub.UseVisualStyleBackColor = true;
            this.bttnAddIngredSub.Click += new System.EventHandler(this.bttnAddIngredSub_Click);
            // 
            // listBoxIngredSub
            // 
            this.listBoxIngredSub.FormattingEnabled = true;
            this.listBoxIngredSub.Location = new System.Drawing.Point(6, 45);
            this.listBoxIngredSub.Name = "listBoxIngredSub";
            this.listBoxIngredSub.Size = new System.Drawing.Size(372, 277);
            this.listBoxIngredSub.TabIndex = 1;
            this.listBoxIngredSub.SelectedIndexChanged += new System.EventHandler(this.listBoxIngredSub_SelectedIndexChanged);
            // 
            // txtBoxAddIngredSub
            // 
            this.txtBoxAddIngredSub.Location = new System.Drawing.Point(6, 19);
            this.txtBoxAddIngredSub.Name = "txtBoxAddIngredSub";
            this.txtBoxAddIngredSub.Size = new System.Drawing.Size(372, 20);
            this.txtBoxAddIngredSub.TabIndex = 0;
            // 
            // lblNoIngredSub
            // 
            this.lblNoIngredSub.AutoSize = true;
            this.lblNoIngredSub.Location = new System.Drawing.Point(12, 29);
            this.lblNoIngredSub.Name = "lblNoIngredSub";
            this.lblNoIngredSub.Size = new System.Drawing.Size(148, 13);
            this.lblNoIngredSub.TabIndex = 1;
            this.lblNoIngredSub.Text = "Current number of ingredients:";
            // 
            // lblCurrNoIngredSub
            // 
            this.lblCurrNoIngredSub.AutoSize = true;
            this.lblCurrNoIngredSub.Location = new System.Drawing.Point(398, 29);
            this.lblCurrNoIngredSub.Name = "lblCurrNoIngredSub";
            this.lblCurrNoIngredSub.Size = new System.Drawing.Size(70, 13);
            this.lblCurrNoIngredSub.TabIndex = 2;
            this.lblCurrNoIngredSub.Text = "CurrNoIngred";
            // 
            // bttnOKSub
            // 
            this.bttnOKSub.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bttnOKSub.Location = new System.Drawing.Point(82, 403);
            this.bttnOKSub.Name = "bttnOKSub";
            this.bttnOKSub.Size = new System.Drawing.Size(117, 23);
            this.bttnOKSub.TabIndex = 3;
            this.bttnOKSub.Text = "OK";
            this.bttnOKSub.UseVisualStyleBackColor = true;
            // 
            // bttnCancelSub
            // 
            this.bttnCancelSub.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.bttnCancelSub.Location = new System.Drawing.Point(253, 403);
            this.bttnCancelSub.Name = "bttnCancelSub";
            this.bttnCancelSub.Size = new System.Drawing.Size(117, 23);
            this.bttnCancelSub.TabIndex = 4;
            this.bttnCancelSub.Text = "Cancel";
            this.bttnCancelSub.UseVisualStyleBackColor = true;
            // 
            // FormIngredient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 438);
            this.Controls.Add(this.bttnCancelSub);
            this.Controls.Add(this.bttnOKSub);
            this.Controls.Add(this.lblCurrNoIngredSub);
            this.Controls.Add(this.lblNoIngredSub);
            this.Controls.Add(this.grpBoxIngredSub);
            this.Name = "FormIngredient";
            this.Text = "FormIngredient";
            this.grpBoxIngredSub.ResumeLayout(false);
            this.grpBoxIngredSub.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxIngredSub;
        private System.Windows.Forms.Button bttnDelIngredSub;
        private System.Windows.Forms.Button bttnEditIngredSub;
        private System.Windows.Forms.Button bttnAddIngredSub;
        private System.Windows.Forms.ListBox listBoxIngredSub;
        private System.Windows.Forms.TextBox txtBoxAddIngredSub;
        private System.Windows.Forms.Label lblNoIngredSub;
        private System.Windows.Forms.Label lblCurrNoIngredSub;
        private System.Windows.Forms.Button bttnOKSub;
        private System.Windows.Forms.Button bttnCancelSub;
    }
}