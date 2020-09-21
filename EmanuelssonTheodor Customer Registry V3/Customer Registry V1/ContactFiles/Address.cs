using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Registry_V1
{
    /// <summary>
    /// The Address class handles street, city, zipcode and the enum for country.
    /// 
    /// Note for instructor:
    /// In the Address help document There are two versions of this class. One that shows code and has 3 constructors and one that
    /// Shows the fields, properties and Methods and has 4 constructors. I used the one with 3 constructors.
    /// </summary>
    public class Address
    {
        // Private fields
        private string m_street;
        private string m_city;
        private string m_zipCode;
        private Countries m_country;

        /// <summary>
        /// Constructor 0: Default constructor with 3 emptry strings.
        /// </summary>
        public Address() : this(string.Empty, string.Empty, string.Empty)
        {}

        /// <summary>
        /// Constructor 1:  Three strings and one country
        /// Calls Constructor 2.
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zip"></param>
        /// <param name="city"></param>
        public Address(string street, string zip, string city) : this(string.Empty, string.Empty, string.Empty, new Countries())
        {
            m_street = string.Empty;
            m_city = string.Empty;
            m_zipCode = string.Empty;
            m_country = new Countries();
        }

        /// <summary>
        /// Constructor 2: All parameters needed in the class
        /// </summary>
        /// <param name="street"></param>
        /// <param name="zip"></param>
        /// <param name="city"></param>
        /// <param name="country"></param>
        public Address(string street, string zip, string city, Countries country)
        {}

        /// <summary>
        /// Property for m_street field
        /// Related to street
        /// Reads and writes access
        /// </summary>
        public string Street
        {
            get { return m_street; }
            set { m_street = value; }
        }

        /// <summary>
        /// Property for m_city field
        /// Related to city
        /// Reads and writes access
        /// </summary>
        public string City
        {
            get { return m_city; }
            set { m_city = value; }
        }

        /// <summary>
        /// Propery for m_zipeCode field
        /// Related to zipcode
        /// Read and write access
        /// </summary>
        public string ZipCode
        {
            get { return m_zipCode; }
            set { m_zipCode = value; }
        }

        /// <summary>
        /// Property for m_country enum field
        /// Related to country
        /// Read and writes access
        /// </summary>
        public Countries Country
        {

            get { return m_country; }

            set { m_country = value; }
        }

        /// <summary>
        /// A bool method that checks if city is empty.
        /// </summary>
        /// <returns>True if field is not empty, False if it is empty</returns>
        public bool CheckData()
        {
            if (String.IsNullOrEmpty(m_city))
            {
                return false;
            }
            else
                return true;
        }

        /// <summary>
        /// Get the string of a country and format is needed
        /// </summary>
        /// <returns></returns>
        public string GetCountryString()
        {
            string strCountry = m_country.ToString();
            strCountry = strCountry.Replace("_", " ");
            return strCountry;
        }


        /// <summary>
        /// Formats string for use in the ListBox.
        /// Calls the method GetCountryString that 
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {

            string strOut = String.Format("{0, 20}{1, 7}{2, 6}{3, 8}", m_street, m_zipCode, m_city, GetCountryString());

            return strOut;
        }

    }
}
