using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp2129Assignment3
{
    class Customer
    {
        private int customerId;
        private string firstName;
        private string lastName;
        private string phoneNumber;

        public Customer(int id, string fName, string lName, string ph)
        {
            customerId = id;
            firstName = fName;
            lastName = lName;
            phoneNumber = ph;
        }

        public int getCustomerId() { return customerId; }
        public string getFirstName() { return firstName; }
        public string getLastName() { return lastName; }
        public string getPhoneNumber() { return phoneNumber; }

        public void setCustomerId(int customerId) { this.customerId = customerId; }
        public void setFirstName(string firstName) { this.firstName = firstName; }
        public void setLastName(string lastName) { this.lastName = lastName; }
        public void setPhoneNumber(string phoneNumber) { this.phoneNumber = phoneNumber; }

        public string toString()
        {
            return "Customer ID: " + customerId + " \r\n Name: " + firstName + " " + lastName + "\r\n Phone Number: " + phoneNumber;
        }
    }
}
