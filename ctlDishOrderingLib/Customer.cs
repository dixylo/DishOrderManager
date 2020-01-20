using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctlDishOrderingLib
{
    /// <summary>
    /// This is an entity class that manages the information of customers who have placed any orders.
    /// </summary>
    class Customer
    {
        protected int customerID;
        protected string customerName;
        protected string phoneNumber;
        protected string address;

        /// <summary>
        /// Get methods
        /// </summary>
        /// <returns></returns>
        public int getCustomerID()
        {
            return customerID;
        }

        public string getCustomerName()
        {
            return customerName;
        }

        public string getPhoneNumber()
        {
            return phoneNumber;
        }

        public string getAddress()
        {
            return address;
        }

        /// <summary>
        /// This method returns a string containing all fields of an customer.
        /// </summary>
        /// <returns></returns>
        public string getCustomer()
        {
            return customerID.ToString() + "," + customerName + "," + phoneNumber + "," + address;
        }

        /// <summary>
        /// Set methods
        /// </summary>
        /// <param name="newCustomerID"></param>
        public void setCustomerID(int newCustomerID)
        {
            customerID = newCustomerID;
        }

        public void setCustomerName(string newCustomerName)
        {
            customerName = newCustomerName;
        }

        public void setPhoneNumber(string newPhoneNumber)
        {
            phoneNumber = newPhoneNumber;
        }

        public void setAddress(string newAddress)
        {
            address = newAddress;
        }

        /// <summary>
        /// This method substantiates an order object with a string of order fields.
        /// </summary>
        /// <param name="customerInfo"></param>
        public void setCustomer(string customerInfo)
        {
            string[] fields = customerInfo.Split(',');
            setCustomerID(Convert.ToInt32(fields[0]));
            setCustomerName(fields[1]);
            setPhoneNumber(fields[2]);
            setAddress(fields[3]);
        }

        /// <summary>
        /// Tell if a customer is a return customer
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phone"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool isReturnCustomer(string name, string phone, string address)
        {
            if (customerName == name && phoneNumber == phone && this.address == address)
            {
                return true;
            }

            return false;
        }
    }
}
