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
    public partial class FormMain : Form
    {

        //Method to Move Clouds
        public void MoveClouds()
        {
            timCloudMove.Enabled = true;
        }

        //When the Form Loads
        public FormMain()
        {
            InitializeComponent();
            MoveClouds();
        }

        //Timer to move clouds
        private void timCloudMove_Tick(object sender, EventArgs e)
        {
            for (int a = 1; a <= 5; a++)
            {
                Controls["picCloud" + a].Left -= 1;
                if (Controls["picCloud" + a].Left <= -200)
                {
                    Controls["picCloud" + a].Left = 850;
                }
            }
        }

        //The "Flights" Button
        private void btnFlights_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "View, Add, or Delete flights from the system.";
        }
        //
        private void btnFlights_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }
        //
        private void btnFlights_Click(object sender, EventArgs e)
        {
            FormFlight f = new FormFlight(this);
            f.Show();
            this.Hide();
        }
        //

        //The "Customers" Button
        private void btnCustomers_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "View, Add, or Delete customers from the system.";
        }
        //
        private void btnCustomers_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }
        //
        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FormCustomer f = new FormCustomer(this);
            f.Show();
            this.Hide();
        }
        //

        //The "Bookings" Button
        private void btnBookings_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "View, Add, or Delete bookings from the system.";
        }
        //
        private void btnBookings_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }
        //
        private void btnBookings_Click(object sender, EventArgs e)
        {
            FormBooking f = new FormBooking(this);
            f.Show();
            this.Hide();
        }
        //

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }
        
    }
}
