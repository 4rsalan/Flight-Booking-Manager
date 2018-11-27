namespace comp2129Assignment3
{
    partial class FormAddBooking
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
            this.lblTextOne = new System.Windows.Forms.Label();
            this.lblTextTwo = new System.Windows.Forms.Label();
            this.lblAddingError = new System.Windows.Forms.Label();
            this.lblTextThree = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.txtFlightID = new System.Windows.Forms.TextBox();
            this.lblCustomerIDError = new System.Windows.Forms.Label();
            this.lblFlightIDError = new System.Windows.Forms.Label();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.lblEmptyFieldError = new System.Windows.Forms.Label();
            this.btnMenu = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtViewList = new System.Windows.Forms.TextBox();
            this.lblListViewing = new System.Windows.Forms.Label();
            this.btnViewing = new System.Windows.Forms.Button();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTextOne
            // 
            this.lblTextOne.AutoSize = true;
            this.lblTextOne.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOne.Location = new System.Drawing.Point(602, 14);
            this.lblTextOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextOne.Name = "lblTextOne";
            this.lblTextOne.Size = new System.Drawing.Size(281, 44);
            this.lblTextOne.TabIndex = 9;
            this.lblTextOne.Text = "Add a Booking";
            // 
            // lblTextTwo
            // 
            this.lblTextTwo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextTwo.Location = new System.Drawing.Point(464, 58);
            this.lblTextTwo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextTwo.Name = "lblTextTwo";
            this.lblTextTwo.Size = new System.Drawing.Size(540, 112);
            this.lblTextTwo.TabIndex = 14;
            this.lblTextTwo.Text = "Enter the corresponsing information into all of the text boxes below";
            this.lblTextTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAddingError
            // 
            this.lblAddingError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingError.ForeColor = System.Drawing.Color.Red;
            this.lblAddingError.Location = new System.Drawing.Point(464, 171);
            this.lblAddingError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddingError.Name = "lblAddingError";
            this.lblAddingError.Size = new System.Drawing.Size(590, 109);
            this.lblAddingError.TabIndex = 28;
            this.lblAddingError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextThree
            // 
            this.lblTextThree.AutoSize = true;
            this.lblTextThree.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextThree.Location = new System.Drawing.Point(618, 306);
            this.lblTextThree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextThree.Name = "lblTextThree";
            this.lblTextThree.Size = new System.Drawing.Size(208, 35);
            this.lblTextThree.TabIndex = 29;
            this.lblTextThree.Text = "Customer Id:";
            this.lblTextThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 523);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 35);
            this.label1.TabIndex = 30;
            this.label1.Text = "Flight Id:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtCustomerID.Location = new System.Drawing.Point(570, 346);
            this.txtCustomerID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(313, 42);
            this.txtCustomerID.TabIndex = 31;
            this.txtCustomerID.Text = "Enter Customer ID";
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomerID.Leave += new System.EventHandler(this.txtCustomerID_Leave);
            // 
            // txtFlightID
            // 
            this.txtFlightID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtFlightID.Location = new System.Drawing.Point(570, 563);
            this.txtFlightID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFlightID.Name = "txtFlightID";
            this.txtFlightID.Size = new System.Drawing.Size(313, 42);
            this.txtFlightID.TabIndex = 32;
            this.txtFlightID.Text = "Enter Flight ID";
            this.txtFlightID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFlightID.Leave += new System.EventHandler(this.txtFlightID_Leave);
            // 
            // lblCustomerIDError
            // 
            this.lblCustomerIDError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerIDError.ForeColor = System.Drawing.Color.Red;
            this.lblCustomerIDError.Location = new System.Drawing.Point(464, 398);
            this.lblCustomerIDError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCustomerIDError.Name = "lblCustomerIDError";
            this.lblCustomerIDError.Size = new System.Drawing.Size(510, 63);
            this.lblCustomerIDError.TabIndex = 33;
            this.lblCustomerIDError.Text = "The customer ID must be a valid integer greater than 0";
            this.lblCustomerIDError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCustomerIDError.Visible = false;
            // 
            // lblFlightIDError
            // 
            this.lblFlightIDError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFlightIDError.ForeColor = System.Drawing.Color.Red;
            this.lblFlightIDError.Location = new System.Drawing.Point(464, 615);
            this.lblFlightIDError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFlightIDError.Name = "lblFlightIDError";
            this.lblFlightIDError.Size = new System.Drawing.Size(510, 63);
            this.lblFlightIDError.TabIndex = 34;
            this.lblFlightIDError.Text = "The customer ID must be a valid integer greater than 0";
            this.lblFlightIDError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFlightIDError.Visible = false;
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.Location = new System.Drawing.Point(609, 715);
            this.btnAddBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(232, 51);
            this.btnAddBooking.TabIndex = 35;
            this.btnAddBooking.Text = "Add Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            this.btnAddBooking.MouseLeave += new System.EventHandler(this.btnAddBooking_MouseLeave);
            this.btnAddBooking.MouseHover += new System.EventHandler(this.btnAddBooking_MouseHover);
            // 
            // lblEmptyFieldError
            // 
            this.lblEmptyFieldError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyFieldError.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyFieldError.Location = new System.Drawing.Point(584, 771);
            this.lblEmptyFieldError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmptyFieldError.Name = "lblEmptyFieldError";
            this.lblEmptyFieldError.Size = new System.Drawing.Size(302, 60);
            this.lblEmptyFieldError.TabIndex = 36;
            this.lblEmptyFieldError.Text = "Not all fields have been filled";
            this.lblEmptyFieldError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyFieldError.Visible = false;
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(900, 794);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(258, 51);
            this.btnMenu.TabIndex = 37;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(1030, 715);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(128, 51);
            this.btnBack.TabIndex = 38;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtViewList
            // 
            this.txtViewList.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewList.Location = new System.Drawing.Point(-12, 58);
            this.txtViewList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtViewList.Multiline = true;
            this.txtViewList.Name = "txtViewList";
            this.txtViewList.ReadOnly = true;
            this.txtViewList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtViewList.Size = new System.Drawing.Size(464, 746);
            this.txtViewList.TabIndex = 39;
            this.txtViewList.TabStop = false;
            this.txtViewList.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblListViewing
            // 
            this.lblListViewing.AutoSize = true;
            this.lblListViewing.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListViewing.Location = new System.Drawing.Point(142, 9);
            this.lblListViewing.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListViewing.Name = "lblListViewing";
            this.lblListViewing.Size = new System.Drawing.Size(137, 44);
            this.lblListViewing.TabIndex = 40;
            this.lblListViewing.Text = "Flights";
            // 
            // btnViewing
            // 
            this.btnViewing.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewing.Location = new System.Drawing.Point(84, 811);
            this.btnViewing.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnViewing.Name = "btnViewing";
            this.btnViewing.Size = new System.Drawing.Size(264, 51);
            this.btnViewing.TabIndex = 41;
            this.btnViewing.Text = "View Customers";
            this.btnViewing.UseVisualStyleBackColor = true;
            this.btnViewing.Click += new System.EventHandler(this.btnViewing_Click);
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Location = new System.Drawing.Point(982, 518);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(176, 92);
            this.btnAddFlight.TabIndex = 42;
            this.btnAddFlight.Text = "Add a Flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCustomer.Location = new System.Drawing.Point(982, 302);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(176, 92);
            this.btnAddCustomer.TabIndex = 43;
            this.btnAddCustomer.Text = "Add a Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // FormAddBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.btnViewing);
            this.Controls.Add(this.lblListViewing);
            this.Controls.Add(this.txtViewList);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.lblEmptyFieldError);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.lblFlightIDError);
            this.Controls.Add(this.lblCustomerIDError);
            this.Controls.Add(this.txtFlightID);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTextThree);
            this.Controls.Add(this.lblAddingError);
            this.Controls.Add(this.lblTextTwo);
            this.Controls.Add(this.lblTextOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormAddBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "George Brown Airline Services";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddBooking_FormClosed);
            this.Load += new System.EventHandler(this.FormAddBooking_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextOne;
        private System.Windows.Forms.Label lblTextTwo;
        private System.Windows.Forms.Label lblAddingError;
        private System.Windows.Forms.Label lblTextThree;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.TextBox txtFlightID;
        private System.Windows.Forms.Label lblCustomerIDError;
        private System.Windows.Forms.Label lblFlightIDError;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.Label lblEmptyFieldError;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtViewList;
        private System.Windows.Forms.Label lblListViewing;
        private System.Windows.Forms.Button btnViewing;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnAddCustomer;
    }
}