namespace Apu_s_Cook_Book
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
            this.grpBoxAddNewRecipe = new System.Windows.Forms.GroupBox();
            this.txtBoxDesc = new System.Windows.Forms.TextBox();
            this.bttnAddIngred = new System.Windows.Forms.Button();
            this.txtBoxNameOfRecipe = new System.Windows.Forms.TextBox();
            this.cmboBoxTypeRecipe = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblNameOfRecipe = new System.Windows.Forms.Label();
            this.bttnAddRecipe = new System.Windows.Forms.Button();
            this.lblNameSavedRecipe = new System.Windows.Forms.Label();
            this.lblNoIngred = new System.Windows.Forms.Label();
            this.lblCategorySaved = new System.Windows.Forms.Label();
            this.lblDiscrSaved = new System.Windows.Forms.Label();
            this.listBoxMainRecipe = new System.Windows.Forms.ListBox();
            this.bttnDeleteRecipe = new System.Windows.Forms.Button();
            this.lblNumItemsShow = new System.Windows.Forms.Label();
            this.lblCurrNumItems = new System.Windows.Forms.Label();
            this.grpBoxAddNewRecipe.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBoxAddNewRecipe
            // 
            this.grpBoxAddNewRecipe.Controls.Add(this.txtBoxDesc);
            this.grpBoxAddNewRecipe.Controls.Add(this.bttnAddIngred);
            this.grpBoxAddNewRecipe.Controls.Add(this.txtBoxNameOfRecipe);
            this.grpBoxAddNewRecipe.Controls.Add(this.cmboBoxTypeRecipe);
            this.grpBoxAddNewRecipe.Controls.Add(this.lblCategory);
            this.grpBoxAddNewRecipe.Controls.Add(this.lblNameOfRecipe);
            this.grpBoxAddNewRecipe.Location = new System.Drawing.Point(12, 12);
            this.grpBoxAddNewRecipe.Name = "grpBoxAddNewRecipe";
            this.grpBoxAddNewRecipe.Size = new System.Drawing.Size(423, 415);
            this.grpBoxAddNewRecipe.TabIndex = 0;
            this.grpBoxAddNewRecipe.TabStop = false;
            this.grpBoxAddNewRecipe.Text = "Add new recipe";
            // 
            // txtBoxDesc
            // 
            this.txtBoxDesc.AcceptsReturn = true;
            this.txtBoxDesc.AcceptsTab = true;
            this.txtBoxDesc.Location = new System.Drawing.Point(6, 98);
            this.txtBoxDesc.Multiline = true;
            this.txtBoxDesc.Name = "txtBoxDesc";
            this.txtBoxDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBoxDesc.Size = new System.Drawing.Size(411, 311);
            this.txtBoxDesc.TabIndex = 5;
            // 
            // bttnAddIngred
            // 
            this.bttnAddIngred.Location = new System.Drawing.Point(285, 63);
            this.bttnAddIngred.Name = "bttnAddIngred";
            this.bttnAddIngred.Size = new System.Drawing.Size(132, 29);
            this.bttnAddIngred.TabIndex = 4;
            this.bttnAddIngred.Text = "Add ingredients";
            this.bttnAddIngred.UseVisualStyleBackColor = true;
            this.bttnAddIngred.Click += new System.EventHandler(this.bttnAddIngred_Click);
            // 
            // txtBoxNameOfRecipe
            // 
            this.txtBoxNameOfRecipe.Location = new System.Drawing.Point(98, 27);
            this.txtBoxNameOfRecipe.Name = "txtBoxNameOfRecipe";
            this.txtBoxNameOfRecipe.Size = new System.Drawing.Size(319, 20);
            this.txtBoxNameOfRecipe.TabIndex = 3;
            // 
            // cmboBoxTypeRecipe
            // 
            this.cmboBoxTypeRecipe.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cmboBoxTypeRecipe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBoxTypeRecipe.FormattingEnabled = true;
            this.cmboBoxTypeRecipe.Location = new System.Drawing.Point(98, 63);
            this.cmboBoxTypeRecipe.Name = "cmboBoxTypeRecipe";
            this.cmboBoxTypeRecipe.Size = new System.Drawing.Size(121, 21);
            this.cmboBoxTypeRecipe.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(6, 66);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(49, 13);
            this.lblCategory.TabIndex = 1;
            this.lblCategory.Text = "Category";
            // 
            // lblNameOfRecipe
            // 
            this.lblNameOfRecipe.AutoSize = true;
            this.lblNameOfRecipe.Location = new System.Drawing.Point(6, 30);
            this.lblNameOfRecipe.Name = "lblNameOfRecipe";
            this.lblNameOfRecipe.Size = new System.Drawing.Size(79, 13);
            this.lblNameOfRecipe.TabIndex = 0;
            this.lblNameOfRecipe.Text = "Name of recipe";
            // 
            // bttnAddRecipe
            // 
            this.bttnAddRecipe.Location = new System.Drawing.Point(18, 433);
            this.bttnAddRecipe.Name = "bttnAddRecipe";
            this.bttnAddRecipe.Size = new System.Drawing.Size(411, 32);
            this.bttnAddRecipe.TabIndex = 1;
            this.bttnAddRecipe.Text = "Add Recipe";
            this.bttnAddRecipe.UseVisualStyleBackColor = true;
            this.bttnAddRecipe.Click += new System.EventHandler(this.bttnAddRecipe_Click);
            // 
            // lblNameSavedRecipe
            // 
            this.lblNameSavedRecipe.AutoSize = true;
            this.lblNameSavedRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblNameSavedRecipe.Location = new System.Drawing.Point(456, 35);
            this.lblNameSavedRecipe.Name = "lblNameSavedRecipe";
            this.lblNameSavedRecipe.Size = new System.Drawing.Size(35, 13);
            this.lblNameSavedRecipe.TabIndex = 2;
            this.lblNameSavedRecipe.Text = "Name";
            // 
            // lblNoIngred
            // 
            this.lblNoIngred.AutoSize = true;
            this.lblNoIngred.Location = new System.Drawing.Point(534, 22);
            this.lblNoIngred.Name = "lblNoIngred";
            this.lblNoIngred.Size = new System.Drawing.Size(39, 26);
            this.lblNoIngred.TabIndex = 3;
            this.lblNoIngred.Text = "No. of \r\ningred.";
            // 
            // lblCategorySaved
            // 
            this.lblCategorySaved.AutoSize = true;
            this.lblCategorySaved.Location = new System.Drawing.Point(569, 35);
            this.lblCategorySaved.Name = "lblCategorySaved";
            this.lblCategorySaved.Size = new System.Drawing.Size(49, 13);
            this.lblCategorySaved.TabIndex = 4;
            this.lblCategorySaved.Text = "Category";
            // 
            // lblDiscrSaved
            // 
            this.lblDiscrSaved.AutoSize = true;
            this.lblDiscrSaved.Location = new System.Drawing.Point(624, 35);
            this.lblDiscrSaved.Name = "lblDiscrSaved";
            this.lblDiscrSaved.Size = new System.Drawing.Size(60, 13);
            this.lblDiscrSaved.TabIndex = 5;
            this.lblDiscrSaved.Text = "Description";
            // 
            // listBoxMainRecipe
            // 
            this.listBoxMainRecipe.FormattingEnabled = true;
            this.listBoxMainRecipe.Location = new System.Drawing.Point(459, 51);
            this.listBoxMainRecipe.Name = "listBoxMainRecipe";
            this.listBoxMainRecipe.Size = new System.Drawing.Size(269, 368);
            this.listBoxMainRecipe.TabIndex = 6;
            // 
            // bttnDeleteRecipe
            // 
            this.bttnDeleteRecipe.Location = new System.Drawing.Point(590, 438);
            this.bttnDeleteRecipe.Name = "bttnDeleteRecipe";
            this.bttnDeleteRecipe.Size = new System.Drawing.Size(94, 23);
            this.bttnDeleteRecipe.TabIndex = 8;
            this.bttnDeleteRecipe.Text = "Delete Recipe";
            this.bttnDeleteRecipe.UseVisualStyleBackColor = true;
            this.bttnDeleteRecipe.Click += new System.EventHandler(this.bttnDeleteRecipe_Click);
            // 
            // lblNumItemsShow
            // 
            this.lblNumItemsShow.AutoSize = true;
            this.lblNumItemsShow.Location = new System.Drawing.Point(478, 452);
            this.lblNumItemsShow.Name = "lblNumItemsShow";
            this.lblNumItemsShow.Size = new System.Drawing.Size(13, 13);
            this.lblNumItemsShow.TabIndex = 9;
            this.lblNumItemsShow.Text = "0";
            // 
            // lblCurrNumItems
            // 
            this.lblCurrNumItems.AutoSize = true;
            this.lblCurrNumItems.Location = new System.Drawing.Point(440, 433);
            this.lblCurrNumItems.Name = "lblCurrNumItems";
            this.lblCurrNumItems.Size = new System.Drawing.Size(93, 13);
            this.lblCurrNumItems.TabIndex = 10;
            this.lblCurrNumItems.Text = "Number of recipes";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 480);
            this.Controls.Add(this.lblCurrNumItems);
            this.Controls.Add(this.lblNumItemsShow);
            this.Controls.Add(this.bttnDeleteRecipe);
            this.Controls.Add(this.listBoxMainRecipe);
            this.Controls.Add(this.lblDiscrSaved);
            this.Controls.Add(this.lblCategorySaved);
            this.Controls.Add(this.lblNoIngred);
            this.Controls.Add(this.lblNameSavedRecipe);
            this.Controls.Add(this.bttnAddRecipe);
            this.Controls.Add(this.grpBoxAddNewRecipe);
            this.Name = "MainForm";
            this.Text = "go";
            this.grpBoxAddNewRecipe.ResumeLayout(false);
            this.grpBoxAddNewRecipe.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpBoxAddNewRecipe;
        private System.Windows.Forms.TextBox txtBoxDesc;
        private System.Windows.Forms.Button bttnAddIngred;
        private System.Windows.Forms.TextBox txtBoxNameOfRecipe;
        private System.Windows.Forms.ComboBox cmboBoxTypeRecipe;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblNameOfRecipe;
        private System.Windows.Forms.Button bttnAddRecipe;
        private System.Windows.Forms.Label lblNameSavedRecipe;
        private System.Windows.Forms.Label lblNoIngred;
        private System.Windows.Forms.Label lblCategorySaved;
        private System.Windows.Forms.Label lblDiscrSaved;
        private System.Windows.Forms.ListBox listBoxMainRecipe;
        private System.Windows.Forms.Button bttnDeleteRecipe;
        private System.Windows.Forms.Label lblNumItemsShow;
        private System.Windows.Forms.Label lblCurrNumItems;
    }
}

