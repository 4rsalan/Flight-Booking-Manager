using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comp2129Assignment3
{
    public partial class FormAddFlight : Form
    {
        FormMain frmMain;
        FormAddBooking frmAddBooking;
        ErrorChecking errorCheck = new ErrorChecking();

        //Form Creating
        public FormAddFlight()
        {
            InitializeComponent();
        }
        //
        public FormAddFlight(FormMain f)
        {
            frmMain = f;
            frmAddBooking = null;
            InitializeComponent();
        }
        //
        public FormAddFlight(FormMain frmMain, FormAddBooking frmAddBooking)
        {
            this.frmMain = frmMain;
            this.frmAddBooking = frmAddBooking;
            InitializeComponent();
        }

        //Add A Flight Button
        private void btnAddFlight_MouseHover(object sender, EventArgs e)
        {
            if (txtFlightID.Text == "" || txtStartingDestination.Text == "" || txtLandingDestination.Text == "" || txtNumberOfSeats.Text == "")
            {
                lblEmptyFieldError.Visible = true;
            }
            lblAddingError.Text = "";
        }
        //
        private void btnAddFlight_MouseLeave(object sender, EventArgs e)
        {
            lblEmptyFieldError.Visible = false;
        }
        //
        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            if (txtFlightID.Text == "" || txtStartingDestination.Text == "" || txtLandingDestination.Text == "" || txtNumberOfSeats.Text == "")
            {
                lblEmptyFieldError.Visible = true;
            }
            else if (lblIDError.Visible == false && lblStartingDestinationError.Visible == false && lblLandingDestinationError.Visible == false && lblNumberOfSeatsError.Visible == false)
            {
                bool result = Program.aC.addFlight(Convert.ToInt32(txtFlightID.Text), txtStartingDestination.Text, txtLandingDestination.Text, Convert.ToInt32(txtNumberOfSeats.Text));
                if (result)
                {
                    lblAddingError.ForeColor = Color.ForestGreen;
                    lblAddingError.Text = "The Flight with the id " + txtFlightID.Text + " was added successfully";
                    txtFlightID.Text = "";
                    txtLandingDestination.Text = "";
                    txtStartingDestination.Text = "";
                    txtNumberOfSeats.Text = "";
                }
                else
                {
                    lblAddingError.ForeColor = Color.Red;
                    lblAddingError.Text = "The Flight could not be added because the flight already exists or the system cannot hold anymore flights";
                }
            }
        }

        //Form Closed
        private void FormAddFlight_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //Flight ID Text
        private void txtFlightID_Leave(object sender, EventArgs e)
        {
            if (!errorCheck.CheckForNumericsOnly(txtFlightID.Text) && txtFlightID.Text != "")
            {
                lblIDError.Visible = true;
            }
            else
            {
                lblIDError.Visible = false;
            }
        }

        //Starting Destination Text
        private void txtStartingDestination_Leave(object sender, EventArgs e)
        {
            if (!errorCheck.CheckForLettersOnly(txtStartingDestination.Text) && txtStartingDestination.Text != "")
            {
                lblStartingDestinationError.Visible = true;
            }
            else
            {
                lblStartingDestinationError.Visible = false;
            }
        }

        //Landing Destination Text
        private void txtLandingDestination_Leave(object sender, EventArgs e)
        {
            if (!errorCheck.CheckForLettersOnly(txtLandingDestination.Text) && txtLandingDestination.Text != "")
            {
                lblLandingDestinationError.Visible = true;
            }
            else
            {
                lblLandingDestinationError.Visible = false;
            }
        }

        //Number of Seats Text
        private void txtNumberOfSeats_Leave(object sender, EventArgs e)
        {
            if (!errorCheck.CheckForNumericsOnly(txtNumberOfSeats.Text) && txtNumberOfSeats.Text != "")
            {
                lblNumberOfSeatsError.Visible = true;
            }
            else
            {
                lblNumberOfSeatsError.Visible = false;
            }
        }

        //Back Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            if (frmAddBooking != null)
            {
                frmAddBooking.Show();
                this.Dispose();
            }
            else
            {
                FormFlight frmFlight = new FormFlight(frmMain);
                frmFlight.Show();
                this.Dispose();
            }
        }

        //Return to Menu Button
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (frmAddBooking != null)
                frmAddBooking.Dispose();
            frmMain.Show();
            this.Dispose();
        }
    }
}
