namespace To_Do_Reminder_V1
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
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTaskTitle = new System.Windows.Forms.Label();
            this.lblPriority = new System.Windows.Forms.Label();
            this.lblToDo = new System.Windows.Forms.Label();
            this.lblShowTime = new System.Windows.Forms.Label();
            this.grpBoxToDo = new System.Windows.Forms.GroupBox();
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.lblDesc = new System.Windows.Forms.Label();
            this.lblPrio_ToDo = new System.Windows.Forms.Label();
            this.lblHour = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmboBoxPrio = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtBoxTaskTitle = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bttnAdd = new System.Windows.Forms.Button();
            this.bttnEdit = new System.Windows.Forms.Button();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblCurrTime = new System.Windows.Forms.Label();
            this.menuMain.SuspendLayout();
            this.grpBoxToDo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuMain
            // 
            this.menuMain.BackColor = System.Drawing.SystemColors.Control;
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(629, 24);
            this.menuMain.TabIndex = 0;
            this.menuMain.Text = "menuMain";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openFileToolStripMenuItem,
            this.saveFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openFileToolStripMenuItem
            // 
            this.openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            this.openFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F2)));
            this.openFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.openFileToolStripMenuItem.Text = "Open file";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F3)));
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.saveFileToolStripMenuItem.Text = "Save file";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblTaskTitle
            // 
            this.lblTaskTitle.AutoSize = true;
            this.lblTaskTitle.Location = new System.Drawing.Point(13, 33);
            this.lblTaskTitle.Name = "lblTaskTitle";
            this.lblTaskTitle.Size = new System.Drawing.Size(73, 13);
            this.lblTaskTitle.TabIndex = 1;
            this.lblTaskTitle.Text = "Date and time";
            // 
            // lblPriority
            // 
            this.lblPriority.AutoSize = true;
            this.lblPriority.Location = new System.Drawing.Point(501, 44);
            this.lblPriority.Name = "lblPriority";
            this.lblPriority.Size = new System.Drawing.Size(38, 13);
            this.lblPriority.TabIndex = 2;
            this.lblPriority.Text = "Priority";
            // 
            // lblToDo
            // 
            this.lblToDo.AutoSize = true;
            this.lblToDo.Location = new System.Drawing.Point(12, 97);
            this.lblToDo.Name = "lblToDo";
            this.lblToDo.Size = new System.Drawing.Size(87, 13);
            this.lblToDo.TabIndex = 3;
            this.lblToDo.Text = "Task Description";
            // 
            // lblShowTime
            // 
            this.lblShowTime.AutoSize = true;
            this.lblShowTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowTime.Location = new System.Drawing.Point(138, 411);
            this.lblShowTime.Name = "lblShowTime";
            this.lblShowTime.Size = new System.Drawing.Size(70, 25);
            this.lblShowTime.TabIndex = 4;
            this.lblShowTime.Text = "label4";
            // 
            // grpBoxToDo
            // 
            this.grpBoxToDo.Controls.Add(this.listBoxTasks);
            this.grpBoxToDo.Controls.Add(this.lblDesc);
            this.grpBoxToDo.Controls.Add(this.lblPrio_ToDo);
            this.grpBoxToDo.Controls.Add(this.lblHour);
            this.grpBoxToDo.Controls.Add(this.lblDate);
            this.grpBoxToDo.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBoxToDo.ForeColor = System.Drawing.Color.DarkGreen;
            this.grpBoxToDo.Location = new System.Drawing.Point(16, 143);
            this.grpBoxToDo.Name = "grpBoxToDo";
            this.grpBoxToDo.Size = new System.Drawing.Size(599, 256);
            this.grpBoxToDo.TabIndex = 5;
            this.grpBoxToDo.TabStop = false;
            this.grpBoxToDo.Text = "To Do";
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.Location = new System.Drawing.Point(6, 51);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(582, 199);
            this.listBoxTasks.TabIndex = 4;
            this.listBoxTasks.SelectedIndexChanged += new System.EventHandler(this.listBoxTasks_SelectedIndexChanged);
            // 
            // lblDesc
            // 
            this.lblDesc.AutoSize = true;
            this.lblDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDesc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDesc.Location = new System.Drawing.Point(295, 35);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(60, 13);
            this.lblDesc.TabIndex = 3;
            this.lblDesc.Text = "Description";
            // 
            // lblPrio_ToDo
            // 
            this.lblPrio_ToDo.AutoSize = true;
            this.lblPrio_ToDo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblPrio_ToDo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPrio_ToDo.Location = new System.Drawing.Point(220, 35);
            this.lblPrio_ToDo.Name = "lblPrio_ToDo";
            this.lblPrio_ToDo.Size = new System.Drawing.Size(38, 13);
            this.lblPrio_ToDo.TabIndex = 2;
            this.lblPrio_ToDo.Text = "Priority";
            // 
            // lblHour
            // 
            this.lblHour.AutoSize = true;
            this.lblHour.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblHour.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblHour.Location = new System.Drawing.Point(137, 35);
            this.lblHour.Name = "lblHour";
            this.lblHour.Size = new System.Drawing.Size(30, 13);
            this.lblHour.TabIndex = 1;
            this.lblHour.Text = "Hour";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDate.Location = new System.Drawing.Point(6, 35);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(30, 13);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date";
            // 
            // cmboBoxPrio
            // 
            this.cmboBoxPrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmboBoxPrio.FormattingEnabled = true;
            this.cmboBoxPrio.Location = new System.Drawing.Point(435, 60);
            this.cmboBoxPrio.Name = "cmboBoxPrio";
            this.cmboBoxPrio.Size = new System.Drawing.Size(182, 21);
            this.cmboBoxPrio.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(105, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(334, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // txtBoxTaskTitle
            // 
            this.txtBoxTaskTitle.Location = new System.Drawing.Point(105, 94);
            this.txtBoxTaskTitle.Name = "txtBoxTaskTitle";
            this.txtBoxTaskTitle.Size = new System.Drawing.Size(334, 20);
            this.txtBoxTaskTitle.TabIndex = 8;
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(314, 120);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(75, 23);
            this.bttnAdd.TabIndex = 9;
            this.bttnAdd.Text = "Add Task";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // bttnEdit
            // 
            this.bttnEdit.Location = new System.Drawing.Point(411, 120);
            this.bttnEdit.Name = "bttnEdit";
            this.bttnEdit.Size = new System.Drawing.Size(75, 23);
            this.bttnEdit.TabIndex = 10;
            this.bttnEdit.Text = "Edit Task";
            this.bttnEdit.UseVisualStyleBackColor = true;
            this.bttnEdit.Click += new System.EventHandler(this.bttnEdit_Click);
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(504, 120);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(75, 23);
            this.bttnDelete.TabIndex = 11;
            this.bttnDelete.Text = "Delete Task";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.bttnDelete_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblCurrTime
            // 
            this.lblCurrTime.AutoSize = true;
            this.lblCurrTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrTime.Location = new System.Drawing.Point(25, 415);
            this.lblCurrTime.Name = "lblCurrTime";
            this.lblCurrTime.Size = new System.Drawing.Size(104, 20);
            this.lblCurrTime.TabIndex = 12;
            this.lblCurrTime.Text = "Current Time:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 457);
            this.Controls.Add(this.lblCurrTime);
            this.Controls.Add(this.bttnDelete);
            this.Controls.Add(this.bttnEdit);
            this.Controls.Add(this.bttnAdd);
            this.Controls.Add(this.txtBoxTaskTitle);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmboBoxPrio);
            this.Controls.Add(this.grpBoxToDo);
            this.Controls.Add(this.lblShowTime);
            this.Controls.Add(this.lblToDo);
            this.Controls.Add(this.lblPriority);
            this.Controls.Add(this.lblTaskTitle);
            this.Controls.Add(this.menuMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuMain;
            this.Name = "MainForm";
            this.Text = "To Do Reminder";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.grpBoxToDo.ResumeLayout(false);
            this.grpBoxToDo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.Label lblTaskTitle;
        private System.Windows.Forms.Label lblPriority;
        private System.Windows.Forms.Label lblToDo;
        private System.Windows.Forms.Label lblShowTime;
        private System.Windows.Forms.GroupBox grpBoxToDo;
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Label lblPrio_ToDo;
        private System.Windows.Forms.Label lblHour;
        private System.Windows.Forms.ComboBox cmboBoxPrio;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtBoxTaskTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Button bttnEdit;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblCurrTime;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

