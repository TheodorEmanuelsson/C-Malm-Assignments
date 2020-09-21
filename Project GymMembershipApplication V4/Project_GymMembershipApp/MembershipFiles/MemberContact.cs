using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GymMembershipApp.MembershipFiles
{
    public class MemberContact
    {
        // Private fields
        private string m_phone;
        private string m_email;
        /// <summary>
        /// Constructor 0: Default
        /// </summary>
        public MemberContact() { }
        /// <summary>
        /// Constructor 1
        /// </summary>
        /// <param name="phone"></param>
        /// <param name="email"></param>
        public MemberContact(string phone, string email)
        {
            m_phone = phone;
            m_email = email;
        }
        /// <summary>
        /// Get and Set property for phone number
        /// </summary>
        public string Phone
        {
            get { return m_phone; }
            set { m_phone = value; }
        }
        /// <summary>
        /// Get and Set property for email address
        /// </summary>
        public string Email
        {
            get { return m_email; }
            set { m_email = value; }
        }
        /// <summary>
        /// Bool for checking data
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(m_phone))
                return false;
            else if (string.IsNullOrEmpty(m_email))
                return false;
            else
                return true;
        }

    }
}
