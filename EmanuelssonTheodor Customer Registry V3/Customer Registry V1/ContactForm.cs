using Customer_Registry_V1;
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
    public partial class ContactForm : Form
    {
        // Field for new contact object and bool for closing of form
        private Contact m_contact = new Contact();
        private bool m_closeForm;

        /// <summary>
        /// Constructor 0: Default
        /// Calls the method for filling and formating Combobox for countries
        /// </summary>
        /// <param name="title">Form title that changed depending in user action</param>
        public ContactForm(string title)
        {

            InitializeComponent();

            Text = title;

            m_closeForm = true;

            FillCountryComboBox();

        }
        /// <summary>
        /// Property for the m_contact object
        /// Related to contact information
        /// Read and writes access
        /// Also updates GUI, relevant when searching and editing customer
        /// </summary>
        public Contact ContactData
        {

            get { return m_contact; }

            set
            {
                if (value != null)
                {
                    m_contact = value;
                }
                UpdateGUI();

            }

        }

        /// <summary>
        /// Fills the combobox with enum of counties
        /// and formats the enum
        /// </summary>
        private void FillCountryComboBox()
        {

            string[] countries = Enum.GetNames(typeof(Countries));
            for (int i = 0; i < countries.Length; i++)
            {
                cmboBoxCountry.Items.Add(countries[i].Replace("_", " "));
            }

        }

        /// <summary>
        /// Updates the GUI of the form with contact data
        /// Relevant when searching and editing a customer
        /// </summary>
        private void UpdateGUI()
        {

            FillCountryComboBox();

            txtBoxFirstName.Text = m_contact.FirstName;
            txtBoxLastName.Text = m_contact.LastName;
            txtBoxPhoneCell.Text = m_contact.PhoneData.Work;
            txtBoxPhoneHome.Text = m_contact.PhoneData.Home;
            txtBoxEmailBusi.Text = m_contact.EmailData.Work;
            txtBoxEmailPriv.Text = m_contact.EmailData.Personal;
            txtBoxStreet.Text = m_contact.AddressData.Street;
            txtBoxCity.Text = m_contact.AddressData.City;
            txtBoxZip.Text = m_contact.AddressData.ZipCode;
            cmboBoxCountry.SelectedIndex = (int)m_contact.AddressData.Country;



        }

        /// <summary>
        /// Method for reading user input related to Address class
        /// Will be called by the final ReadInput method
        /// </summary>
        /// <returns></returns>
        public Address ReadAddress()
        {
            Address addr = new Address();

            addr.City = txtBoxCity.Text;
            addr.Street = txtBoxStreet.Text;
            addr.ZipCode = txtBoxZip.Text;
            addr.Country = (Countries)Enum.Parse(typeof(Countries), cmboBoxCountry.SelectedIndex.ToString());
            addr.CheckData();


            return addr;
        }

        /// <summary>
        /// Method for reading user input related to Email class
        /// Will be called by the final ReadInput method
        /// </summary>
        /// <returns></returns>
        public Email ReadEmail()
        {
            Email email = new Email();

            email.Work = txtBoxEmailBusi.Text;
            email.Personal = txtBoxEmailPriv.Text;

            return email;
        }

        /// <summary>
        /// Method for reading user input related to Phone class
        /// Will be called by the final ReadInput method
        /// </summary>
        /// <returns></returns>
        public Phone ReadPhone()
        {
            Phone phone = new Phone();

            phone.Work = txtBoxPhoneCell.Text;
            phone.Home = txtBoxPhoneHome.Text;

            return phone;
        }

        /// <summary>
        /// Calls previous Read methods
        /// and creates a new contact
        /// </summary>
        /// <returns></returns>
        public bool ReadInput()
        {

            Address address = ReadAddress();
            Phone phone = ReadPhone();
            Email email = ReadEmail();

            m_contact = new Contact(txtBoxFirstName.Text, txtBoxLastName.Text, address, phone, email);

            return true;
        }

        /// <summary>
        /// Button for canceling current ContactForm
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            DialogResult output = MessageBox.Show(String.Format("Are you sure you want to cancel?"), "Cancel Current Customer", MessageBoxButtons.YesNo);

            if (output == DialogResult.No)
            {
                m_closeForm = false;

            }
            if (output == DialogResult.Yes)
            {
                m_closeForm = true;

            }
        }

        /// <summary>
        /// Closing of form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ContactForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_closeForm)
                e.Cancel = false;
            else
                e.Cancel = true;

        }

        /// <summary>
        /// OK button for finalizing current customer
        /// Error message if first name, lastname, city and country has not been inputed,
        /// done via the CheckData method in Contact class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnOK_Click(object sender, EventArgs e)
        {
            if (ReadInput() == true && m_contact.CheckData() == true)
            {
                m_closeForm = true;
                Close();
            }
            else
            {
                MessageBox.Show("Incomplete data. Plase enter first and last name, city and country", "error", MessageBoxButtons.OK);
                m_closeForm = false;
            }
        }
    }
}
