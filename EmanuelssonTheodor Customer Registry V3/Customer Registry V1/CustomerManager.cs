using Customer_Registry_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Registry_V1
{
    class CustomerManager
    {
        // A field for list of customers
        private List<Customer> m_customers;

        /// <summary>
        /// Constructor 0: Default
        /// Creates a new list of customers
        /// </summary>
        public CustomerManager()
        {
            m_customers = new List<Customer>();
        }

        /// <summary>
        /// Property for counting the customers
        /// Read access
        /// </summary>
        public int Count
        {
            get { return m_customers.Count; }
        }
        /// <summary>
        /// Propery for ID that adds 1 to the count of the customer
        /// Read access
        /// </summary>
        public int GetNewID
        {
            get { return Count + 1; }
        }

        /// <summary>
        /// Method that adds a new customer
        /// Creates new ID and formats ID string
        /// </summary>
        /// <param name="contactIn"></param>
        public void AddCustomer(Contact contactIn)
        {
            string newID = GetNewID.ToString();
            Customer newCustomer = new Customer(contactIn, newID);
            m_customers.Add(newCustomer);
        }

        /// <summary>
        /// A bool fpr checking if customer is added correctly
        /// </summary>
        /// <param name="customerIn"></param>
        /// <returns></returns>
        public bool AddCustomer(Customer customerIn)
        {
            if (Count + 2 >= 0 && Convert.ToInt32(customerIn.ID) < m_customers.Count)
            {

                m_customers.Add(customerIn);

                customerIn.ID = GetNewID.ToString();

                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// Method for changing a contact
        /// Recieves the contact data at an index
        /// </summary>
        /// <param name="contactIn"></param>
        /// <param name="index"></param>
        public void ChangeCustomer(Contact contactIn, int index)
        {

            m_customers[index].ContactData = contactIn;

        }

        /// <summary>
        /// Bool for deleting a customer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public bool DeleteCustomer(int index)
        {
            if(index >= 0)
            {
                m_customers.RemoveAt(index);
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// The method for searching a customer based on the complete name
        /// of that customer. It Searches the customer list and finds equivalent name
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns>the customer</returns>
        public Customer SearchCustomer(string str)
        {

            Customer customer = m_customers.Find(delegate (Customer c)
            { return c.ContactData.CompleteName.Equals(str); });

            return customer;
        }

        /// <summary>
        /// Method for getting a customer at inputed index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Customer GetCustomer(int index)
        {
            return m_customers[index];
        }

        /// <summary>
        /// Method that get the information related to a customer
        /// </summary>
        /// <returns></returns>
        public string[] GetCustomerInfo()
        {
            string[] getCustomer = new string[m_customers.Count];

            for (int index = 0; index < (m_customers.Count); index++)
            {
                getCustomer[index] = m_customers[index].ToString();

            }

            return getCustomer;
        }

    }
}
