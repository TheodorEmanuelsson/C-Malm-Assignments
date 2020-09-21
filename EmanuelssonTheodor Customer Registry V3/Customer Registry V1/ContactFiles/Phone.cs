using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Registry_V1
{
    /// <summary>
    /// The Phone class handles Work and Home Phone numbers
    /// </summary>
    public class Phone
    {

        // private fields for personal emal and work email
        private string m_home;
        private string m_work;
        private string m_other;

        // Constructors are alled in a chain: Constructor 0 -> Constructor 1.

        /// <summary>
        /// Constructor 0: a default constructor for the phone class.
        /// </summary>
        public Phone(){}

        /// <summary>
        /// Construcotr 1: two parameters: homePhone and workPhone.
        /// Calls the DefaultValues method. Input is the emptry string of the fields
        /// </summary>
        /// <param name="homePhone"> Input - home phone number</param>
        /// <param name="workPhone"> Input - work phone number</param>
        public Phone(string homePhone, string workPhone)
        {
            DefaultValues();
        }

        /// <summary>
        /// Default value method for empty strings
        /// </summary>
        public void DefaultValues()
        {
            m_home = String.Empty;
            m_work = String.Empty;
            m_other = String.Empty;
        }

        /// <summary>
        /// Property for the m_home field
        /// Related to home phone number
        /// Read and writes access
        /// </summary>
        public string Home
        {
            get { return m_home; }
            set { m_home = value; }
        }

        /// <summary>
        /// Property for the m_work field
        /// Related to work phone number
        /// Read and writes access
        /// </summary>
        public string Work
        {
            get { return m_work; }
            set { m_work = value; }
        }

        /// <summary>
        /// Property for the m_other field
        /// Used as a placeholder between the strings that are formatted
        /// Could be used if application is extended to include other phone number.
        /// Read and writes access
        /// </summary>
        public string Other
        {
            get { return m_other; }
            set { m_other = value; }
        }

        /// <summary>
        /// Formats the fields to strings that are displayed in the ListBox in MainForm.
        /// </summary>
        /// <returns> the Formatted strings</returns>
        public override string ToString()
        {

            string strOut = string.Format("{0, 23} {1, 0} {2, 1}", m_home, m_other, m_work);
            return strOut;

        }
    }
}
