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
    public partial class FormAddBooking : Form
    {
        FormMain frmMain;
        ErrorChecking errorCheck = new ErrorChecking();

        public FormAddBooking()
        {
            InitializeComponent();
        }

        public FormAddBooking(FormMain f)
        {
            frmMain = f;
            InitializeComponent();
        }

        //Button to change view list
        private void btnViewing_Click(object sender, EventArgs e)
        {
            if (lblListViewing.Text == "Flights")
            {
                lblListViewing.Text = "Customers";
                txtViewList.Text = Program.aC.customerList();
                btnViewing.Text = "View Flights";
            }
            else
            {
                lblListViewing.Text = "Flights";
                txtViewList.Text = Program.aC.flightList();
                btnViewing.Text = "View Customers";
            }
        }

        //Customer Id text box
        private void txtCustomerID_Leave(object sender, EventArgs e)
        {
            if (!errorCheck.CheckForNumericsOnly(txtCustomerID.Text) && txtCustomerID.Text != "")
            {
                lblCustomerIDError.Visible = true;
            }
            else
            {
                lblCustomerIDError.Visible = false;
            }
            lblAddingError.Text = "";
        }

        private void txtCustomerID_Enter(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "Enter Customer ID")
            {
                txtCustomerID.Text = "";
                txtCustomerID.ForeColor = Color.Black;
            }
        }

        //Flight Id text box
        private void txtFlightID_Leave(object sender, EventArgs e)
        {
            if (!errorCheck.CheckForNumericsOnly(txtFlightID.Text) && txtFlightID.Text != "")
            {
                lblFlightIDError.Visible = true;
            }
            else
            {
                lblFlightIDError.Visible = false;
            }
            lblAddingError.Text = "";
        }

        private void txtFlightID_Enter(object sender, EventArgs e)
        {
            if (txtFlightID.Text == "Enter Flight ID")
            {
                txtFlightID.Text = "";
                txtFlightID.ForeColor = Color.Black;
            }
        }

        //The add a booking button
        private void btnAddBooking_MouseHover(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "" || txtFlightID.Text == "")
            {
                lblEmptyFieldError.Visible = true;
            }
            lblAddingError.Text = "";
        }
        //
        private void btnAddBooking_MouseLeave(object sender, EventArgs e)
        {
            lblEmptyFieldError.Visible = false;
        }
        //
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            if (txtCustomerID.Text == "" || txtFlightID.Text == "")
            {
                lblEmptyFieldError.Visible = true;
            }
            else
            {
                if (lblCustomerIDError.Visible == false && lblFlightIDError.Visible == false)
                {
                    int result = Program.aC.addBooking(Convert.ToInt32(txtCustomerID.Text), Convert.ToInt32(txtFlightID.Text));
                    lblAddingError.ForeColor = Color.Red;
                    if (result == 0)
                    {
                        lblAddingError.ForeColor = Color.ForestGreen;
                        lblAddingError.Text = "Booking was successfully added";
                        txtCustomerID.Text = "";
                        txtFlightID.Text = "";
                    }
                    else if (result == 1)
                    {
                        lblAddingError.Text = "Booking could not be added because the customer with the id " + txtCustomerID.Text + " does not exist";
                    }
                    else if (result == 2)
                    {
                        lblAddingError.Text = "Booking could not be added because the flight with the id " + txtFlightID.Text + " does not exist";
                    }
                    else if (result == 3)
                    {
                        lblAddingError.Text = "Booking could not be added because there are too many bookings in the system";
                    }
                    else if (result == 4)
                    {
                        lblAddingError.Text = "Booking could not be added because the flight is full";
                    }
                    else if (result == 5)
                    {
                        lblAddingError.Text = "Booking could not be added because the customer is already on the flight";
                    }
                }
            }
        }

        //Additional Buttons
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FormAddCustomer frmAddCust = new FormAddCustomer(frmMain, this);
            frmAddCust.Show();
            this.Hide();
        }
        //
        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            FormAddFlight frmFlight = new FormAddFlight(frmMain, this);
            frmFlight.Show();
            this.Hide();
        }
        //
        private void btnBack_Click(object sender, EventArgs e)
        {
            FormBooking f = new FormBooking(frmMain);
            f.Show();
            this.Dispose();
        }
        //
        private void btnMenu_Click(object sender, EventArgs e)
        {
            frmMain.Show();
            this.Dispose();
        }

        //When form closes
        private void FormAddBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        //When Form loads
        private void FormAddBooking_Load(object sender, EventArgs e)
        {
            txtViewList.Text = Program.aC.flightList();
        }
    }
}
