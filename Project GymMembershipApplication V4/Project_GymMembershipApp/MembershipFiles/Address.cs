using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_GymMembershipApp.MembershipFiles
{
    public class Address
    {
        // Priate fields
        private string m_street;
        private string m_zipCode;

        /// <summary>
        /// Constructor 0: Default
        /// </summary>
        public Address() { }
        /// <summary>
        /// Constructor 1
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zipCode"></param>
        public Address(string street, string zipCode)
        {
            m_street = street;
            m_zipCode = zipCode;
        }
        /// <summary>
        /// Get and set property for street
        /// </summary>
        public string Street
        {
            get { return m_street; }
            set { m_street = value; }
        }
        /// <summary>
        /// Get and set property for zipcode
        /// </summary>
        public string ZipCode
        {
            get { return m_zipCode; }
            set { m_zipCode = value; }
        }
        /// <summary>
        /// Bool for checking data
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            if (string.IsNullOrEmpty(m_street))
                return false;
            else if (string.IsNullOrEmpty(m_zipCode))
                return false;
            else
                return true;
        }
    }
}
