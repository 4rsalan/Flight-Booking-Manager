namespace comp2129Assignment3
{
    partial class FormCustomer
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
            this.lblDeleteMessage = new System.Windows.Forms.Label();
            this.lblIDError = new System.Windows.Forms.Label();
            this.txtDeleteCustomerID = new System.Windows.Forms.TextBox();
            this.lblButtonMessage = new System.Windows.Forms.Label();
            this.lblTextThree = new System.Windows.Forms.Label();
            this.lblColourText = new System.Windows.Forms.Label();
            this.lblTextFour = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.txtViewCustomers = new System.Windows.Forms.TextBox();
            this.lblTextOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeleteMessage
            // 
            this.lblDeleteMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteMessage.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteMessage.Location = new System.Drawing.Point(30, 218);
            this.lblDeleteMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteMessage.Name = "lblDeleteMessage";
            this.lblDeleteMessage.Size = new System.Drawing.Size(610, 89);
            this.lblDeleteMessage.TabIndex = 32;
            this.lblDeleteMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIDError
            // 
            this.lblIDError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDError.ForeColor = System.Drawing.Color.Red;
            this.lblIDError.Location = new System.Drawing.Point(346, 474);
            this.lblIDError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDError.Name = "lblIDError";
            this.lblIDError.Size = new System.Drawing.Size(285, 89);
            this.lblIDError.TabIndex = 31;
            this.lblIDError.Text = "The customer ID must be a valid integer greater than 0";
            this.lblIDError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIDError.Visible = false;
            // 
            // txtDeleteCustomerID
            // 
            this.txtDeleteCustomerID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteCustomerID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDeleteCustomerID.Location = new System.Drawing.Point(320, 422);
            this.txtDeleteCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeleteCustomerID.Name = "txtDeleteCustomerID";
            this.txtDeleteCustomerID.Size = new System.Drawing.Size(352, 42);
            this.txtDeleteCustomerID.TabIndex = 30;
            this.txtDeleteCustomerID.Text = "Enter Customer ID";
            this.txtDeleteCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeleteCustomerID.TextChanged += new System.EventHandler(this.txtDeleteCustomerID_TextChanged);
            this.txtDeleteCustomerID.Enter += new System.EventHandler(this.txtDeleteCustomerID_Enter);
            this.txtDeleteCustomerID.Leave += new System.EventHandler(this.txtDeleteCustomerID_Leave);
            // 
            // lblButtonMessage
            // 
            this.lblButtonMessage.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButtonMessage.Location = new System.Drawing.Point(28, 731);
            this.lblButtonMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblButtonMessage.Name = "lblButtonMessage";
            this.lblButtonMessage.Size = new System.Drawing.Size(645, 35);
            this.lblButtonMessage.TabIndex = 29;
            this.lblButtonMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextThree
            // 
            this.lblTextThree.AutoSize = true;
            this.lblTextThree.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextThree.Location = new System.Drawing.Point(102, 165);
            this.lblTextThree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextThree.Name = "lblTextThree";
            this.lblTextThree.Size = new System.Drawing.Size(475, 35);
            this.lblTextThree.TabIndex = 28;
            this.lblTextThree.Text = "You have the following options:";
            // 
            // lblColourText
            // 
            this.lblColourText.AutoSize = true;
            this.lblColourText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourText.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblColourText.Location = new System.Drawing.Point(486, 115);
            this.lblColourText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColourText.Name = "lblColourText";
            this.lblColourText.Size = new System.Drawing.Size(189, 38);
            this.lblColourText.TabIndex = 27;
            this.lblColourText.Text = "Customers";
            // 
            // lblTextFour
            // 
            this.lblTextFour.AutoSize = true;
            this.lblTextFour.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFour.Location = new System.Drawing.Point(18, 115);
            this.lblTextFour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextFour.Name = "lblTextFour";
            this.lblTextFour.Size = new System.Drawing.Size(472, 38);
            this.lblTextFour.TabIndex = 26;
            this.lblTextFour.Text = "You Have Chosen to Manage";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(208, 602);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(255, 49);
            this.btnBack.TabIndex = 25;
            this.btnBack.Text = "Return to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // btnDeleteCustomer
            // 
            this.btnDeleteCustomer.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCustomer.Location = new System.Drawing.Point(344, 363);
            this.btnDeleteCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteCustomer.Name = "btnDeleteCustomer";
            this.btnDeleteCustomer.Size = new System.Drawing.Size(306, 49);
            this.btnDeleteCustomer.TabIndex = 22;
            this.btnDeleteCustomer.Text = "Delete a Customer";
            this.btnDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnDeleteCustomer.Click += new System.EventHandler(this.btnDeleteCustomer_Click);
            this.btnDeleteCustomer.MouseLeave += new System.EventHandler(this.btnDeleteCustomer_MouseLeave);
            this.btnDeleteCustomer.MouseHover += new System.EventHandler(this.btnDeleteCustomer_MouseHover);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(34, 363);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(262, 49);
            this.btnAddCustomer.TabIndex = 21;
            this.btnAddCustomer.Text = "Add a Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            this.btnAddCustomer.MouseLeave += new System.EventHandler(this.btnAddCustomer_MouseLeave);
            this.btnAddCustomer.MouseHover += new System.EventHandler(this.btnAddCustomer_MouseHover);
            // 
            // txtViewCustomers
            // 
            this.txtViewCustomers.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewCustomers.Location = new System.Drawing.Point(682, 77);
            this.txtViewCustomers.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtViewCustomers.Multiline = true;
            this.txtViewCustomers.Name = "txtViewCustomers";
            this.txtViewCustomers.ReadOnly = true;
            this.txtViewCustomers.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtViewCustomers.Size = new System.Drawing.Size(464, 746);
            this.txtViewCustomers.TabIndex = 23;
            this.txtViewCustomers.TabStop = false;
            this.txtViewCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTextOne
            // 
            this.lblTextOne.AutoSize = true;
            this.lblTextOne.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOne.Location = new System.Drawing.Point(801, 37);
            this.lblTextOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextOne.Name = "lblTextOne";
            this.lblTextOne.Size = new System.Drawing.Size(169, 35);
            this.lblTextOne.TabIndex = 24;
            this.lblTextOne.Text = "Customers";
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.lblDeleteMessage);
            this.Controls.Add(this.lblIDError);
            this.Controls.Add(this.txtDeleteCustomerID);
            this.Controls.Add(this.lblButtonMessage);
            this.Controls.Add(this.lblTextThree);
            this.Controls.Add(this.lblColourText);
            this.Controls.Add(this.lblTextFour);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.txtViewCustomers);
            this.Controls.Add(this.lblTextOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "George Brown Airline Services";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCustomer_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteMessage;
        private System.Windows.Forms.Label lblIDError;
        private System.Windows.Forms.TextBox txtDeleteCustomerID;
        private System.Windows.Forms.Label lblButtonMessage;
        private System.Windows.Forms.Label lblTextThree;
        private System.Windows.Forms.Label lblColourText;
        private System.Windows.Forms.Label lblTextFour;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.TextBox txtViewCustomers;
        private System.Windows.Forms.Label lblTextOne;
    }
}