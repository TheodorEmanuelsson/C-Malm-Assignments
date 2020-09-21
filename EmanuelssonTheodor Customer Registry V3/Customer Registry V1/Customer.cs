using Customer_Registry_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Registry_V1
{
    class Customer
    {
        // Fields for an object from class contact and a string for the ID of a customer
        Contact m_contact;
        string m_id;

        /// <summary>
        /// Constructor 0: Default
        /// </summary>
        public Customer(): this(null)
        {

            m_contact = new Contact();
        }

        /// <summary>
        /// Constructor 1: 
        /// </summary>
        /// <param name="contactIn"></param>
        public Customer(Contact contactIn):this(contactIn, string.Empty)
        {


        }

        /// <summary>
        /// Constructor 2:
        /// </summary>
        /// <param name="contactIn"></param>
        /// <param name="id"></param>
        public Customer(Contact contactIn, string id)
        {
            m_contact = contactIn;
            m_id = id;
        }

        /// <summary>
        /// Property for the m_contract object
        /// Related to the contact class
        /// Read and writes access
        /// </summary>
        public Contact ContactData
        {

            get { return m_contact; }

            set { m_contact = value; }

        }

        /// <summary>
        /// Property for the m_id string field
        /// Read and writes access
        /// /// </summary>
        public string ID
        {

            get { return m_id; }

            set { m_id = value; }

        }

        /// <summary>
        /// Formats ID and Contact to strings
        /// </summary>
        /// <returns></returns>

        public override string ToString()
        {

            string strOut = string.Format("{0, -10}{1, -5}", m_id, m_contact);

            return strOut;
        }

    }
}
