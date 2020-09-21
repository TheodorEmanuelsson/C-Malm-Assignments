using Project_GymMembershipApp.MembershipFiles;
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
    public partial class MainForm : Form
    {
        MembershipManager membMngr = new MembershipManager();
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }
        /// <summary>
        /// Initialize
        /// </summary>
        public void InitializeGUI()
        {
            panelMemberMenu.Visible = false;
            panelSearchMenu.Visible = false;
            panelMenu.Visible = false;
            panelStartHelp.Visible = true;

            ToolTips();
        }
        /// <summary>
        /// Tool tip method
        /// </summary>
        private void ToolTips()
        {
            toolTip1.SetToolTip(bttnMain, "Click to open the application menu");
            toolTip1.SetToolTip(bttnMenu, "Click to open Add, Edit and Delete Member menu");
            toolTip1.SetToolTip(bttnAdd, "Click to add a new member");
            toolTip1.SetToolTip(bttnEdit, "Select a member in the list to edit");
            toolTip1.SetToolTip(bttnDelete, "Select a member in the list to delete");
            toolTip1.SetToolTip(bttnSearchMenu, "Click to open search menu");
            toolTip1.SetToolTip(bttnSearch, "Enter full name of member to search for in textbox above. Click to search");
            toolTip1.SetToolTip(bttnMoreInfo, "Click to view member information");
            toolTip1.SetToolTip(bttnTerms, "Click exit application");
            toolTip1.SetToolTip(txtBoxSearch, "Enter the full name of a member");

            toolTip1.SetToolTip(lblReceiptOut, "The membership cost of selected member");
            toolTip1.SetToolTip(lblReceipt, "The membership cost of selected member");
        }
        /// <summary>
        /// Update GUI by clearing and adding members
        /// </summary>
        public void UpdateGUI()
        {
            listBoxMembers.Items.Clear();
            listBoxMembers.Items.AddRange(membMngr.GetMemberInfo());
            lblReceiptOut.Text = string.Empty;
            HideMenus();
        }
        /// <summary>
        /// Hides member and search menu
        /// </summary>
        public void HideMenus()
        {
            if (panelMemberMenu.Visible == true)
                panelMemberMenu.Visible = false;
            if (panelSearchMenu.Visible == true)
                panelSearchMenu.Visible = false;
        }
        /// <summary>
        /// Shows inputed menu
        /// </summary>
        /// <param name="panelMenu"></param>
        public void ShowMenus(Panel panelMenu)
        {
            if (panelMenu.Visible == false)
            {
                HideMenus();
                panelMenu.Visible = true;
            }
            else
                panelMenu.Visible = false;
        }

        /// <summary>
        /// Shows BMI info in label
        /// </summary>
        /// <param name="index"></param>
        private void ShowInfo(int index)
        {
            lblReceiptOut.Text = membMngr.GetMember(index).Receipt;
            lblBMIOut.Text = membMngr.GetMember(index).MemberData.BMIInfo.BMIOutput;

        }
        /// <summary>
        /// When index is changed, updates receipt and BMI info
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxMembers_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBoxMembers.SelectedIndex;

            if (index != -1)
            {
                ShowInfo(index);
            }
        }
        /// <summary>
        /// print receipt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = Properties.Resources.BudgetGymLogo;
            Image newImage = bmp;

            e.Graphics.DrawImage(newImage, 25, 25, newImage.Width, newImage.Height);
            e.Graphics.DrawString(lblReceiptOut.Text, new Font("Times New Roman", 14, FontStyle.Regular), Brushes.Black, new PointF(100, 100));
        }
        /// <summary>
        /// Print button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnPrintReceipt_Click(object sender, EventArgs e)
        {
            int index = listBoxMembers.SelectedIndex;

            if (index != -1)
            {
                if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
                    printDocument1.Print();
            }
            else
                MessageBox.Show("Select a member to print their receipt");

        }
        /// <summary>
        /// Button for member menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnMenu_Click_1(object sender, EventArgs e)
        {
            ShowMenus(panelMemberMenu);
        }
        /// <summary>
        /// Button for search menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSearchMenu_Click_1(object sender, EventArgs e)
        {
            ShowMenus(panelSearchMenu);
        }
        /// <summary>
        /// Button for adding member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAdd_Click_1(object sender, EventArgs e)
        {
            MembershipForm frmMemb = new MembershipForm("Add New Member");

            if (frmMemb.ShowDialog() == DialogResult.OK)
            {
                membMngr.AddMember(frmMemb.MemberData);
                UpdateGUI();
            }
            HideMenus();

        }
        /// <summary>
        /// Button for editing member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnEdit_Click_1(object sender, EventArgs e)
        {
            MembershipForm frmMemb = new MembershipForm("Edit Member");

            int index = listBoxMembers.SelectedIndex;

            if (listBoxMembers.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select a member from the list to edit", "Error", MessageBoxButtons.OK);
                return;
            }
            if (index >= 0)
            {
                frmMemb.MemberData = membMngr.GetMember(index).MemberData;
                frmMemb.ShowDialog();
                membMngr.ChangeMember(frmMemb.MemberData, index);
                UpdateGUI();
            }

            HideMenus();
        }
        /// <summary>
        /// Button for deleting member
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnDelete_Click_1(object sender, EventArgs e)
        {
            if (listBoxMembers.SelectedItems.Count != 1)
            {
                MessageBox.Show("Select a member to delete", "Error", MessageBoxButtons.OK);
                return;
            }
            else
            {
                membMngr.DeleteMember(listBoxMembers.SelectedIndex);
                listBoxMembers.Items.RemoveAt(listBoxMembers.SelectedIndex);
            }
            HideMenus();

        }
        /// <summary>
        /// Search button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSearch_Click_1(object sender, EventArgs e)
        {
            string name = txtBoxSearch.Text;
            MembershipForm frmMemb = new MembershipForm("Edit Searched Member");
            Membership member = new Membership();
            int index = listBoxMembers.SelectedIndex;

            if (string.IsNullOrEmpty(name))
                MessageBox.Show("Enter the full name of a current customer", "Error", MessageBoxButtons.OK);
            else
            {
                if (listBoxMembers.Items.Count > 0)
                {
                    if (membMngr.SearchMember(name) != null && name.Equals(membMngr.SearchMember(name).MemberData.CompleteName))
                    {
                        frmMemb.MemberData = membMngr.SearchMember(name).MemberData;
                        frmMemb.ShowDialog();
                        txtBoxSearch.Text = string.Empty;
                    }
                    else
                    {
                        MessageBox.Show("Member not found", "Error", MessageBoxButtons.OK);
                    }
                }
                else if (listBoxMembers.Items.Count == 0)
                    MessageBox.Show("You have no members!", "Error", MessageBoxButtons.OK);
            }

            HideMenus();

        }
        /// <summary>
        /// More info button. Opens disables membershipform
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnMoreInfo_Click_1(object sender, EventArgs e)
        {
            MembershipForm frmMemb = new MembershipForm("Show Member");

            int index = listBoxMembers.SelectedIndex;

            if (index != -1)
            {
                frmMemb.MemberData = membMngr.GetMember(listBoxMembers.SelectedIndex).MemberData;
                frmMemb.DisableForm();
                frmMemb.Show();
            }
            else
                MessageBox.Show("Select a member to show info");

            HideMenus();

        }
        /// <summary>
        /// Open terms form button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnTerms_Click(object sender, EventArgs e)
        {
            TermsForm termsfrm = new TermsForm();
            termsfrm.Show();
        }
        /// <summary>
        /// Exit application button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnExit_Click_2(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(" Do you want to exit this application?", "Exit", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        /// <summary>
        /// Main menu button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnMain_Click(object sender, EventArgs e)
        {
            panelStartHelp.Visible = false;
            ShowMenus(panelMenu);
        }
        /// <summary>
        /// About button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAbout_Click(object sender, EventArgs e)
        {
            AboutForm abtfrm = new AboutForm();
            abtfrm.Show();
        }
    }
}
