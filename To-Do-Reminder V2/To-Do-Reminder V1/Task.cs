using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace To_Do_Reminder_V1
{
    class Task
    {
        // private fields for storing data
        private string m_description;
        private PriorityType m_priority;
        private DateTime m_dateTime;
        /// <summary>
        /// Constructor: default
        /// </summary>
        /// <param name="description"></param>
        /// <param name="priority"></param>
        /// <param name="dateTime"></param>
        public Task(string description, PriorityType priority, DateTime dateTime)
        {
            m_description = description;
            m_priority = priority;
            m_dateTime = dateTime;
        }
        /// <summary>
        /// Get and set property for description
        /// </summary>
        public string Description
        {
            get { return m_description; }
            set 
            { 
                if(!string.IsNullOrEmpty(value))
                    m_description = value;
            }
        }
        /// <summary>
        /// Get and set property for priority type
        /// </summary>
        public PriorityType Priority
        {
            get { return m_priority; }
            set 
            {
                if (Enum.IsDefined(typeof(PriorityType), value))
                    m_priority = value;
            }
        }
        /// <summary>
        /// Get and set property for date/time of task
        /// </summary>
        public DateTime DateForTask
        {
            get { return m_dateTime; }
            set { m_dateTime = value; }
        }
        /// <summary>
        ///  Method for converting time and minute to string
        /// </summary>
        /// <returns></returns>
        private string GetTimeString()
        {
            return m_dateTime.Hour.ToString() + " : " + m_dateTime.Minute.ToString("00");
        }
        /// <summary>
        /// Method for converting priority object to string
        /// Also removes underscores
        /// </summary>
        /// <returns></returns>
        private string GetPriorityToString()
        {
            return m_priority.ToString().Replace("_", " ");
        }
        /// <summary>
        /// A bool that checks if description
        /// or priority fields are empty
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            if (String.IsNullOrEmpty(m_description))
                return false;
            else if (m_priority == (PriorityType)(-1))
                return false;
            else
                return true;
        }
        /// <summary>
        /// To string overide to format strings for output into listbox
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Format("{0, -20}       {1, 10}        {2, 16}                  {3, -20}",
                m_dateTime.ToLongDateString(), GetTimeString(), GetPriorityToString(), Description);
            return strOut;
        }

    }
}
