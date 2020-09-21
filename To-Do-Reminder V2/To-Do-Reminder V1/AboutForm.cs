using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace To_Do_Reminder_V1
{
    public partial class AboutForm : Form
    {
        /// <summary>
        /// The about form
        /// </summary>
        public AboutForm()
        {
            InitializeComponent();
            AboutInfo();
        }
        /// <summary>
        /// Formating the string that contains the information
        /// </summary>
        public void AboutInfo()
        {
            string newLine = Environment.NewLine;
            lblAbout.Text = 
                "About" + newLine + 
                "To-Do-Reminder V2." + newLine +
                "By: Theodor Emanuelsson." + newLine +
                "For course in C# at Malmö University." + newLine +
                "Spring 2020.";
        }
        /// <summary>
        /// Close form button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
