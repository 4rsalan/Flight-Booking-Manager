namespace comp2129Assignment3
{
    partial class FormAddFlight
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
            this.txtFlightID = new System.Windows.Forms.TextBox();
            this.txtStartingDestination = new System.Windows.Forms.TextBox();
            this.txtLandingDestination = new System.Windows.Forms.TextBox();
            this.txtNumberOfSeats = new System.Windows.Forms.TextBox();
            this.lblTextTwo = new System.Windows.Forms.Label();
            this.lblTextThree = new System.Windows.Forms.Label();
            this.lblTextFour = new System.Windows.Forms.Label();
            this.lblTextFive = new System.Windows.Forms.Label();
            this.lblTextSeven = new System.Windows.Forms.Label();
            this.lblTextSix = new System.Windows.Forms.Label();
            this.lblIDError = new System.Windows.Forms.Label();
            this.lblStartingDestinationError = new System.Windows.Forms.Label();
            this.lblLandingDestinationError = new System.Windows.Forms.Label();
            this.lblNumberOfSeatsError = new System.Windows.Forms.Label();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.lblEmptyFieldError = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            this.lblAddingError = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextOne
            // 
            this.lblTextOne.AutoSize = true;
            this.lblTextOne.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOne.Location = new System.Drawing.Point(309, 9);
            this.lblTextOne.Name = "lblTextOne";
            this.lblTextOne.Size = new System.Drawing.Size(154, 29);
            this.lblTextOne.TabIndex = 7;
            this.lblTextOne.Text = "Add a Flight";
            // 
            // txtFlightID
            // 
            this.txtFlightID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFlightID.Location = new System.Drawing.Point(320, 134);
            this.txtFlightID.Name = "txtFlightID";
            this.txtFlightID.Size = new System.Drawing.Size(130, 31);
            this.txtFlightID.TabIndex = 0;
            this.txtFlightID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFlightID.Leave += new System.EventHandler(this.txtFlightID_Leave);
            // 
            // txtStartingDestination
            // 
            this.txtStartingDestination.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStartingDestination.Location = new System.Drawing.Point(148, 230);
            this.txtStartingDestination.Name = "txtStartingDestination";
            this.txtStartingDestination.Size = new System.Drawing.Size(198, 31);
            this.txtStartingDestination.TabIndex = 1;
            this.txtStartingDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtStartingDestination.Leave += new System.EventHandler(this.txtStartingDestination_Leave);
            // 
            // txtLandingDestination
            // 
            this.txtLandingDestination.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLandingDestination.Location = new System.Drawing.Point(423, 230);
            this.txtLandingDestination.Name = "txtLandingDestination";
            this.txtLandingDestination.Size = new System.Drawing.Size(208, 31);
            this.txtLandingDestination.TabIndex = 2;
            this.txtLandingDestination.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtLandingDestination.Leave += new System.EventHandler(this.txtLandingDestination_Leave);
            // 
            // txtNumberOfSeats
            // 
            this.txtNumberOfSeats.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfSeats.Location = new System.Drawing.Point(320, 369);
            this.txtNumberOfSeats.Name = "txtNumberOfSeats";
            this.txtNumberOfSeats.Size = new System.Drawing.Size(130, 31);
            this.txtNumberOfSeats.TabIndex = 3;
            this.txtNumberOfSeats.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumberOfSeats.Leave += new System.EventHandler(this.txtNumberOfSeats_Leave);
            // 
            // lblTextTwo
            // 
            this.lblTextTwo.AutoSize = true;
            this.lblTextTwo.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextTwo.Location = new System.Drawing.Point(60, 38);
            this.lblTextTwo.Name = "lblTextTwo";
            this.lblTextTwo.Size = new System.Drawing.Size(664, 23);
            this.lblTextTwo.TabIndex = 12;
            this.lblTextTwo.Text = "Enter the corresponsing information into all of the text boxes below";
            this.lblTextTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextThree
            // 
            this.lblTextThree.AutoSize = true;
            this.lblTextThree.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextThree.Location = new System.Drawing.Point(333, 108);
            this.lblTextThree.Name = "lblTextThree";
            this.lblTextThree.Size = new System.Drawing.Size(103, 23);
            this.lblTextThree.TabIndex = 13;
            this.lblTextThree.Text = "Flight ID:";
            this.lblTextThree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextFour
            // 
            this.lblTextFour.AutoSize = true;
            this.lblTextFour.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFour.Location = new System.Drawing.Point(144, 204);
            this.lblTextFour.Name = "lblTextFour";
            this.lblTextFour.Size = new System.Drawing.Size(202, 23);
            this.lblTextFour.TabIndex = 14;
            this.lblTextFour.Text = "Starting Destination";
            this.lblTextFour.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextFive
            // 
            this.lblTextFive.AutoSize = true;
            this.lblTextFive.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFive.Location = new System.Drawing.Point(369, 233);
            this.lblTextFive.Name = "lblTextFive";
            this.lblTextFive.Size = new System.Drawing.Size(29, 23);
            this.lblTextFive.TabIndex = 15;
            this.lblTextFive.Text = "to";
            this.lblTextFive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextSeven
            // 
            this.lblTextSeven.AutoSize = true;
            this.lblTextSeven.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextSeven.Location = new System.Drawing.Point(245, 343);
            this.lblTextSeven.Name = "lblTextSeven";
            this.lblTextSeven.Size = new System.Drawing.Size(271, 23);
            this.lblTextSeven.TabIndex = 16;
            this.lblTextSeven.Text = "Number of Seats on Flight:";
            this.lblTextSeven.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTextSix
            // 
            this.lblTextSix.AutoSize = true;
            this.lblTextSix.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextSix.Location = new System.Drawing.Point(425, 204);
            this.lblTextSix.Name = "lblTextSix";
            this.lblTextSix.Size = new System.Drawing.Size(202, 23);
            this.lblTextSix.TabIndex = 17;
            this.lblTextSix.Text = "Landing Destination";
            this.lblTextSix.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblIDError
            // 
            this.lblIDError.AutoSize = true;
            this.lblIDError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDError.ForeColor = System.Drawing.Color.Red;
            this.lblIDError.Location = new System.Drawing.Point(164, 168);
            this.lblIDError.Name = "lblIDError";
            this.lblIDError.Size = new System.Drawing.Size(434, 18);
            this.lblIDError.TabIndex = 18;
            this.lblIDError.Text = "The flight ID must be a valid integer greater than 0";
            this.lblIDError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIDError.Visible = false;
            // 
            // lblStartingDestinationError
            // 
            this.lblStartingDestinationError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartingDestinationError.ForeColor = System.Drawing.Color.Red;
            this.lblStartingDestinationError.Location = new System.Drawing.Point(134, 267);
            this.lblStartingDestinationError.Name = "lblStartingDestinationError";
            this.lblStartingDestinationError.Size = new System.Drawing.Size(221, 54);
            this.lblStartingDestinationError.TabIndex = 19;
            this.lblStartingDestinationError.Text = "The starting destination cannot contain numbers or special characters";
            this.lblStartingDestinationError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblStartingDestinationError.Visible = false;
            // 
            // lblLandingDestinationError
            // 
            this.lblLandingDestinationError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLandingDestinationError.ForeColor = System.Drawing.Color.Red;
            this.lblLandingDestinationError.Location = new System.Drawing.Point(417, 267);
            this.lblLandingDestinationError.Name = "lblLandingDestinationError";
            this.lblLandingDestinationError.Size = new System.Drawing.Size(221, 54);
            this.lblLandingDestinationError.TabIndex = 20;
            this.lblLandingDestinationError.Text = "The landing destination cannot contain numbers or special characters";
            this.lblLandingDestinationError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLandingDestinationError.Visible = false;
            // 
            // lblNumberOfSeatsError
            // 
            this.lblNumberOfSeatsError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumberOfSeatsError.ForeColor = System.Drawing.Color.Red;
            this.lblNumberOfSeatsError.Location = new System.Drawing.Point(215, 403);
            this.lblNumberOfSeatsError.Name = "lblNumberOfSeatsError";
            this.lblNumberOfSeatsError.Size = new System.Drawing.Size(336, 41);
            this.lblNumberOfSeatsError.TabIndex = 21;
            this.lblNumberOfSeatsError.Text = "The number of seats on the flight must be a valid integer greater than 0";
            this.lblNumberOfSeatsError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNumberOfSeatsError.Visible = false;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Location = new System.Drawing.Point(327, 470);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(116, 33);
            this.btnAddFlight.TabIndex = 22;
            this.btnAddFlight.Text = "Add Flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            this.btnAddFlight.MouseLeave += new System.EventHandler(this.btnAddFlight_MouseLeave);
            this.btnAddFlight.MouseHover += new System.EventHandler(this.btnAddFlight_MouseHover);
            // 
            // lblEmptyFieldError
            // 
            this.lblEmptyFieldError.AutoSize = true;
            this.lblEmptyFieldError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmptyFieldError.ForeColor = System.Drawing.Color.Red;
            this.lblEmptyFieldError.Location = new System.Drawing.Point(255, 506);
            this.lblEmptyFieldError.Name = "lblEmptyFieldError";
            this.lblEmptyFieldError.Size = new System.Drawing.Size(252, 18);
            this.lblEmptyFieldError.TabIndex = 23;
            this.lblEmptyFieldError.Text = "Not all fields have been filled";
            this.lblEmptyFieldError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEmptyFieldError.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(684, 443);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(88, 33);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenu.Location = new System.Drawing.Point(605, 491);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(167, 33);
            this.btnMenu.TabIndex = 25;
            this.btnMenu.Text = "Return to Menu";
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // lblAddingError
            // 
            this.lblAddingError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddingError.ForeColor = System.Drawing.Color.Red;
            this.lblAddingError.Location = new System.Drawing.Point(72, 61);
            this.lblAddingError.Name = "lblAddingError";
            this.lblAddingError.Size = new System.Drawing.Size(628, 47);
            this.lblAddingError.TabIndex = 26;
            this.lblAddingError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormAddFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblAddingError);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblEmptyFieldError);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.lblNumberOfSeatsError);
            this.Controls.Add(this.lblLandingDestinationError);
            this.Controls.Add(this.lblStartingDestinationError);
            this.Controls.Add(this.lblIDError);
            this.Controls.Add(this.lblTextSix);
            this.Controls.Add(this.lblTextSeven);
            this.Controls.Add(this.lblTextFive);
            this.Controls.Add(this.lblTextFour);
            this.Controls.Add(this.lblTextThree);
            this.Controls.Add(this.lblTextTwo);
            this.Controls.Add(this.txtNumberOfSeats);
            this.Controls.Add(this.txtLandingDestination);
            this.Controls.Add(this.txtStartingDestination);
            this.Controls.Add(this.txtFlightID);
            this.Controls.Add(this.lblTextOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAddFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "George Brown Airline Services";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddFlight_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextOne;
        private System.Windows.Forms.TextBox txtFlightID;
        private System.Windows.Forms.TextBox txtStartingDestination;
        private System.Windows.Forms.TextBox txtLandingDestination;
        private System.Windows.Forms.TextBox txtNumberOfSeats;
        private System.Windows.Forms.Label lblTextTwo;
        private System.Windows.Forms.Label lblTextThree;
        private System.Windows.Forms.Label lblTextFour;
        private System.Windows.Forms.Label lblTextFive;
        private System.Windows.Forms.Label lblTextSeven;
        private System.Windows.Forms.Label lblTextSix;
        private System.Windows.Forms.Label lblIDError;
        private System.Windows.Forms.Label lblStartingDestinationError;
        private System.Windows.Forms.Label lblLandingDestinationError;
        private System.Windows.Forms.Label lblNumberOfSeatsError;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Label lblEmptyFieldError;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Label lblAddingError;
    }
}