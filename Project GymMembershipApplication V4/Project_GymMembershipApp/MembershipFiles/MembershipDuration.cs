using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_GymMembershipApp.MembershipFiles
{
    public class MembershipDuration
    {

        // Private datatime fields
        private DateTime m_start = DateTime.Now.Date;
        private DateTime m_end = DateTime.Now.Date;

        /// <summary>
        /// Constructor 0: Default
        /// </summary>
        public MembershipDuration() { }
        /// <summary>
        /// Constructor 1
        /// </summary>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public MembershipDuration(DateTime start, DateTime end)
        {
            m_start = start;
            m_end = end;
        }
        /// <summary>
        /// Get and Set property for start of membership
        /// </summary>
        public DateTime Start
        {
            get { return m_start; }
            set { m_start = value; }
        }
        /// <summary>
        /// Get and Set property for end of membership
        /// </summary>
        public DateTime End
        {
            get { return m_end; }
            set { m_end = value; }
        }
        /// <summary>
        /// Calculate number of membership days
        /// </summary>
        /// <returns></returns>
        public double CalcMembDays()
        {
            int daysleft = (m_end - m_start).Days;

            if (m_start.Date.Day == DateTime.Now.Day)
                return daysleft + 1;

            return daysleft;
        }
        /// <summary>
        /// Formating Tostring override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string strOut = String.Format(" {0}                {1}", m_start.ToShortDateString(), m_end.ToShortDateString());
            return strOut;
        }
    }
}
