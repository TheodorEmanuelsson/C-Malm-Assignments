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
    public partial class MembershipForm : Form
    {
        private Member m_member = new Member();
        private bool m_closeForm;


        public MembershipForm(string title)
        {
            InitializeComponent();

            Text = title;

            InitializeGUI();
        }
        /// <summary>
        /// Initialize tooltips and fill comboboxes
        /// </summary>
        public void InitializeGUI()
        {
            m_closeForm = true;

            FillBoxes();

            toolTip1.SetToolTip(dateTimePickerStart, "Enter the time the membership starts");
            toolTip1.SetToolTip(dateTimePickerEnd, "Enter the time the membership ends");
            toolTip1.SetToolTip(cmboBoxType, "Select the type of membership the customer wants");
            toolTip1.SetToolTip(cmboBoxLocation, "Select the location the customer chooses");

        }
        /// <summary>
        /// Get and Set property for Memberdata
        /// </summary>
        public Member MemberData
        {
            get { return m_member; }
            set
            {
                if (value != null)
                    m_member = value;

                UpdateGUI();
            }
        }
        /// <summary>
        /// Fills boxes with enums
        /// </summary>
        private void FillBoxes()
        {
            string[] location = Enum.GetNames(typeof(GymLocation));


            foreach (var types in Enum.GetValues(typeof(MembershipType)))
                cmboBoxType.Items.Add(types);

            for (int i = 0; i < location.Length; i++)
                cmboBoxLocation.Items.Add(location[i].Replace("_", " "));
        }
        /// <summary>
        /// Updates stored information
        /// </summary>
        private void UpdateGUI()
        {
            double heightformat = m_member.BMIInfo.Height * 100; // Converts back the height to centimeter instead of meter.

            FillBoxes();

            txtBoxFirstName.Text = m_member.PersonalData.Firstname;
            txtBoxLastName.Text = m_member.PersonalData.Lastname;
            txtBoxEmail.Text = m_member.ContactData.Email;
            txtBoxPhone.Text = m_member.ContactData.Phone;
            txtBoxPersonalNmbr.Text = m_member.PersonalData.Personalnumber;
            txtBoxStreet.Text = m_member.AddressData.Street;
            txtBoxZipCode.Text = m_member.AddressData.ZipCode;
            txtBoxHeight.Text = heightformat.ToString();
            txtBoxWeight.Text = m_member.BMIInfo.Weight.ToString();

            cmboBoxLocation.SelectedIndex = (int)m_member.Location;
            cmboBoxType.SelectedIndex = (int)m_member.Type;

            dateTimePickerStart.Value = m_member.Duration.Start;
            dateTimePickerEnd.Value = m_member.Duration.End;


        }
        /// <summary>
        /// Reads the personal details
        /// </summary>
        /// <returns></returns>
        public PersonalDetails ReadDetails()
        {
            PersonalDetails details = new PersonalDetails();

            details.Firstname = txtBoxFirstName.Text;
            details.Lastname = txtBoxLastName.Text;
            details.Personalnumber = txtBoxPersonalNmbr.Text;

            return details;
        }
        /// <summary>
        /// Reads the address details
        /// </summary>
        /// <returns></returns>
        public Address ReadAddress()
        {
            Address adr = new Address();

            adr.Street = txtBoxStreet.Text;
            adr.ZipCode = txtBoxZipCode.Text;

            adr.CheckData();

            return adr;
        }
        /// <summary>
        /// Reads the contact details
        /// </summary>
        /// <returns></returns>
        public MemberContact ReadContact()
        {
            MemberContact contactinfo = new MemberContact();

            contactinfo.Email = txtBoxEmail.Text;
            contactinfo.Phone = txtBoxPhone.Text;

            contactinfo.CheckData();

            return contactinfo;
        }
        /// <summary>
        /// Reads the duration details
        /// </summary>
        /// <returns></returns>
        public MembershipDuration ReadDuration()
        {
            MembershipDuration dur = new MembershipDuration();

            dur.Start = dateTimePickerStart.Value;
            dur.End = dateTimePickerEnd.Value;

            return dur;
        }
        /// <summary>
        /// Reads the BMI details
        /// </summary>
        /// <returns></returns>
        public BMI ReadBMI()
        {
            BMI bmi = new BMI();
            string InHeight = txtBoxHeight.Text;
            string InWeight = txtBoxWeight.Text;
            double OutHeight;
            double OutWeight;

            bool ok1 = double.TryParse(InHeight, out OutHeight);
            bool ok2 = double.TryParse(InWeight, out OutWeight);

            if(ok1 && ok2)
            {
                bmi.Height = OutHeight / 100;
                bmi.Weight = OutWeight;
            }

            return bmi;
             
        }
        /// <summary>
        /// Reads all input and creates new member
        /// </summary>
        /// <returns></returns>
        public bool ReadInput()
        {
            PersonalDetails details = ReadDetails();
            Address address = ReadAddress();
            MemberContact contactinfo = ReadContact();
            MembershipDuration duration = ReadDuration();
            BMI bmi = ReadBMI();
            details.CheckData();

            m_member = new Member(details, address, contactinfo, (MembershipType)cmboBoxType.SelectedIndex, (GymLocation)cmboBoxLocation.SelectedIndex, duration, bmi);

            return true;
        }
        /// <summary>
        /// OK button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnOK_Click(object sender, EventArgs e)
        {
            if(ReadInput() == true && m_member.CheckData() == true)
            {
                m_closeForm = true;
                Close();
            }
            else
            {
                MessageBox.Show("Incomplete data", "Input Error", MessageBoxButtons.OK);
                m_closeForm = false;
            }
        }
        /// <summary>
        /// Disables the form
        /// </summary>
        public void DisableForm()
        {
            grpBoxAddress.Enabled = false;
            grpBoxDuration.Enabled = false;
            grpBoxEmailPhone.Enabled = false;
            grpBoxMemberDetails.Enabled = false;
            grpBoxName.Enabled = false;
            grpBoxBMI.Enabled = false;
            bttnOK.Enabled = false;
            bttnCancel.Enabled = false ;
        }
        /// <summary>
        /// Cancel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnCancel_Click(object sender, EventArgs e)
        {
            DialogResult output = MessageBox.Show("Are you sure you want to cancel?", "Cancel Current Member", MessageBoxButtons.YesNo);

            if (output == DialogResult.No)
                m_closeForm = false;

            if (output == DialogResult.Yes)
                m_closeForm = true;
        }
        /// <summary>
        /// Form closing method
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MembershipForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (m_closeForm)
                e.Cancel = false;
            else
                e.Cancel = true;
        }
        /// <summary>
        /// Checks if personal number entries are numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxPersonalNmbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;

            if(!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits");
            }
        }
        /// <summary>
        /// Checks if zipcode entries are numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;

            if(!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits");
            }
        }
        /// <summary>
        /// Checks if phone entries are numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;

            if(!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits");
            }
        }
        /// <summary>
        /// Checks if weight entries are numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;

            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits");
            }
        }
        /// <summary>
        /// Checks if height entires are numbers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtBoxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char chr = e.KeyChar;

            if (!char.IsDigit(chr) && chr != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please enter only digits");
            }
        }
    }
}
