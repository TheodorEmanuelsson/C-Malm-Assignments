
using Project_GymMembershipApp.MembershipFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Project_GymMembershipApp
{
    public class Membership
    {
        // Private fields
        private Member m_member;
        private string m_id;
        /// <summary>
        /// Constructor 0: Default
        /// </summary>
        public Membership(): this(null)
        {
            m_member = new Member();
        }
        /// <summary>
        /// Constructor 1
        /// </summary>
        /// <param name="memberIn"></param>
        public Membership(Member memberIn) : this(memberIn, string.Empty)
        { }
        /// <summary>
        /// Constructor 2
        /// </summary>
        /// <param name="memberIn"></param>
        /// <param name="id"></param>
        public Membership(Member memberIn, string id)
        {
            m_member = memberIn;
            m_id = id;
        }
        /// <summary>
        /// Get and Set property for memberdata
        /// </summary>

        public Member MemberData
        {
            get { return m_member; }
            set { m_member = value; }
        }
        /// <summary>
        /// Get and Set property for member ID
        /// </summary>
        public string ID
        {
            get { return m_id; }
            set { m_id = value; }
        }
        /// <summary>
        /// Get property for cost
        /// </summary>
        public double Cost
        {
            get { return m_member.CalcCost(); }
        }
        /// <summary>
        /// Get property for receipt
        /// </summary>
        public string Receipt
        {
            get { return FormatReceipt(); }
        }
        /// <summary>
        /// Format reciept
        /// </summary>
        /// <returns></returns>
        private string FormatReceipt()
        {
            string newLine = Environment.NewLine;
            string name = m_member.CompleteName;
            string type = m_member.Type.ToString();
            string location = m_member.Location.ToString().Replace("_", " ");
            string days = m_member.Days.ToString();
            string cost = Cost.ToString();

            string receipt = newLine + newLine +
                "Receipt for member " + name + newLine + 
                "at The Budget Gym" + newLine + newLine +
                "Type of membership".PadRight(30) + type + newLine +
                "Location".PadRight(38) + location + newLine +
                "Membership for".PadRight(33) + days + " days"+ newLine + newLine + newLine +
                "Total cost amounts to: " + cost + " SEK"
                ;

            return receipt;

        }
        /// <summary>
        /// Tostring override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = string.Format("{0, -10}     {1, -5}", m_id, m_member);
            return strOut;
        }
    }
}
