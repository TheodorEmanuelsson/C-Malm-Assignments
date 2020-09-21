using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GymMembershipApp
{
    public class Terms
    {
        // Private field
        private string termsOut;
        /// <summary>
        /// Constructor 0
        /// </summary>
        public Terms ()
        {
            termsOut = FormatTerms();
        }
        /// <summary>
        /// Get and Set property for Terms information
        /// </summary>
        public string TermsOut
        {
            get { return termsOut; }
            set { termsOut = value; }
        }
        /// <summary>
        /// The terms output string
        /// </summary>
        /// <returns></returns>
        private string FormatTerms()
        {
            string newLine = Environment.NewLine;
            string Title = newLine + newLine + "TERMS OF SERVICE" + newLine + newLine +
                "Conditions of use:" + newLine + newLine +
                "We will provide these gym services to you." + newLine +
                "Which are subject to the conditions stated below in this document." + newLine +
                "Every time you visit the gym locations or use its service," + newLine +
                "you accept the following conditions. " +
                "This is why we urge you to read them carefully." + newLine + newLine +
                "1) You do not cough inside the gyms." + newLine +
                "2) You clean equipment after each use." + newLine +
                "3) You only enter the gym if there is no other member present." + newLine + newLine +
                "SIGNATURE:" + newLine + newLine +
                DateTime.Now.ToShortDateString()
                ;

            return Title;

        }
    }
}
