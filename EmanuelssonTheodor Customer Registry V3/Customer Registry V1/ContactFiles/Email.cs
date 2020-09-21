using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Registry_V1
{
    /// <summary>
    /// The Email class handles work-email and private-email.
    /// </summary>
    public class Email
    {

            // private fields for personal email and work email
            private string m_personal;
            private string m_work;


        // Constructors are called in a chain: Constructor 0 -> 
        // -> Constructor 1 -> Constructor 2


        /// <summary>
        /// Constructor 0: a default constructor for the email class
        /// </summary>
            public Email(){}

        /// <summary>
        /// Constructor 1; one parameter: workMail
        /// Calls Constructor 2 using default value as the second argument.
        /// </summary>
        /// <param name="workMail">Input coming form the client object</param>
            public Email(string workMail) : this(workMail, string.Empty){}
        /// <summary>
        /// Constructor 2: two parameters: workMail and Personal Mail.
        /// Sets the private fields to the inputs
        /// </summary>
        /// <param name="workMail">Input - office email</param>
        /// <param name="personalMail">Input - private email</param>
            public Email(string workMail, string personalMail)
            {
                m_work = workMail;
                m_personal = personalMail;
            }

            /// <summary>
            /// Property for the m_personal field
            /// Related to personal email
            /// Reads and writes access
            /// </summary>
            public string Personal
            {
                get { return m_personal; }
                set { m_personal = value; }
            }

            /// <summary>
            /// Property for the m_work field
            /// Related to business email
            /// </summary>
            public string Work
            {
                get { return m_work; }
                set { m_work = value; }
            }

            /// <summary>
            /// Formats the fields to strings that are displayed in the ListBox in MainForm.
            /// </summary>
            /// <returns>the Formatted strings</returns>
            public override string ToString()
            {
                string strOut = string.Format("{0, 22} {1,12:f2}", m_work, m_personal);
                return strOut;
            }
        }
    }
