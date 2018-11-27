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
    public partial class FormCustomer : Form
    {
        FormMain frmMain;
        ErrorChecking errorCheck = new ErrorChecking();
        
        public void FormLoadingTasks()
        {
            txtViewCustomers.Text = Program.aC.customerList();
            if (txtViewCustomers.Text == "")
            {
                txtViewCustomers.Text = "It looks like there aren't any customers in the system.\r\nWhy not add one now?";
                btnDeleteCustomer.Enabled = false;
                txtDeleteCustomerID.Visible = false;
            }
        }

        public FormCustomer()
        {
            InitializeComponent();
            FormLoadingTasks();
        }

        public FormCustomer(FormMain f)
        {
            frmMain = f;
            InitializeComponent();
            FormLoadingTasks();
        }

        private void btnBack_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "Return to the main menu";
            lblDeleteMessage.Text = "";
        }

        private void btnBack_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            frmMain.Show();
            this.Hide();
        }

        private void btnAddCustomer_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "Add a customer to the customer list";
            lblDeleteMessage.Text = "";
        }

        private void btnAddCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            FormAddCustomer frmAddCust = new FormAddCustomer(frmMain);
            frmAddCust.Show();
            this.Hide();
        }

        private void btnDeleteCustomer_MouseHover(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "Delete a customer from the customer list";
            lblDeleteMessage.Text = "";
        }

        private void btnDeleteCustomer_MouseLeave(object sender, EventArgs e)
        {
            lblButtonMessage.Text = "";
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            if (errorCheck.CheckForNumericsOnly(txtDeleteCustomerID.Text) && txtDeleteCustomerID.Text != "")
            {
                bool result = Program.aC.deleteCustomer(Convert.ToInt32(txtDeleteCustomerID.Text));
                if (result)
                {
                    lblButtonMessage.ForeColor = Color.Green;
                    lblDeleteMessage.Text = "Customer with the Id " + txtDeleteCustomerID.Text + " has been deleted. The Customer List has been updated accordingly";
                    txtViewCustomers.Text = Program.aC.customerList();
                    txtDeleteCustomerID.Text = "";
                }
                else
                {
                    lblButtonMessage.ForeColor = Color.Red;
                    lblDeleteMessage.Text = "Customer could not be deleted because that customer does not exist";
                }
            }
        }

        private void FormCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void txtDeleteCustomerID_Leave(object sender, EventArgs e)
        {
            if (!errorCheck.CheckForNumericsOnly(txtDeleteCustomerID.Text))
            {
                lblIDError.Visible = true;
            }
            else
            {
                lblIDError.Visible = false;
            }
        }

        private void txtDeleteCustomerID_Enter(object sender, EventArgs e)
        {
            if (txtDeleteCustomerID.Text == "Enter Customer ID")
            {
                txtDeleteCustomerID.Text = "";
                txtDeleteCustomerID.ForeColor = Color.Black;
            }
        }

        private void txtDeleteCustomerID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
