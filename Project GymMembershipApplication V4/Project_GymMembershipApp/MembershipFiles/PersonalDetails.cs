using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GymMembershipApp.MembershipFiles
{
    public class PersonalDetails
    {
        // Private fields
        private string m_firstname;
        private string m_lastname;
        private string m_personalnumber;
        /// <summary>
        /// Constructor 0: Default
        /// </summary>
        public PersonalDetails() { }
        /// <summary>
        /// Constructor 1
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="personalnumber"></param>
        public PersonalDetails(string firstname, string lastname, string personalnumber)
        {
            m_firstname = firstname;
            m_lastname = lastname;
            m_personalnumber = personalnumber;
        }
        /// <summary>
        /// Get and Set property for first name
        /// </summary>
        public string Firstname
        {
            get { return m_firstname; }
            set { m_firstname = value; }
        }
        /// <summary>
        /// Get and set property for last name
        /// </summary>
        public string Lastname
        {
            get { return m_lastname; }
            set { m_lastname = value; }
        }
        /// <summary>
        /// Get and set property for ID-number
        /// </summary>
        public string Personalnumber
        {
            get { return m_personalnumber; }
            set { m_personalnumber = value; }
        }
        /// <summary>
        /// Bool for checking data
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(m_firstname))
                return false;
            else if (string.IsNullOrEmpty(m_lastname))
                return false;
            else if (string.IsNullOrEmpty(m_personalnumber))
                return false;
            else
                return true;
        }
        /// <summary>
        /// Formatting Tostring override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Format("{0, 23}", Personalnumber);
            return strOut;
        }
    }
}
