using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Customer_Registry_V1
{
    public class Contact
    {

        private string m_firstName = string.Empty;
        private string m_lastName = string.Empty;
        private Address m_address;
        private Email m_email;
        private Phone m_phone;

        /// <summary>
        /// Constructor 0: Default constructor
        /// 2 empty strings and 3 new objects
        /// </summary>
        public Contact():this(string.Empty, string.Empty, new Address(), new Phone(), new Email())
        {}
        /// <summary>
        /// Constructor 1
        /// All parameters needed in the class
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <param name="adr"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        public Contact(string firstName, string lastName, Address adr, Phone tel, Email mail)
        {
            m_firstName = firstName;
            m_lastName = lastName;
            m_address = adr;
            m_phone = tel;
            m_email = mail;
        }
        /// <summary>
        /// Property for m_firstname field
        /// Related to firstname
        /// Read and Writes access
        /// </summary>
        public string FirstName
        {
            get { return m_firstName; }
            set { m_firstName = value; }
        }
        /// <summary>
        /// Property for m_lastname field
        /// Related to lastname
        /// Read and Writes access
        /// </summary>
        public string LastName
        {
            get { return m_lastName; }
            set { m_firstName = value; }
        }
        /// <summary>
        /// Property for m_address object
        /// Related to the address class
        /// Read and writes access
        /// </summary>
        public Address AddressData
        {
            get { return m_address; }
            set { m_address = value; }
        }
        /// <summary>
        /// Property for m_email object
        /// Related to the email class
        /// Read and writes access
        /// </summary>
        public Email EmailData
        {
            get { return m_email; }
            set { m_email = value; }
        }
        /// <summary>
        /// Property for m_phone object
        /// Related to the phone class
        /// Read and writes access
        /// </summary>
        public Phone PhoneData
        {
            get { return m_phone; }
            set { m_phone = value; }
        }
        /// <summary>
        /// Property for getting the complete name of a customer
        /// Adds firstname + blankspace + lastname to return a string
        /// Only read access
        /// </summary>
        public string CompleteName
        {
            get { return m_firstName + " " + m_lastName; }
        }

        /// <summary>
        /// Checks data:
        /// 1) If m_firstname is empty
        /// 2) If m_lastname is empty
        /// 3) If m_country is selected
        /// 4) Calls CheckData in the Address class; that in turn checks if city is empty
        /// </summary>
        /// <returns>True is nothing is empty, false if any of the fields above is empty</returns>
        public bool CheckData()
        {

            if (String.IsNullOrEmpty(m_firstName))
                return false;
            else if (String.IsNullOrEmpty(m_lastName))
                return false;
            else if (m_address.CheckData() != true)
                return false;
            else if (m_address.Country == (Countries)(-1))
                return false;
            else
                return true;
        }

        /// <summary>
        /// 
        /// Formats the complete name of a customer and other output,
        /// Puts a tab before the strings
        /// Calls the ToString method in Address class to format current address
        /// Calls the ToString method in Phone class to format current phone
        /// Calls the ToString method in the Email class to format current email
        /// </summary>
        /// <returns>Formatted strings</returns>
        public override string ToString()
        {
            string strOut = string.Format("\t{0,-20}{1, -20}{2, -3}{3, -5}", CompleteName, m_address.ToString(), m_phone.ToString(), m_email.ToString());

            return strOut;
        }

    }
}
