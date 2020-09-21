using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Customer_Registry_V1
{
    public partial class MainForm : Form
    {
        // New CustomerManager object
        CustomerManager customerMngr = new CustomerManager();

        /// <summary>
        /// Constructor 0: Default
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            InitializeGUI();
        }

        /// <summary>
        /// Method for updating the list.
        /// First clear the items,
        /// Then adds array of items from GetCustomerInfo method
        /// </summary>
        public void UpdateList()
        {
            listBoxCustomers.Items.Clear();
            listBoxCustomers.Items.AddRange(customerMngr.GetCustomerInfo());
        }

        /// <summary>
        /// Default initiations:
        /// 1) Prints the label for Customer Registry Application show in MainForm
        /// 2) Makes the panel that shows submenu for Adding/Editing/Deleting customers invisible
        /// 3) Makes the panel that shows submenu for Searching customers invisible
        /// </summary>
        public void InitializeGUI()
        {
            lblTitle.Text = "Customer Registry \nApplication";
            panelCustomerMenu.Visible = false;
            panelSearchMenu.Visible = false;
        }

        /// <summary>
        /// Method for hiding submenus
        /// Simple if statements that checks if a submenu is visibile
        /// and makes it invisible if it is.
        /// Used for reseting menus after user interactions
        /// </summary>
        public void HideMenus()
        {
            if (panelCustomerMenu.Visible == true)
                panelCustomerMenu.Visible = false;

            if (panelSearchMenu.Visible == true)
                panelSearchMenu.Visible = false;
        }

        /// <summary>
        /// Method for showing menus
        /// Used when user clicks on the button relating to a submenu
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
        /// Method used when user clicks on Add Customer button
        /// Opens new ContactForm
        /// If Dialog in ContactForm is OK it calls AddCustomer with input ContactData
        /// and then updates the list.
        /// Hides submenus upon click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnAdd_Click_1(object sender, EventArgs e)
        {
            ContactForm frmContact = new ContactForm("Add New Customer");

            if (frmContact.ShowDialog() == DialogResult.OK)
            {
                customerMngr.AddCustomer(frmContact.ContactData);
                UpdateList();

            }
            HideMenus();
        }

        /// <summary>
        /// Method for editing selected contact
        /// Opens a new ContactForm if a current customer is selected
        /// If a customer is selected, it retrieves ContactData for that Customer and
        /// calls ChangeCustomer from CustomerManager. Finally updates the list.
        /// Hides submenus upon click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnEdit_Click_1(object sender, EventArgs e)
        {

            ContactForm frmContact = new ContactForm("Edit Customer");


            int index = listBoxCustomers.SelectedIndex;

            if (listBoxCustomers.SelectedItems.Count != 1)
            {
                MessageBox.Show("Please select a current customer to edit");
                return;
            }

            if (index >= 0)
            {
                frmContact.ContactData = customerMngr.GetCustomer(index).ContactData;
                frmContact.ShowDialog();
                customerMngr.ChangeCustomer(frmContact.ContactData, index);
                UpdateList();
            }

            HideMenus();

        }

        /// <summary>
        /// Button for deleting customer
        /// Shows message if no customer is selected
        /// 
        /// Calls DeleteCustomer method in CustomerManager class
        /// and removes at selected index in listbox
        /// 
        /// Hides menus on clock
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BttnDelete_Click_1(object sender, EventArgs e)
        {
            if (listBoxCustomers.SelectedItems.Count != 1)
            {
                MessageBox.Show("Select a customer to delete");
                return;
            }
            else
            {
                customerMngr.DeleteCustomer(listBoxCustomers.SelectedIndex);
                listBoxCustomers.Items.RemoveAt(listBoxCustomers.SelectedIndex);
            }

            HideMenus();
        }

        /// <summary>
        /// Button for clicking customer menu.
        /// Calls ShowMenus with input panel for customer menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnMenu_Click(object sender, EventArgs e)
        {
            ShowMenus(panelCustomerMenu);
        }

        /// <summary>
        /// Search button.
        /// 
        /// Checks if input is emptry or if listbox is empty
        /// If not; calls SearchCustomer method in CustomerManager with text in txtBoxSearch
        /// and retrieves Contact data. Creates ContactForm window with ContactData.
        /// Also empties the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSearch_Click_1(object sender, EventArgs e)
        {
            string name = txtBoxSearch.Text;
            ContactForm frmContact = new ContactForm("Edit Searched Customer");

            Customer customer = new Customer();

            int index = listBoxCustomers.SelectedIndex;

            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Enter the full name of a current customer", "Error", MessageBoxButtons.OK);
            }
            else
            {
                if (listBoxCustomers.Items.Count > 0)
                {
                    if (customerMngr.SearchCustomer(name) != null && name.Equals(customerMngr.SearchCustomer(name).ContactData.CompleteName))
                    {
                        frmContact.ContactData = customerMngr.SearchCustomer(name).ContactData;
                        frmContact.ShowDialog();

                        txtBoxSearch.Text = string.Empty;
                    }

                    else
                    {
                        MessageBox.Show("Customer not found", "Error", MessageBoxButtons.OK);
                    }

                }
                else if (listBoxCustomers.Items.Count == 0)
                {
                    MessageBox.Show("Your customer registry is empty!");
                }
            }
            HideMenus();
        }

        /// <summary>
        /// Button for opening the search submenu
        /// Calls ShowMenu with input panel for searchmenu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnSearchMenu_Click_1(object sender, EventArgs e)
        {
            ShowMenus(panelSearchMenu);
        }
    }
}
