using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp2129Assignment3
{
    class CustomerManager
    {
        private Customer[] customers;
        private static int currentCustNo;
        private int maxCustomers;
        private int numCustomers;

        public CustomerManager(int seed, int maxCust)
        {
            currentCustNo = seed; // seed initialises Customer numbering scheme
            maxCustomers = maxCust;
            numCustomers = 0;
            customers = new Customer[maxCust];
        }

        public bool addCustomer(string FN, string LN, string PH)
        {
            if (numCustomers >= maxCustomers)
            {
                return false;
            }
            Customer cus = new Customer(currentCustNo++, FN, LN, PH);
            customers[numCustomers] = cus;
            numCustomers++; // increase numCustomers
            return true;
        }

        //Searches array for Customer Id and returns index, returns -1 if not found
        private int findCustomer(int id)
        {
            for (int i = 0; i < numCustomers; i++)
            {
                if (id == customers[i].getCustomerId())
                {
                    return i;
                }
            }
            return -1;
        }

        public bool customerExist(int id)
        {
            if (findCustomer(id) != -1)
            {
                return true;
            }
            return false;
        }

        public Customer getCustomer(int id)
        {
            int index = findCustomer(id);
            if (index != -1)
            {
                return customers[index];
            }
            return null;
        }


        public bool deleteCustomer(int id)
        {
            int index = findCustomer(id);
            if (index < 0) return false; //customer is not in list 
            numCustomers--;
            customers[index] = customers[numCustomers];
            return true;
        }


        public string getCustomerList()
        {
            string list = "";
            for (int i = 0; i < numCustomers; i++)
            {
                list += customers[i].toString() + "\r\n \r\n";
            }
            return list;
        }

    }
}
