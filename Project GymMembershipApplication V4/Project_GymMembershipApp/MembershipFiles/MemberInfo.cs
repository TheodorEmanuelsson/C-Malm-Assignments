using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_GymMembershipApp.MembershipFiles
{
    public class Member
    {
        // Private objects
        private PersonalDetails m_personaldetails;
        private Address m_address;
        private MemberContact m_contact;
        private MembershipType m_type;
        private GymLocation m_location;
        private MembershipDuration m_duration;
        private BMI m_bmi;
        /// <summary>
        /// Constructor 1 Default
        /// </summary>
        public Member()
        {
            Initialize();
        }
        /// <summary>
        /// Constructor 1
        /// </summary>
        /// <param name="personalDetails"></param>
        /// <param name="address"></param>
        /// <param name="contact"></param>
        /// <param name="type"></param>
        /// <param name="location"></param>
        /// <param name="duration"></param>
        /// <param name="bmi"></param>
        public Member(PersonalDetails personalDetails, Address address, MemberContact contact, MembershipType type, GymLocation location, MembershipDuration duration, BMI bmi)
        {
            m_personaldetails = personalDetails;
            m_address = address;
            m_contact = contact;
            m_type = type;
            m_location = location;
            m_duration = duration;
            m_bmi = bmi;
        }
        /// <summary>
        /// Called by default constructor
        /// Creates new objects
        /// </summary>
        private void Initialize()
        {
            m_personaldetails = new PersonalDetails();
            m_address = new Address();
            m_contact = new MemberContact();
            m_duration = new MembershipDuration();
            m_bmi = new BMI();
        }
        /// <summary>
        /// Get and Set property for personal information
        /// </summary>
        public PersonalDetails PersonalData
        {
            get { return m_personaldetails; }
            set { m_personaldetails = value; }
        }
        /// <summary>
        /// Get and Set property for address information
        /// </summary>
        public Address AddressData
        {
            get { return m_address; }
            set { m_address = value; }
        }
        /// <summary>
        /// Get and Set property for contact information
        /// </summary>
        public MemberContact ContactData
        {
            get { return m_contact; }
            set { m_contact = value; }
        }
        /// <summary>
        /// Get and Set property for membership type
        /// </summary>
        public MembershipType Type
        {
            get { return m_type; }
            set { m_type = value; }
        }
        /// <summary>
        /// Get and Set property for location data
        /// </summary>
        public GymLocation Location
        {
            get { return m_location; }
            set { m_location = value; }
        }
        /// <summary>
        /// Get and Set property for duration data
        /// </summary>
        public MembershipDuration Duration
        {
            get { return m_duration; }
            set { m_duration = value; }
        }
        /// <summary>
        /// Get and Set for BMI output
        /// </summary>
        public BMI BMIInfo
        {
            get { return m_bmi; }
            set { m_bmi = value; }
        }
        /// <summary>
        /// Get property for complete name
        /// </summary>
        public string CompleteName
        {
            get { return m_personaldetails.Firstname.Trim() + " " + m_personaldetails.Lastname.Trim(); }
        }

        /// <summary>
        /// Get property for number of days
        /// </summary>
        public double Days
        {
            get { return m_duration.CalcMembDays(); }
        }
        /// <summary>
        /// Calculates the cost of the membership
        /// </summary>
        /// <returns></returns>
        public double CalcCost()
        {
            double cost = 0;
            
            if (m_location == GymLocation.Large_Garage_1 || Location == GymLocation.Large_Garage_2)
                cost += 2;
            if (m_location == GymLocation.Small_Garage_1 || Location == GymLocation.Small_Garage_2)
                cost += 1;
            if (m_type == MembershipType.Bronze)
                cost += 1;
            if (m_type == MembershipType.Silver)
                cost += 2;
            if (m_type == MembershipType.Gold)
                cost += 3;
            if (m_type == MembershipType.Platinum)
                cost += 4;

            cost *= Days;
            
            Console.WriteLine("Cost is" + cost);
            return cost;
        }
        /// <summary>
        /// Bool for checking data
        /// </summary>
        /// <returns></returns>
        public bool CheckData()
        {
            if (m_personaldetails.CheckData() != true)
                return false;
            else if (m_address.CheckData() != true)
                return false;
            else if (m_contact.CheckData() != true)
                return false;
            else if (m_location == (GymLocation)(-1))
                return false;
            else if (m_type == (MembershipType)(-1))
                return false;
            else if(CheckDuration() != true)
                return false;
            else
                return true;
        }
        /// <summary>
        /// Bool for checking if duration makes sense
        /// </summary>
        /// <returns></returns>
        public bool CheckDuration()
        {
            if (m_duration.Start.Date <= m_duration.End.Date)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Formatting Tostring override
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string locationIn = Location.ToString();
            string locationOut = locationIn.Replace("_", " ");

            string strOut = string.Format(" {0}   \t{1}               {2}          {3}             {4}", CompleteName, m_duration.ToString(), Type, locationOut, Days);
            return strOut;
        }
    }
}
