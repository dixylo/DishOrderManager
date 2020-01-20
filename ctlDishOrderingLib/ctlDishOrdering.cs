using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ctlDishOrderingLib
{
    /// <summary>
    /// This the view class that collects data from user input
    /// </summary>
    public partial class ctlDishOrdering : UserControl
    {
        private OrderController theController;
        private bool isUpdate;

        public ctlDishOrdering()
        {
            InitializeComponent();
            theController = new OrderController(this);

            // Complete necessary settings for a list view that display the order list
            // Set the view to show details.
            lstOrder.View = View.Details;
            // Select the item and subitems when selection is made.
            lstOrder.FullRowSelect = true;
            // Multiselection not allowed.
            lstOrder.MultiSelect = false;
            // Display grid lines.
            lstOrder.GridLines = true;
            // Let the item remain highlighted when the control loses focus.
            lstOrder.HideSelection = false;

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            lstOrder.Columns.Add("Order ID", -2, HorizontalAlignment.Left);
            lstOrder.Columns.Add("Dish", -2, HorizontalAlignment.Left);
            lstOrder.Columns.Add("Quantity", -2, HorizontalAlignment.Left);
            lstOrder.Columns.Add("Customer", -2, HorizontalAlignment.Left);
            lstOrder.Columns.Add("Phone", -2, HorizontalAlignment.Left);
            lstOrder.Columns.Add("Address", -2, HorizontalAlignment.Left);

            // Display the order list
            showOrderList();
        }

        /// <summary>
        /// Display the order list
        /// </summary>
        public void showOrderList()
        {
            lstOrder.Items.Clear(); // clear before load, to prevent duplication
            
            for(int i = 0; i < theController.getOrderList().Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString()); // creates an order item starting with the ID
                string[] orderDetail = theController.getOrderDetail(i + 1); // gets the rest of the detail of an order
                for(int j = 0; j < 5; j++) 
                {
                    item.SubItems.Add(orderDetail[j]); // fills the rest of the order line
                }
                lstOrder.Items.Add(item); // adds the order item to the list view
            }
        }

        /// <summary>
        /// Click to move hightlight upwards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndices.Count == 0) // if no highlight
            {
                lstOrder.Items[0].Selected = true; // then highlight the first
            }
            else if (lstOrder.SelectedIndices[0] == 0) // the first item highlighted
            {
                lstOrder.Items[0].Selected = true; // keep the highlight on the first one 
            }
            else // another item highlighted
            {
                int index = lstOrder.SelectedIndices[0];
                lstOrder.Items[index].Selected = false;
                lstOrder.Items[index - 1].Selected = true;
            }
        }

        /// <summary>
        /// Click to move hightlight downwards
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNext_Click(object sender, EventArgs e)
        {
            int indexLast = lstOrder.Items.Count - 1;
            if (lstOrder.SelectedIndices.Count == 0) // if no highlight
            {

                lstOrder.Items[indexLast].Selected = true; // then highlight the last
            }
            else if (lstOrder.SelectedIndices[0] == indexLast) // the last highlighted
            {
                lstOrder.Items[indexLast].Selected = true; // keep the highlight on it
            }
            else // another item highlighted
            {
                int index = lstOrder.SelectedIndices[0];
                lstOrder.Items[index].Selected = false;
                lstOrder.Items[index + 1].Selected = true;
            }
        }

        /// <summary>
        /// Click to add an order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            // show the input panel, and hide the entry controls
            pnlAdd.Visible = true;
            pnlControl.Visible = false;
            isUpdate = false;

            // load the menu
            cmbDishName.Items.Clear();
            foreach (string dish in theController.getMenu())
            {
                cmbDishName.Items.Add(dish);
            }

            // load the quantity
            cmbQuantity.Items.Clear();
            for (int i = 0; i < 20; i++) // quantity should have a range because cooks are humans
            {
                cmbQuantity.Items.Add(i + 1);
            }

            // load the customer list
            cmbCustomerName.Items.Clear();
            for(int i = 0; i < theController.getCustomerList().Count; i++)
            {
                cmbCustomerName.Items.Add(theController.getCustomerDetail(i + 1)[0]);
            }
        }

        /// <summary>
        /// Save the input for adding or update an order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Collect the inputs
            string theDishName = cmbDishName.Text;
            string theQuantity = cmbQuantity.Text;
            string theCustomerName = cmbCustomerName.Text;
            string thePhoneNumber = txtPhoneNumber.Text;
            string theAddress = txtAddress.Text;

            if (theDishName == "" || theQuantity == "" || theCustomerName == "" || thePhoneNumber == "" || theAddress == "") // no blanks allowed
            {
                MessageBox.Show("You must specify all the fields!");
            }
            else
            {
                if (isUpdate) // case of update an order
                {
                    string theOrderID = lstOrder.SelectedIndices[0].ToString();
                    theController.updateOrder(theOrderID, theDishName, theQuantity, theCustomerName, thePhoneNumber, theAddress);

                    MessageBox.Show("Order Updated Successfully!");
                }
                else // case of adding an order
                {
                    theController.addOrder(theDishName, theQuantity, theCustomerName, thePhoneNumber, theAddress);

                    // if not a return customer, add to list
                    if (theController.notReturnCustomer(theCustomerName, thePhoneNumber, theAddress)) 
                    {
                        theController.addCustomer(theCustomerName, thePhoneNumber, theAddress);
                    }

                    // reload the customer list
                    cmbCustomerName.Items.Clear();
                    for (int i = 0; i < theController.getCustomerList().Count; i++)
                    {
                        cmbCustomerName.Items.Add(theController.getCustomerDetail(i + 1)[0]);
                    }

                    MessageBox.Show("New Order Placed Successfully!");

                    // clear input fields for next inputs
                    cmbDishName.Text = "";
                    cmbQuantity.Text = "";
                    cmbCustomerName.Text = "";
                    txtPhoneNumber.Text = "";
                    txtAddress.Text = "";
                }

                // update the list view
                showOrderList();
            }
        }

        /// <summary>
        /// Cancel adding or updating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Hide input fields and show entry controls
            pnlAdd.Visible = false;
            pnlControl.Visible = true;

            // clear last inputs
            cmbDishName.Text = "";
            cmbQuantity.Text = "";
            cmbCustomerName.Text = "";
            txtPhoneNumber.Text = "";
            txtAddress.Text = "";
        }

        /// <summary>
        /// Click to modify an order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUpdateOrder_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndices.Count == 0) // Warns if no order is selected
            {
                MessageBox.Show("You must select an order to modify!", "Error!");
            }
            else
            {
                // Show input fields and hide entry controls
                pnlAdd.Visible = true;
                pnlControl.Visible = false;
                isUpdate = true;

                // load the menu
                cmbDishName.Items.Clear();
                foreach (string dish in theController.getMenu())
                {
                    cmbDishName.Items.Add(dish);
                }
                // load the quantity
                cmbQuantity.Items.Clear();
                for (int i = 0; i < 20; i++)
                {
                    cmbQuantity.Items.Add(i + 1);
                }
                // load the customer list
                cmbCustomerName.Items.Clear();
                for (int i = 0; i < theController.getCustomerList().Count; i++)
                {
                    cmbCustomerName.Items.Add(theController.getCustomerDetail(i + 1)[0]);
                }

                // fill the input fields with values to modify
                int indexSelected = lstOrder.SelectedIndices[0];
                cmbDishName.Text = theController.getOrderDetail(indexSelected + 1)[0];
                cmbQuantity.Text = theController.getOrderDetail(indexSelected + 1)[1];
                cmbCustomerName.Text = theController.getOrderDetail(indexSelected + 1)[2];
                txtPhoneNumber.Text = theController.getOrderDetail(indexSelected + 1)[3];
                txtAddress.Text = theController.getOrderDetail(indexSelected + 1)[4];
            }
        }

        /// <summary>
        /// Click to move an order in order to combine same dishes for the cook to make them together to save time and fuel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMoveOrder_Click(object sender, EventArgs e)
        {
            // Show the area for moving orders and hide the entry controls
            pnlMove.Visible = true;
            pnlControl.Visible = false;

            if (lstOrder.SelectedIndices.Count != 0) // checks at least one order is selected
            {
                // load position indices
                cmbIndex.Items.Clear();
                cmbIndex.Text = "";
                for (int i = 0; i < lstOrder.Items.Count; i++)
                {
                    if (i == lstOrder.SelectedIndices[0]) { continue; } // excludes the position at which the moving starts
                    cmbIndex.Items.Add(i + 1);
                }
            }
        }

        /// <summary>
        /// Confirm moving
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndices.Count == 0) // warns if no order is selected
            {
                MessageBox.Show("You must select an order to move!", "Error!");
            }
            else if (cmbIndex.Text == "") // warns if no position is selected
            {
                MessageBox.Show("You must select a position to move the order to!");
            }
            else
            {
                int indexFrom = lstOrder.SelectedIndices[0];
                int indexTo = Convert.ToInt32(cmbIndex.Text) - 1;
                theController.moveOrder(indexFrom, indexTo);
                showOrderList(); // updates the list view
                cmbIndex.Text = ""; // clear the last selection
            }
        }

        /// <summary>
        /// Cancel moving intent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelMove_Click(object sender, EventArgs e)
        {
            // Hide the area for moving order and show the entry controls
            pnlMove.Visible = false;
            pnlControl.Visible = true;
        }

        /// <summary>
        /// Delete an order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndices.Count == 0) // warns if no order is selected
            {
                MessageBox.Show("You must select an order to delete!", "Error!");
            }
            else
            {
                if (MessageBox.Show("Are you sure you want to delete this order?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    int indexToDelete = lstOrder.SelectedIndices[0] + 1;
                    theController.deleteOrder(indexToDelete);
                    showOrderList(); // updates the list view               
                }
            }
        }

        /// <summary>
        /// Close the window by shut the application down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Check that the click on this button is intentional
            if (MessageBox.Show("Are you sure you want to exit?", "Warning", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Application.Exit(); // Exit the application
            }
            
        }
        
        /// <summary>
        /// This is for updating in possible positions to move an order to when the order seleted is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lstOrder_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstOrder.SelectedIndices.Count != 0) // ensures that at least one order is selected
            {
                // Update the possible position to move to
                cmbIndex.Items.Clear();
                cmbIndex.Text = "";
                for (int i = 0; i < lstOrder.Items.Count; i++)
                {
                    if (i == lstOrder.SelectedIndices[0]) { continue; } // excludes the start position
                    cmbIndex.Items.Add(i + 1);
                }
            }
        }

        /// <summary>
        /// This is for updating the phone number and address fields when the customer selected is changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {
            // affiliate the phone number and address with the customer name
            txtPhoneNumber.Text = theController.getCustomerDetail(cmbCustomerName.SelectedIndex + 1)[1];
            txtAddress.Text = theController.getCustomerDetail(cmbCustomerName.SelectedIndex + 1)[2];
        }
    }
}
