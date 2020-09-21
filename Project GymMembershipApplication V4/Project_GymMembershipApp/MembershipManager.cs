using Project_GymMembershipApp.MembershipFiles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Project_GymMembershipApp
{
    class MembershipManager
    {
        // Private list of memberships
        private List<Membership> m_memberships;
        /// <summary>
        /// Constructor 0: Default
        /// </summary>
        public MembershipManager()
        {
            m_memberships = new List<Membership>();
        }
        /// <summary>
        /// Get property for counting number of memberships
        /// </summary>
        public int Count
        {
            get { return m_memberships.Count; }
        }
        /// <summary>
        /// Get property for new membership ID
        /// </summary>
        public int GetNewID
        {
            get { return Count + 1; }
        }
        /// <summary>
        /// Add member method
        /// </summary>
        /// <param name="memberIn"></param>
        public void AddMember(Member memberIn)
        {
            string newID = GetNewID.ToString();
            Membership newMember = new Membership(memberIn, newID);
            m_memberships.Add(newMember);
        }
        public bool AddMember(Membership memberIn)
        {
            if (Count + 2 >= 0 && Convert.ToInt32(memberIn.ID) < m_memberships.Count)
            {
                m_memberships.Add(memberIn);
                memberIn.ID = GetNewID.ToString();
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Edit membership method
        /// </summary>
        /// <param name="memberIn"></param>
        /// <param name="index"></param>
        public void ChangeMember(Member memberIn, int index)
        {
            m_memberships[index].MemberData = memberIn;
        }
        /// <summary>
        /// Delete member method
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteMember(int index)
        {
            if (index >= 0)
            {
                m_memberships.RemoveAt(index);
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Search member method
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        public Membership SearchMember(string str)
        {
            Membership member = m_memberships.Find(delegate (Membership m)
                { return m.MemberData.CompleteName.Equals(str); });

            return member;
        }
        /// <summary>
        /// Get member from inputed index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Membership GetMember(int index)
        {
            return m_memberships[index];
        }
        /// <summary>
        /// Get member information array
        /// </summary>
        /// <returns></returns>
        public string[] GetMemberInfo()
        {
            string[] getMember = new string[m_memberships.Count];

            for (int index = 0; index < m_memberships.Count; index++)
                getMember[index] = m_memberships[index].ToString();

            return getMember;
        }
    }
}
