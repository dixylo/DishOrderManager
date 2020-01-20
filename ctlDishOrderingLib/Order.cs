using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctlDishOrderingLib
{
    /// <summary>
    /// This is an entity class that manages the information of placed orders
    /// </summary>
    class Order
    {
        protected int orderID;
        protected string dishName;
        protected string quantity;
        protected string customerName;
        protected string phoneNumber;
        protected string address;

        /// <summary>
        /// Get methods
        /// </summary>
        /// <returns></returns>
        public int getOrderID()
        {
            return orderID;
        }

        public string getDishName()
        {
            return dishName;
        }

        public string getQuantity()
        {
            return quantity;
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
        /// This method returns a string containing all fields of an order.
        /// </summary>
        /// <returns></returns>
        public string getOrder()
        {
            return orderID.ToString() + "," + dishName + "," + quantity + "," + customerName + "," + phoneNumber + "," + address;
        }

        /// <summary>
        /// Set methods
        /// </summary>
        /// <param name="newOrderID"></param>
        public void setOrderID(int newOrderID)
        {
            orderID = newOrderID;
        }

        public void setDishName(string newDishName)
        {
            dishName = newDishName;
        }

        public void setQuantity(string newQuantity)
        {
            quantity = newQuantity;
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
        /// <param name="orderLine"></param>
        public void setOrder(string orderLine)
        {
            string[] fields = orderLine.Split(',');
            setOrderID(Convert.ToInt32(fields[0]));
            setDishName(fields[1]);
            setQuantity(fields[2]);
            setCustomerName(fields[3]);
            setPhoneNumber(fields[4]);
            setAddress(fields[5]);
        }
    }
}
