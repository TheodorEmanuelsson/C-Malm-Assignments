using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_Reminder_V1
{
    public partial class MainForm : Form
    {
        // Taskmanager object
        TaskManager taskManager = new TaskManager();

        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Some initial instructions.
        /// 1) Clearing list, labels and txtboxes
        /// 2) start the timer
        /// 3) Show tool tip
        /// 4) Fill combobox with items and select default
        /// 5) Formating of datetime to show year, month, date, hour and minutes
        /// </summary>
        private void InitializeGUI()
        {
            listBoxTasks.Items.Clear();
            lblShowTime.Text = string.Empty;
            txtBoxTaskTitle.Text = string.Empty;

            bttnEdit.Enabled = false;
            bttnDelete.Enabled = false;

            timer1.Start();

            toolTip1.ShowAlways = true;
            toolTip1.SetToolTip(dateTimePicker1, "Click to open a calendar or enter time manually ");

            cmboBoxPrio.Items.Clear();
            FillPriorityComboBox();
            cmboBoxPrio.SelectedIndex = (int)PriorityType.Normal;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy-MM-dd      HH:mm";
        }
        /// <summary>
        /// Clear the items in the listbox and input textbox
        /// 
        /// Then recieves the list of tasks from the taskmanager in string array format
        /// then adds an item from that list until list is less than the number of tasks
        /// 
        /// </summary>
        private void UpdateGUI()
        {
            listBoxTasks.Items.Clear();
            txtBoxTaskTitle.Text = string.Empty;

            if(taskManager.NoTasks != 0)
            {
                string[] listTask = taskManager.ListToString();
                for(int index = 0; index < taskManager.NoTasks; index ++)
                {
                    listBoxTasks.Items.Add(listTask[index]);
                }
                ButtonEnabled();
            }
        }
        /// <summary>
        /// Enables edit and delete buttons if
        /// listbox item is selected
        /// </summary>
        private void ButtonEnabled()
        {
            if(listBoxTasks.SelectedIndex == -1)
            {
                bttnEdit.Enabled = false;
                bttnDelete.Enabled = false;
            }
            else
            {
                bttnDelete.Enabled = true;
                bttnEdit.Enabled = true;
            }
        }
        /// <summary>
        /// Method for filling the combobox with priority types
        /// Also removes underscores from string.
        /// </summary>
        private void FillPriorityComboBox()
        {
            string[] priority = Enum.GetNames(typeof(PriorityType));
            for (int i = 0; i < priority.Length; i++)
                cmboBoxPrio.Items.Add(priority[i].Replace("_", " "));
        }
        /// <summary>
        /// The timer to tick in label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblShowTime.Text = DateTime.Now.ToShortTimeString();
        }
        /// <summary>
        /// Add button for adding a new task to the listbox,
        /// Checks if current task in not null.
        /// Calls update to show print list in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAdd_Click(object sender, EventArgs e)
        {
            Task currTask = ReadInputs();

            if (currTask != null && currTask.CheckData() == true)
            {
                taskManager.AddTask(currTask);
                UpdateGUI();
            }
            else
                MessageBox.Show("You must input the task information to procede", "Error");
        }
        /// <summary>
        /// Reads description, prio and date.
        /// Validated description and that a priority has been selected
        /// </summary>
        /// <returns>the new task</returns>
        private Task ReadInputs()
        {
            string description;
            DateTime date = dateTimePicker1.Value;
            PriorityType prio = PriorityType.Normal;
            
            if (!string.IsNullOrEmpty(txtBoxTaskTitle.Text) && cmboBoxPrio.SelectedIndex != -1)
            {
                description = txtBoxTaskTitle.Text;
                prio = (PriorityType)cmboBoxPrio.SelectedIndex;
            }
            else
                return null;

            Task newTask = new Task(description, prio, date);
            return newTask;
          }

        /// <summary>
        /// Menu option for resetting the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InitializeGUI();
            taskManager.ClearList();
        }
        /// <summary>
        /// Menu option for exiting the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit this application?", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
                Application.Exit();
        }
        /// <summary>
        /// Delete button for deleting the selected task in listbox
        /// Deletes the taskmanager array item and the listbox string at index
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Want to delete currently selected task?", "Warning", MessageBoxButtons.YesNo);

            if(result == DialogResult.Yes)
            {
                int index = listBoxTasks.SelectedIndex;

                if (index >= 0)
                {
                    taskManager.DeleteTask(index);
                    listBoxTasks.Items.RemoveAt(index);
                    UpdateGUI();
                }
                else
                    MessageBox.Show("Select a task to delete", "Error");
            }
        }
        /// <summary>
        /// Button for editing selected task
        /// 1) Read the new input
        /// 2) Calls edit task with input the newtask and the selected index
        /// 3) Update list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnEdit_Click(object sender, EventArgs e)
        {
            int index = listBoxTasks.SelectedIndex;

            if (index >= 0 && txtBoxTaskTitle.Text != string.Empty)
            {
                Task currTask = ReadInputs();
                taskManager.EditTask(currTask, index);
                UpdateGUI();
            }
            else
                MessageBox.Show("Select a task to edit", "Error");
        }
        /// <summary>
        /// Saves the listbox items to a file (.txt most relevant).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();

            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFile.FileName);

                for (int index = 0; index < listBoxTasks.Items.Count; index++)
                    writer.WriteLine((string)listBoxTasks.Items[index]);
                writer.Close();
            }
            saveFile.Dispose();
        }
        /// <summary>
        /// Opens the aboutForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm abtfrm = new AboutForm();
            abtfrm.Show();
        }

        private void listBoxTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            ButtonEnabled();
        }

        // An attempt to make a read file method but couldnt make it work.

        //       private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        //      {
        //           using(OpenFileDialog ofd = new OpenFileDialog() 
        //          { Filter = "Text Documents(*.txt)|*.txt", ValidateNames = true,
        //          Multiselect = false})
        //          {
        //              if(ofd.ShowDialog() == DialogResult.OK)
        //             {
        //                  int index = System.IO.File.ReadLines(ofd.FileName).Count();
        //                 string[] tasks = System.IO.File.ReadAllLines(ofd.FileName);
        //
        //                  for(int i = 0; i < index; i++)
        //                  {
        //                       listBoxTasks.Items.Add(tasks);
        //                   }
        //               }

        //          }
        //      }
    }
}
