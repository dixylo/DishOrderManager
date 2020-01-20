namespace ctlDishOrderingLib
{
    partial class ctlDishOrdering
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdateOrder = new System.Windows.Forms.Button();
            this.btnMoveOrder = new System.Windows.Forms.Button();
            this.btnDeleteOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.cmbCustomerName = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cmbQuantity = new System.Windows.Forms.ComboBox();
            this.cmbDishName = new System.Windows.Forms.ComboBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblDishName = new System.Windows.Forms.Label();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.pnlMove = new System.Windows.Forms.Panel();
            this.btnCancelMove = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.cmbIndex = new System.Windows.Forms.ComboBox();
            this.lblMove = new System.Windows.Forms.Label();
            this.lstOrder = new System.Windows.Forms.ListView();
            this.pnlAdd.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.pnlMove.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(3, 27);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 30);
            this.btnPrevious.TabIndex = 1;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(3, 67);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 30);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(3, 107);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(100, 30);
            this.btnAddOrder.TabIndex = 3;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnUpdateOrder
            // 
            this.btnUpdateOrder.Location = new System.Drawing.Point(3, 147);
            this.btnUpdateOrder.Name = "btnUpdateOrder";
            this.btnUpdateOrder.Size = new System.Drawing.Size(100, 30);
            this.btnUpdateOrder.TabIndex = 4;
            this.btnUpdateOrder.Text = "Update Order";
            this.btnUpdateOrder.UseVisualStyleBackColor = true;
            this.btnUpdateOrder.Click += new System.EventHandler(this.btnUpdateOrder_Click);
            // 
            // btnMoveOrder
            // 
            this.btnMoveOrder.Location = new System.Drawing.Point(3, 187);
            this.btnMoveOrder.Name = "btnMoveOrder";
            this.btnMoveOrder.Size = new System.Drawing.Size(100, 30);
            this.btnMoveOrder.TabIndex = 5;
            this.btnMoveOrder.Text = "Move Order";
            this.btnMoveOrder.UseVisualStyleBackColor = true;
            this.btnMoveOrder.Click += new System.EventHandler(this.btnMoveOrder_Click);
            // 
            // btnDeleteOrder
            // 
            this.btnDeleteOrder.Location = new System.Drawing.Point(3, 227);
            this.btnDeleteOrder.Name = "btnDeleteOrder";
            this.btnDeleteOrder.Size = new System.Drawing.Size(100, 30);
            this.btnDeleteOrder.TabIndex = 6;
            this.btnDeleteOrder.Text = "Delete Order";
            this.btnDeleteOrder.UseVisualStyleBackColor = true;
            this.btnDeleteOrder.Click += new System.EventHandler(this.btnDeleteOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(3, 267);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 30);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.cmbCustomerName);
            this.pnlAdd.Controls.Add(this.btnCancel);
            this.pnlAdd.Controls.Add(this.btnSave);
            this.pnlAdd.Controls.Add(this.txtAddress);
            this.pnlAdd.Controls.Add(this.txtPhoneNumber);
            this.pnlAdd.Controls.Add(this.cmbQuantity);
            this.pnlAdd.Controls.Add(this.cmbDishName);
            this.pnlAdd.Controls.Add(this.lblAddress);
            this.pnlAdd.Controls.Add(this.lblPhoneNumber);
            this.pnlAdd.Controls.Add(this.lblCustomerName);
            this.pnlAdd.Controls.Add(this.lblQuantity);
            this.pnlAdd.Controls.Add(this.lblDishName);
            this.pnlAdd.Location = new System.Drawing.Point(620, 20);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(216, 254);
            this.pnlAdd.TabIndex = 8;
            this.pnlAdd.Visible = false;
            // 
            // cmbCustomerName
            // 
            this.cmbCustomerName.FormattingEnabled = true;
            this.cmbCustomerName.Location = new System.Drawing.Point(94, 94);
            this.cmbCustomerName.Name = "cmbCustomerName";
            this.cmbCustomerName.Size = new System.Drawing.Size(106, 21);
            this.cmbCustomerName.TabIndex = 12;
            this.cmbCustomerName.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerName_SelectedIndexChanged);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(113, 210);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 30);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(3, 210);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 30);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(94, 174);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(106, 20);
            this.txtAddress.TabIndex = 9;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(94, 134);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(106, 20);
            this.txtPhoneNumber.TabIndex = 8;
            // 
            // cmbQuantity
            // 
            this.cmbQuantity.FormattingEnabled = true;
            this.cmbQuantity.Location = new System.Drawing.Point(94, 54);
            this.cmbQuantity.Name = "cmbQuantity";
            this.cmbQuantity.Size = new System.Drawing.Size(45, 21);
            this.cmbQuantity.TabIndex = 6;
            // 
            // cmbDishName
            // 
            this.cmbDishName.FormattingEnabled = true;
            this.cmbDishName.Location = new System.Drawing.Point(94, 14);
            this.cmbDishName.Name = "cmbDishName";
            this.cmbDishName.Size = new System.Drawing.Size(107, 21);
            this.cmbDishName.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(40, 177);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(48, 13);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address:";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(7, 137);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(81, 13);
            this.lblPhoneNumber.TabIndex = 3;
            this.lblPhoneNumber.Text = "Phone Number:";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Location = new System.Drawing.Point(3, 97);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(85, 13);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(39, 57);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 1;
            this.lblQuantity.Text = "Quantity:";
            // 
            // lblDishName
            // 
            this.lblDishName.AutoSize = true;
            this.lblDishName.Location = new System.Drawing.Point(26, 17);
            this.lblDishName.Name = "lblDishName";
            this.lblDishName.Size = new System.Drawing.Size(62, 13);
            this.lblDishName.TabIndex = 0;
            this.lblDishName.Text = "Dish Name:";
            // 
            // pnlControl
            // 
            this.pnlControl.Controls.Add(this.btnPrevious);
            this.pnlControl.Controls.Add(this.btnNext);
            this.pnlControl.Controls.Add(this.btnExit);
            this.pnlControl.Controls.Add(this.btnAddOrder);
            this.pnlControl.Controls.Add(this.btnDeleteOrder);
            this.pnlControl.Controls.Add(this.btnUpdateOrder);
            this.pnlControl.Controls.Add(this.btnMoveOrder);
            this.pnlControl.Location = new System.Drawing.Point(511, 3);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(107, 317);
            this.pnlControl.TabIndex = 9;
            // 
            // pnlMove
            // 
            this.pnlMove.Controls.Add(this.btnCancelMove);
            this.pnlMove.Controls.Add(this.btnConfirm);
            this.pnlMove.Controls.Add(this.cmbIndex);
            this.pnlMove.Controls.Add(this.lblMove);
            this.pnlMove.Location = new System.Drawing.Point(86, 306);
            this.pnlMove.Name = "pnlMove";
            this.pnlMove.Size = new System.Drawing.Size(325, 46);
            this.pnlMove.TabIndex = 10;
            this.pnlMove.Visible = false;
            // 
            // btnCancelMove
            // 
            this.btnCancelMove.Location = new System.Drawing.Point(215, 7);
            this.btnCancelMove.Name = "btnCancelMove";
            this.btnCancelMove.Size = new System.Drawing.Size(100, 30);
            this.btnCancelMove.TabIndex = 3;
            this.btnCancelMove.Text = "Cancel";
            this.btnCancelMove.UseVisualStyleBackColor = true;
            this.btnCancelMove.Click += new System.EventHandler(this.btnCancelMove_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(109, 7);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(100, 30);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // cmbIndex
            // 
            this.cmbIndex.FormattingEnabled = true;
            this.cmbIndex.Location = new System.Drawing.Point(65, 13);
            this.cmbIndex.Name = "cmbIndex";
            this.cmbIndex.Size = new System.Drawing.Size(38, 21);
            this.cmbIndex.TabIndex = 1;
            // 
            // lblMove
            // 
            this.lblMove.AutoSize = true;
            this.lblMove.Location = new System.Drawing.Point(3, 16);
            this.lblMove.Name = "lblMove";
            this.lblMove.Size = new System.Drawing.Size(66, 13);
            this.lblMove.TabIndex = 0;
            this.lblMove.Text = "Move to No.";
            // 
            // lstOrder
            // 
            this.lstOrder.Location = new System.Drawing.Point(9, 32);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(496, 268);
            this.lstOrder.TabIndex = 11;
            this.lstOrder.UseCompatibleStateImageBehavior = false;
            this.lstOrder.SelectedIndexChanged += new System.EventHandler(this.lstOrder_SelectedIndexChanged);
            // 
            // ctlDishOrdering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.pnlMove);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.pnlAdd);
            this.Name = "ctlDishOrdering";
            this.Size = new System.Drawing.Size(880, 370);
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlControl.ResumeLayout(false);
            this.pnlMove.ResumeLayout(false);
            this.pnlMove.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnUpdateOrder;
        private System.Windows.Forms.Button btnMoveOrder;
        private System.Windows.Forms.Button btnDeleteOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cmbQuantity;
        private System.Windows.Forms.ComboBox cmbDishName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblDishName;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Panel pnlMove;
        private System.Windows.Forms.Button btnCancelMove;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.ComboBox cmbIndex;
        private System.Windows.Forms.Label lblMove;
        private System.Windows.Forms.ListView lstOrder;
        private System.Windows.Forms.ComboBox cmbCustomerName;
    }
}
