namespace comp2129Assignment3
{
    partial class FormFlight
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
            this.txtViewFlights = new System.Windows.Forms.TextBox();
            this.btnAddFlight = new System.Windows.Forms.Button();
            this.btnDeleteFlight = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTextFour = new System.Windows.Forms.Label();
            this.lblColourText = new System.Windows.Forms.Label();
            this.lblTextThree = new System.Windows.Forms.Label();
            this.lblButtonMessage = new System.Windows.Forms.Label();
            this.txtDeleteFlightID = new System.Windows.Forms.TextBox();
            this.lblIDError = new System.Windows.Forms.Label();
            this.lblDeleteMessage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTextOne
            // 
            this.lblTextOne.AutoSize = true;
            this.lblTextOne.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextOne.Location = new System.Drawing.Point(810, 31);
            this.lblTextOne.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextOne.Name = "lblTextOne";
            this.lblTextOne.Size = new System.Drawing.Size(243, 35);
            this.lblTextOne.TabIndex = 1;
            this.lblTextOne.Text = "Current Flights:";
            // 
            // txtViewFlights
            // 
            this.txtViewFlights.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtViewFlights.Location = new System.Drawing.Point(692, 71);
            this.txtViewFlights.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtViewFlights.Multiline = true;
            this.txtViewFlights.Name = "txtViewFlights";
            this.txtViewFlights.ReadOnly = true;
            this.txtViewFlights.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtViewFlights.Size = new System.Drawing.Size(464, 746);
            this.txtViewFlights.TabIndex = 1;
            this.txtViewFlights.TabStop = false;
            this.txtViewFlights.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddFlight
            // 
            this.btnAddFlight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddFlight.Location = new System.Drawing.Point(44, 357);
            this.btnAddFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFlight.Name = "btnAddFlight";
            this.btnAddFlight.Size = new System.Drawing.Size(207, 49);
            this.btnAddFlight.TabIndex = 0;
            this.btnAddFlight.Text = "Add a Flight";
            this.btnAddFlight.UseVisualStyleBackColor = true;
            this.btnAddFlight.Click += new System.EventHandler(this.btnAddFlight_Click);
            this.btnAddFlight.MouseLeave += new System.EventHandler(this.btnAddFlight_MouseLeave);
            this.btnAddFlight.MouseHover += new System.EventHandler(this.btnAddFlight_MouseHover);
            // 
            // btnDeleteFlight
            // 
            this.btnDeleteFlight.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteFlight.Location = new System.Drawing.Point(376, 357);
            this.btnDeleteFlight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeleteFlight.Name = "btnDeleteFlight";
            this.btnDeleteFlight.Size = new System.Drawing.Size(255, 49);
            this.btnDeleteFlight.TabIndex = 1;
            this.btnDeleteFlight.Text = "Delete a Flight";
            this.btnDeleteFlight.UseVisualStyleBackColor = true;
            this.btnDeleteFlight.Click += new System.EventHandler(this.btnDeleteFlight_Click);
            this.btnDeleteFlight.MouseLeave += new System.EventHandler(this.btnDeleteFlight_MouseLeave);
            this.btnDeleteFlight.MouseHover += new System.EventHandler(this.btnDeleteFlight_MouseHover);
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(218, 595);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(255, 49);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Return to Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.btnBack.MouseLeave += new System.EventHandler(this.btnBack_MouseLeave);
            this.btnBack.MouseHover += new System.EventHandler(this.btnBack_MouseHover);
            // 
            // lblTextFour
            // 
            this.lblTextFour.AutoSize = true;
            this.lblTextFour.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextFour.Location = new System.Drawing.Point(36, 109);
            this.lblTextFour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextFour.Name = "lblTextFour";
            this.lblTextFour.Size = new System.Drawing.Size(472, 38);
            this.lblTextFour.TabIndex = 6;
            this.lblTextFour.Text = "You Have Chosen to Manage";
            // 
            // lblColourText
            // 
            this.lblColourText.AutoSize = true;
            this.lblColourText.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColourText.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblColourText.Location = new System.Drawing.Point(510, 109);
            this.lblColourText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblColourText.Name = "lblColourText";
            this.lblColourText.Size = new System.Drawing.Size(123, 38);
            this.lblColourText.TabIndex = 7;
            this.lblColourText.Text = "Flights";
            // 
            // lblTextThree
            // 
            this.lblTextThree.AutoSize = true;
            this.lblTextThree.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextThree.Location = new System.Drawing.Point(111, 158);
            this.lblTextThree.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTextThree.Name = "lblTextThree";
            this.lblTextThree.Size = new System.Drawing.Size(475, 35);
            this.lblTextThree.TabIndex = 8;
            this.lblTextThree.Text = "You have the following options:";
            // 
            // lblButtonMessage
            // 
            this.lblButtonMessage.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblButtonMessage.Location = new System.Drawing.Point(38, 725);
            this.lblButtonMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblButtonMessage.Name = "lblButtonMessage";
            this.lblButtonMessage.Size = new System.Drawing.Size(645, 35);
            this.lblButtonMessage.TabIndex = 10;
            this.lblButtonMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDeleteFlightID
            // 
            this.txtDeleteFlightID.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeleteFlightID.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtDeleteFlightID.Location = new System.Drawing.Point(352, 415);
            this.txtDeleteFlightID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDeleteFlightID.Name = "txtDeleteFlightID";
            this.txtDeleteFlightID.Size = new System.Drawing.Size(300, 42);
            this.txtDeleteFlightID.TabIndex = 11;
            this.txtDeleteFlightID.Text = "Enter Flight ID";
            this.txtDeleteFlightID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDeleteFlightID.Click += new System.EventHandler(this.txtDeleteFlightID_Click);
            this.txtDeleteFlightID.Enter += new System.EventHandler(this.txtDeleteFlightID_Enter);
            this.txtDeleteFlightID.Leave += new System.EventHandler(this.txtDeleteFlightID_Leave);
            // 
            // lblIDError
            // 
            this.lblIDError.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDError.ForeColor = System.Drawing.Color.Red;
            this.lblIDError.Location = new System.Drawing.Point(356, 468);
            this.lblIDError.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDError.Name = "lblIDError";
            this.lblIDError.Size = new System.Drawing.Size(285, 89);
            this.lblIDError.TabIndex = 19;
            this.lblIDError.Text = "The flight ID must be a valid integer greater than 0";
            this.lblIDError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblIDError.Visible = false;
            // 
            // lblDeleteMessage
            // 
            this.lblDeleteMessage.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteMessage.ForeColor = System.Drawing.Color.Red;
            this.lblDeleteMessage.Location = new System.Drawing.Point(39, 212);
            this.lblDeleteMessage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDeleteMessage.Name = "lblDeleteMessage";
            this.lblDeleteMessage.Size = new System.Drawing.Size(610, 89);
            this.lblDeleteMessage.TabIndex = 20;
            this.lblDeleteMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1176, 863);
            this.Controls.Add(this.lblDeleteMessage);
            this.Controls.Add(this.lblIDError);
            this.Controls.Add(this.txtDeleteFlightID);
            this.Controls.Add(this.lblButtonMessage);
            this.Controls.Add(this.lblTextThree);
            this.Controls.Add(this.lblColourText);
            this.Controls.Add(this.lblTextFour);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnDeleteFlight);
            this.Controls.Add(this.btnAddFlight);
            this.Controls.Add(this.txtViewFlights);
            this.Controls.Add(this.lblTextOne);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FormFlight";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "George Brown Airline Services";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormFlight_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextOne;
        private System.Windows.Forms.TextBox txtViewFlights;
        private System.Windows.Forms.Button btnAddFlight;
        private System.Windows.Forms.Button btnDeleteFlight;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTextFour;
        private System.Windows.Forms.Label lblColourText;
        private System.Windows.Forms.Label lblTextThree;
        private System.Windows.Forms.Label lblButtonMessage;
        private System.Windows.Forms.TextBox txtDeleteFlightID;
        private System.Windows.Forms.Label lblIDError;
        private System.Windows.Forms.Label lblDeleteMessage;
    }
}