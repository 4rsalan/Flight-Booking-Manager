namespace comp2129Assignment3
{
    partial class FormBooking
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
            this.txtDeleteBookingID = new System.Windows.Forms.TextBox();
            this.lblButtonMessage = new System.Windows.Forms.Label();
            this.lblTextThree = new System.Windows.Forms.Label();
            this.lblColourText = new System.Windows.Forms.Label();
            this.lblTextFour = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDeleteBooking = new System.Windows.Forms.Button();
            this.btnAddBooking = new System.Windows.Forms.Button();
            this.txtViewBookings = new System.Windows.Forms.TextBox();
            this.lblTextOne = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDeleteMessage
            // 
            this.lblDeleteMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteMessage.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteMessage.Location = new System.Drawing.Point(34, 218);
            this.lblDeleteMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteMessage.Name = "lblDeleteMessage";
            this.lblDeleteMessage.Size = new System.Drawing.Size(610, 89);
            this.lblDeleteMessage.TabIndex = 44;
            this.lblDeleteMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIDError
            // 
            this.lblIDError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDError.ForeColor = System.Drawing.Color.Red;
            this.lblIDError.Location = new System.Drawing.Point(351, 474);
            this.lblIDError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDError.Name = "lblIDError";
            this.lblIDError.Size = new System.Drawing.Size(285, 89);
            this.lblIDError.TabIndex = 43;
            this.lblIDError.Text = "The booking ID must be a valid integer greater than 0";
            this.lblIDError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIDError.Visible = false;
            // 
            // txtDeleteBookingID
            // 
            this.txtDeleteBookingID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteBookingID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDeleteBookingID.Location = new System.Drawing.Point(324, 422);
            this.txtDeleteBookingID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeleteBookingID.Name = "txtDeleteBookingID";
            this.txtDeleteBookingID.Size = new System.Drawing.Size(352, 42);
            this.txtDeleteBookingID.TabIndex = 42;
            this.txtDeleteBookingID.Text = "(Booking Id to Delete)";
            this.txtDeleteBookingID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblButtonMessage
            // 
            this.lblButtonMessage.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButtonMessage.Location = new System.Drawing.Point(33, 731);
            this.lblButtonMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblButtonMessage.Name = "lblButtonMessage";
            this.lblButtonMessage.Size = new System.Drawing.Size(645, 35);
            this.lblButtonMessage.TabIndex = 41;
            this.lblButtonMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextThree
            // 
            this.lblTextThree.AutoSize = true;
            this.lblTextThree.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextThree.Location = new System.Drawing.Point(106, 165);
            this.lblTextThree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextThree.Name = "lblTextThree";
            this.lblTextThree.Size = new System.Drawing.Size(475, 35);
            this.lblTextThree.TabIndex = 40;
            this.lblTextThree.Text = "You have the following options:";
            // 
            // lblColourText
            // 
            this.lblColourText.AutoSize = true;
            this.lblColourText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourText.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblColourText.Location = new System.Drawing.Point(490, 115);
            this.lblColourText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColourText.Name = "lblColourText";
            this.lblColourText.Size = new System.Drawing.Size(162, 38);
            this.lblColourText.TabIndex = 39;
            this.lblColourText.Text = "Bookings";
            // 
            // lblTextFour
            // 
            this.lblTextFour.AutoSize = true;
            this.lblTextFour.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFour.Location = new System.Drawing.Point(22, 115);
            this.lblTextFour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextFour.Name = "lblTextFour";
            this.lblTextFour.Size = new System.Drawing.Size(472, 38);
            this.lblTextFour.TabIndex = 38;
            this.lblTextFour.Text = "You Have Chosen to Manage";
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(213, 602);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(255, 49);
            this.btnBack.TabIndex = 37;
            this.btnBack.Text = "Return to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // btnDeleteBooking
            // 
            this.btnDeleteBooking.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteBooking.Location = new System.Drawing.Point(348, 363);
            this.btnDeleteBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteBooking.Name = "btnDeleteBooking";
            this.btnDeleteBooking.Size = new System.Drawing.Size(306, 49);
            this.btnDeleteBooking.TabIndex = 34;
            this.btnDeleteBooking.Text = "Delete a Booking";
            this.btnDeleteBooking.UseVisualStyleBackColor = true;
            this.btnDeleteBooking.Click += new System.EventHandler(this.btnDeleteBooking_Click);
            this.btnDeleteBooking.MouseLeave += new System.EventHandler(this.btnDeleteBooking_MouseLeave);
            this.btnDeleteBooking.MouseHover += new System.EventHandler(this.btnDeleteBooking_MouseHover);
            // 
            // btnAddBooking
            // 
            this.btnAddBooking.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBooking.Location = new System.Drawing.Point(39, 363);
            this.btnAddBooking.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBooking.Name = "btnAddBooking";
            this.btnAddBooking.Size = new System.Drawing.Size(262, 49);
            this.btnAddBooking.TabIndex = 33;
            this.btnAddBooking.Text = "Add a Booking";
            this.btnAddBooking.UseVisualStyleBackColor = true;
            this.btnAddBooking.Click += new System.EventHandler(this.btnAddBooking_Click);
            this.btnAddBooking.MouseLeave += new System.EventHandler(this.btnAddBooking_MouseLeave);
            this.btnAddBooking.MouseHover += new System.EventHandler(this.btnAddBooking_MouseHover);
            // 
            // txtViewBookings
            // 
            this.txtViewBookings.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewBookings.Location = new System.Drawing.Point(687, 77);
            this.txtViewBookings.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtViewBookings.Multiline = true;
            this.txtViewBookings.Name = "txtViewBookings";
            this.txtViewBookings.ReadOnly = true;
            this.txtViewBookings.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtViewBookings.Size = new System.Drawing.Size(464, 746);
            this.txtViewBookings.TabIndex = 35;
            this.txtViewBookings.TabStop = false;
            this.txtViewBookings.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtViewBookings.TextChanged += new System.EventHandler(this.txtViewBookings_TextChanged);
            // 
            // lblTextOne
            // 
            this.lblTextOne.AutoSize = true;
            this.lblTextOne.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOne.Location = new System.Drawing.Point(842, 37);
            this.lblTextOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextOne.Name = "lblTextOne";
            this.lblTextOne.Size = new System.Drawing.Size(148, 35);
            this.lblTextOne.TabIndex = 36;
            this.lblTextOne.Text = "Bookings";
            // 
            // FormBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.lblDeleteMessage);
            this.Controls.Add(this.lblIDError);
            this.Controls.Add(this.txtDeleteBookingID);
            this.Controls.Add(this.lblButtonMessage);
            this.Controls.Add(this.lblTextThree);
            this.Controls.Add(this.lblColourText);
            this.Controls.Add(this.lblTextFour);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteBooking);
            this.Controls.Add(this.btnAddBooking);
            this.Controls.Add(this.txtViewBookings);
            this.Controls.Add(this.lblTextOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "George Brown Airline Services";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormBooking_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteMessage;
        private System.Windows.Forms.Label lblIDError;
        private System.Windows.Forms.TextBox txtDeleteBookingID;
        private System.Windows.Forms.Label lblButtonMessage;
        private System.Windows.Forms.Label lblTextThree;
        private System.Windows.Forms.Label lblColourText;
        private System.Windows.Forms.Label lblTextFour;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDeleteBooking;
        private System.Windows.Forms.Button btnAddBooking;
        private System.Windows.Forms.TextBox txtViewBookings;
        private System.Windows.Forms.Label lblTextOne;
    }
}