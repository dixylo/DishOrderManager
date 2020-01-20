namespace Test
{
    partial class TestForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ctlDishOrdering1 = new ctlDishOrderingLib.ctlDishOrdering();
            this.SuspendLayout();
            // 
            // ctlDishOrdering1
            // 
            this.ctlDishOrdering1.Location = new System.Drawing.Point(10, 8);
            this.ctlDishOrdering1.Name = "ctlDishOrdering1";
            this.ctlDishOrdering1.Size = new System.Drawing.Size(973, 436);
            this.ctlDishOrdering1.TabIndex = 0;
            // 
            // TestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 450);
            this.Controls.Add(this.ctlDishOrdering1);
            this.Name = "TestForm";
            this.Text = "TestForm";
            this.ResumeLayout(false);

        }

        #endregion

        private ctlDishOrderingLib.ctlDishOrdering ctlDishOrdering1;
    }
}

