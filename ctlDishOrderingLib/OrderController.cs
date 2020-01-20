using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ctlDishOrderingLib
{
    /// <summary>
    /// This is a controller class that communicates with the view and the model.
    /// </summary>
    class OrderController
    {
        private ctlDishOrdering theInterface;
        private List<Order> orderList;
        private List<Customer> customerList;
        private List<string> menu;

        public OrderController(ctlDishOrdering newInterface)
        {
            theInterface = newInterface;

            // Read the database
            readOrderList();
            readCustomerList();
            readMenu();
        }

        /// <summary>
        /// Read the orders saved in the database
        /// </summary>
        private void readOrderList()
        {
            Order anOrder;
            orderList = new List<Order>();

            StreamReader srOrder = new StreamReader(@"..\..\..\OrderList.txt");
            string orderLine;

            try
            {
                while ((orderLine = srOrder.ReadLine()) != null)
                {
                    anOrder = new Order();
                    anOrder.setOrder(orderLine);
                    orderList.Add(anOrder);
                }
            }
            catch (IOException)
            {
                Console.Write("Exception caught while reading the order list file");
            }
            finally
            {
                srOrder.Close(); // closes the file to read and releases all resources
            }
        }

        /// <summary>
        /// Read the customer info saved in the database
        /// </summary>
        private void readCustomerList()
        {
            Customer aCustomer;
            customerList = new List<Customer>();

            StreamReader srCustomer = new StreamReader(@"..\..\..\CustomerList.txt");
            string customerInfo;

            try
            {
                while ((customerInfo = srCustomer.ReadLine()) != null)
                {
                    aCustomer = new Customer();
                    aCustomer.setCustomer(customerInfo);
                    customerList.Add(aCustomer);
                }
            }
            catch (IOException)
            {
                Console.Write("Exception caught while reading the customer list file");
            }
            finally
            {
                srCustomer.Close(); // closes the file to read and releases all resources
            }
        }

        /// <summary>
        /// Read the menu saved in the database
        /// </summary>
        private void readMenu()
        {
            StreamReader srMenu = new StreamReader(@"..\..\..\Menu.txt");
            menu = new List<string>();
            string dishName;

            try
            {
                while ((dishName = srMenu.ReadLine()) != null)
                {
                    menu.Add(dishName);
                }
            }
            catch (IOException)
            {
                Console.Write("Exception caught while reading the menu file");
            }
            finally
            {
                srMenu.Close(); // closes the file to read and releases all resources
            }
        }

        /// <summary>
        /// Add a new order
        /// </summary>
        /// <param name="theDishName"></param>
        /// <param name="theQuantity"></param>
        /// <param name="theCustomerName"></param>
        /// <param name="thePhoneNumber"></param>
        /// <param name="theAddress"></param>
        public void addOrder(string theDishName, string theQuantity, string theCustomerName, string thePhoneNumber, string theAddress)
        {
            Order newOrder = new Order();
            newOrder.setOrderID(orderList.Count + 1);
            newOrder.setDishName(theDishName);
            newOrder.setQuantity(theQuantity);
            newOrder.setCustomerName(theCustomerName);
            newOrder.setPhoneNumber(thePhoneNumber);
            newOrder.setAddress(theAddress);           
            orderList.Add(newOrder);

            // Update the order database
            updateOrderList();
        }

        /// <summary>
        /// Add a new customer
        /// </summary>
        /// <param name="theCustomerName"></param>
        /// <param name="thePhoneNumber"></param>
        /// <param name="theAddress"></param>
        public void addCustomer(string theCustomerName, string thePhoneNumber, string theAddress)
        {
            Customer newCustomer = new Customer();
            newCustomer.setCustomerID(customerList.Count + 1);
            newCustomer.setCustomerName(theCustomerName);
            newCustomer.setPhoneNumber(thePhoneNumber);
            newCustomer.setAddress(theAddress);
            customerList.Add(newCustomer);

            // Update the customer database
            updateCustomerList();
        }

        /// <summary>
        /// Update an order
        /// </summary>
        /// <param name="theOrderID"></param>
        /// <param name="theDishName"></param>
        /// <param name="theQuantity"></param>
        /// <param name="theCustomerName"></param>
        /// <param name="thePhoneNumber"></param>
        /// <param name="theAddress"></param>
        public void updateOrder(string theOrderID, string theDishName, string theQuantity, string theCustomerName, string thePhoneNumber, string theAddress)
        {
            int theIndex = Convert.ToInt32(theOrderID);
            orderList[theIndex].setDishName(theDishName);
            orderList[theIndex].setQuantity(theQuantity);
            orderList[theIndex].setCustomerName(theCustomerName);
            orderList[theIndex].setPhoneNumber(thePhoneNumber);
            orderList[theIndex].setAddress(theAddress);

            // Update the order database
            updateOrderList();
        }

        /// <summary>
        /// Delete an order
        /// </summary>
        /// <param name="indexToDelete"></param>
        public void deleteOrder(int indexToDelete)
        {
            orderList.RemoveAt(indexToDelete - 1);

            // Update the order database
            updateOrderList();
        }

        /// <summary>
        /// Move an order
        /// </summary>
        /// <param name="indexFrom"></param>
        /// <param name="indexTo"></param>
        public void moveOrder(int indexFrom, int indexTo)
        {
            Order orderToMove = orderList[indexFrom];
            orderList.RemoveAt(indexFrom); // removes the order first
            orderList.Insert(indexTo, orderToMove); // then inserts the order to an new place
            
            // Update the order database
            updateOrderList();
        }

        /// <summary>
        /// Update the order database
        /// </summary>
        private void updateOrderList()
        {
            StreamWriter sw = new StreamWriter(@"..\..\..\OrderList.txt");

            for(int i = 0; i < orderList.Count; i++)
            {
                orderList[i].setOrderID(i + 1); // updates the orderID, making it the same to the index+1
                sw.WriteLine(orderList[i].getOrder()); // writes the order
            }

            sw.Close(); // closes the file to write and releases all resources
        }

        /// <summary>
        /// Update the customer database
        /// </summary>
        private void updateCustomerList()
        {
            StreamWriter sw = new StreamWriter(@"..\..\..\CustomerList.txt");

            for (int i = 0; i < customerList.Count; i++)
            {
                customerList[i].setCustomerID(i + 1); // updates the orderID, making it the same to the index+1
                sw.WriteLine(customerList[i].getCustomer()); // writes the order
            }


            sw.Close(); // closes the file to write and releases all resources
        }

        /// <summary>
        /// Get the detail of an order
        /// </summary>
        /// <param name="orderID"></param>
        /// <returns></returns>
        public string[] getOrderDetail(int orderID)
        {
            string[] orderDetail = new string[5];

            foreach(Order order in orderList)
            {
                // Check the ID is equal to some one in the list
                if (orderID == order.getOrderID())
                {
                    orderDetail[0] = order.getDishName();
                    orderDetail[1] = order.getQuantity();
                    orderDetail[2] = order.getCustomerName();
                    orderDetail[3] = order.getPhoneNumber();
                    orderDetail[4] = order.getAddress();
                }
            }

            return orderDetail;
        }

        /// <summary>
        /// Get the detail of a customer
        /// </summary>
        /// <param name="customerID"></param>
        /// <returns></returns>
        public string[] getCustomerDetail(int customerID)
        {
            string[] customerDetail = new string[3];

            foreach(Customer customer in customerList)
            {
                // Check the ID is equal to some one in the list
                if (customerID == customer.getCustomerID())
                {
                    customerDetail[0] = customer.getCustomerName();
                    customerDetail[1] = customer.getPhoneNumber();
                    customerDetail[2] = customer.getAddress();
                }
            }
            return customerDetail;
        }

        /// <summary>
        /// Return the order list
        /// </summary>
        /// <returns></returns>
        public List<Order> getOrderList()
        {
            return orderList;
        }

        /// <summary>
        /// Return the customer list
        /// </summary>
        /// <returns></returns>
        public List<Customer> getCustomerList()
        {
            return customerList;
        }

        /// <summary>
        /// Return the menu
        /// </summary>
        /// <returns></returns>
        public List<string> getMenu()
        {
            return menu;
        }

        /// <summary>
        /// Check a customer is not in the customer list
        /// </summary>
        /// <param name="customerName"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <returns></returns>
        public bool notReturnCustomer(string customerName, string phoneNumber, string address)
        {
            foreach(Customer customer in customerList)
            {
                if (customer.isReturnCustomer(customerName, phoneNumber, address))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
