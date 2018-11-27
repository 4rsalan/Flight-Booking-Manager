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
    public partial class FormBooking : Form
    {
        FormMain frmMain;
        ErrorChecking errorCheck = new ErrorChecking();

        public void FormLoadingTasks()
        {
            txtViewBookings.Text = Program.aC.bookingList();
            if (txtViewBookings.Text == "")
            {
                txtViewBookings.Text = "It looks like there aren't any bookings in the system.\r\nWhy not add one now?";
                btnDeleteBooking.Enabled = false;
                txtDeleteBookingID.Visible = false;
            }
        }

        //Form Creation
        public FormBooking()
        {
            InitializeComponent();
            FormLoadingTasks();
        }

        public FormBooking(FormMain f)
        {
            frmMain = f;
            InitializeComponent();
            FormLoadingTasks();
        }

        //Add a booking Button
        private void btnAddBooking_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "Add a booking to the booking list";
            lblDeleteMessage.Text = "";
        }
        //
        private void btnAddBooking_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }
        //
        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            FormAddBooking frmAddBooking = new FormAddBooking(frmMain);
            frmAddBooking.Show();
            this.Dispose();
        }

        //Delete a booking button
        private void btnDeleteBooking_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "Delete a booking from the booking list";
            lblDeleteMessage.Text = "";
        }
        //
        private void btnDeleteBooking_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }
        //
        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            if (errorCheck.CheckForNumericsOnly(txtDeleteBookingID.Text) && txtDeleteBookingID.Text != "")
            {
                lblDeleteMessage.ForeColor = Color.ForestGreen;
                lblDeleteMessage.Text = "Booking with the id " + txtDeleteBookingID.Text + " has been successfully deleted. The booking list has been updated accordingly";
                txtViewBookings.Text = Program.aC.bookingList();
                txtDeleteBookingID.Text = "";
            }
            else
            {
                lblDeleteMessage.ForeColor = Color.Red;
                lblDeleteMessage.Text = "Booking with the id " + txtDeleteBookingID.Text + " could not be deleted because it does not exist";
            }
        }

        //Back Button
        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "Return to menu";
            lblDeleteMessage.Text = "";
        }
        //
        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }
        //
        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain.Show();
            this.Dispose();
        }

        private void FormBooking_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtViewBookings_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
