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
    public partial class FormFlight : Form
    {
        FormMain frmMain;
        ErrorChecking errorCheck = new ErrorChecking();

        //Loading Tasks
        public void FormLoadingTasks()
        {
            txtViewFlights.Text = Program.aC.flightList();
            if (txtViewFlights.Text == "")
            {
                txtViewFlights.Text = "It looks like there aren't any flights in the system.\r\nWhy not add one now?";
                btnDeleteFlight.Enabled = false;
                txtDeleteFlightID.Visible = false;
            }
        }

        //Creating the Forms
        public FormFlight()
        {
            InitializeComponent();
            FormLoadingTasks();
        }

        public FormFlight(FormMain frmMain)
        {
            this.frmMain = frmMain;
            InitializeComponent();
            FormLoadingTasks();
        }

        //Events

        //Back Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain.Show();
            this.Dispose();
        }
        //
        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "Return to the Main Menu";
            lblDeleteMessage.Text = "";
        }
        //
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }

        //The Delete Id Text
        private void txtDeleteFlightID_Click(object sender, EventArgs e)
        {
            txtDeleteFlightID.Text = "";
            txtDeleteFlightID.ForeColor = Color.Black;
        }

        //Add A flight Button
        private void btnAddFlight_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "Add a flight to the flight list";
            lblDeleteMessage.Text = "";
        }
        //
        private void btnAddFlight_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }
        //
        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            FormAddFlight frmAddFlight = new FormAddFlight(frmMain);
            frmAddFlight.Show();
            this.Dispose();
        }

        //Delete A Flight Button
        private void btnDeleteFlight_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "Delete the flight with the specified ID from the flight list";
            lblDeleteMessage.Text = "";
        }
        //
        private void btnDeleteFlight_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }
        //
        private void btnDeleteFlight_Click(object sender, EventArgs e)
        {
            if (errorCheck.CheckForNumericsOnly(txtDeleteFlightID.Text) && txtDeleteFlightID.Text != "")
            {
                bool result = Program.aC.deleteFlight(Convert.ToInt32(txtDeleteFlightID.Text));
                if (result)
                {
                    lblDeleteMessage.ForeColor = Color.ForestGreen;
                    lblDeleteMessage.Text = "Flight with the ID " + txtDeleteFlightID.Text + " was successfully deleted. The Flight list has been updated accordingly";
                    txtViewFlights.Text = Program.aC.flightList();
                    txtDeleteFlightID.Text = "";
                }
                else
                {
                    lblDeleteMessage.ForeColor = Color.Red;
                    lblDeleteMessage.Text = "The flight could not be deleted because it does not exist";
                }
            }
        }

        //When Form is Closed
        private void FormFlight_FormClosed(object sender, FormClosedEventArgs e)
        {
            //frmMain.Show();
            Environment.Exit(0);
        }

        //The Text Box to Delete Flight
        private void txtDeleteFlightID_Leave(object sender, EventArgs e)
        {
            if (!errorCheck.CheckForNumericsOnly(txtDeleteFlightID.Text) && txtDeleteFlightID.Text != "")
            {
                lblIDError.Visible = true;
            }
            else
            {
                lblIDError.Visible = false;
            }
        }
        //
        private void txtDeleteFlightID_Enter(object sender, EventArgs e)
        {
            if (txtDeleteFlightID.Text == "Enter Flight ID")
            {
                txtDeleteFlightID.Text = "";
                txtDeleteFlightID.ForeColor = Color.Black;
            }
        }
    }
}
