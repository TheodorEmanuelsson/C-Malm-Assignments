using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_Reminder_V1
{
    class TaskManager
    {
        /// <summary>
        /// A list of tasks
        /// </summary>
        private List<Task> taskList;
        /// <summary>
        /// Constructor: default
        /// </summary>
        public TaskManager()
        { 
            taskList = new List<Task>(); 
        }
        /// <summary>
        /// An integer for counting tasks
        /// </summary>
        public int NoTasks
        {
            get
            {
                int count = taskList.Count;
                return count;
            }
        }
        /// <summary>
        /// 
        /// Add the inputed task into the list
        /// Also calls the sort method
        ///
        /// </summary>
        /// <param name="newTask"></param>
        public void AddTask(Task newTask)
        {
            taskList.Add(newTask);
            SortTasks();
        }
        /// <summary>
        /// Method for sorting the list in terms of time
        /// </summary>
        public void SortTasks()
        {
            taskList.Sort((x, y) => x.DateForTask.CompareTo(y.DateForTask));
        }

        /// <summary>
        /// Bool for deleting task as inputed index
        /// 
        /// </summary>
        /// <param name="index">Input index, selected in listbox</param>
        /// <returns>true if removed, false if not removed</returns>
        public bool DeleteTask(int index)
        {
            if (index >= 0)
            {
                taskList.RemoveAt(index);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Method for editing a selected task.
        /// Works by removing the task at inputed index.
        /// and then adding the new inputed task.
        /// Then calls for sorting the list.
        /// </summary>
        /// <param name="newTask">The new task object</param>
        /// <param name="index">Input index, selected in listbox</param>
        public void EditTask(Task newTask, int index)
        {
            taskList.RemoveAt(index);
            taskList.Add(newTask);
            SortTasks();
        }
        /// <summary>
        /// Clears the tasklist of elements
        /// </summary>
        public void ClearList()
        {
            taskList.Clear();
        }
        /// <summary>
        /// Format the tasklist to an array string
        /// Used for showing the current list in string
        /// </summary>
        /// <returns></returns>
        public string[] ListToString()
        {
            string[] taskArray = new string[NoTasks];
            for (int i = 0; i < NoTasks; i++)
            {
                taskArray[i] = taskList[i].ToString();

            }

            return taskArray;
        }
    }
}
