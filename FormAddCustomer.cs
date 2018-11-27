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
    public partial class FormAddCustomer : Form
    {
        FormMain frmMain;
        FormAddBooking frmAddBooking;
        ErrorChecking errorCheck = new ErrorChecking();

        //Form creation
        public FormAddCustomer()
        {
            InitializeComponent();
        }
        //
        public FormAddCustomer(FormMain f)
        {
            frmMain = f;
            frmAddBooking = null;
            InitializeComponent();
        }
        //
        public FormAddCustomer(FormMain frmMain, FormAddBooking frmAddBooking)
        {
            this.frmMain = frmMain;
            this.frmAddBooking = frmAddBooking;
            InitializeComponent();
        }
        //The text boxes
        private void txtFirstName_Leave(object sender, EventArgs e)
        {
            if (!errorCheck.CheckForLettersOnly(txtFirstName.Text) && txtFirstName.Text != "")
            {
                lblFirstNameError.Visible = true;
            }
            else
            {
                lblFirstNameError.Visible = false;
            }
        }
        //
        private void txtLastName_Leave(object sender, EventArgs e)
        {
            if (!errorCheck.CheckForLettersOnly(txtLastName.Text) && txtLastName.Text != "")
            {
                lblLastNameError.Visible = true;
            }
            else
            {
                lblLastNameError.Visible = false;
            }
        }
        //
        private void txtPhoneNumber_Leave(object sender, EventArgs e)
        {
            if (!errorCheck.CheckPhoneNumber(txtPhoneNumber.Text) && txtPhoneNumber.Text != "")
            {
                lblPhoneNUmberError.Visible = true;
            }
            else
            {
                lblPhoneNUmberError.Visible = false;
            }
        }

        //Add a customer Button
        private void btnAddCustomer_MouseHover(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtPhoneNumber.Text == "")
            {
                lblEmptyFieldError.Visible = true;
            }
            lblAddingError.Text = "";
        }
        //
        private void btnAddCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblEmptyFieldError.Visible = false;
        }
        //
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text == "" || txtLastName.Text == "" || txtPhoneNumber.Text == "")
            {
                lblEmptyFieldError.Visible = true;
            }
            else if (lblFirstNameError.Visible == false && lblLastNameError.Visible == false && lblPhoneNUmberError.Visible == false)
            {
                bool result = Program.aC.addCustomer(txtFirstName.Text, txtLastName.Text, txtPhoneNumber.Text);
                if (result)
                {
                    lblAddingError.ForeColor = Color.ForestGreen;
                    lblAddingError.Text = "Customer " + txtFirstName.Text + " " + txtLastName.Text + " was successfully added";
                    txtFirstName.Text = "";
                    txtLastName.Text = "";
                    txtPhoneNumber.Text = "";
                }
                else
                {
                    lblAddingError.ForeColor = Color.Red;
                    lblAddingError.Text = "Customer could not be added because they system is holding the maximum amount of customers";
                }
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
                FormCustomer frmCustomer = new FormCustomer(frmMain);
                frmCustomer.Show();
                this.Dispose();
            }
        }

        //Menu Button
        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (frmAddBooking != null)
                frmAddBooking.Dispose();
            frmMain.Show();
            this.Dispose();
        }
    }
}
