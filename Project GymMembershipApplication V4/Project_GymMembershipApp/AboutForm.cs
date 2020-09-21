using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_GymMembershipApp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
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
        /// <summary>
        /// Method if link does not work
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                LinkClick();
            }
            catch(Exception)
            {
                MessageBox.Show("Unable to open link");
            }

        }
        /// <summary>
        /// Link method
        /// </summary>
        private void LinkClick()
        {
            linkLabel1.LinkVisited = true;

            System.Diagnostics.Process.Start("https://icons8.com");
        }
    }
}
