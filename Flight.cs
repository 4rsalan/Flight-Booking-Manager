using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp2129Assignment3
{
    class Flight
    {
        private int flightNumber;
        private string origin;
        private string destination;
        private int maxSeats;
        private int numPassengers;
        private Customer[] passengers;

        public Flight(int flNo, string or, string det, int mSeats)
        {
            flightNumber = flNo;
            origin = or;
            destination = det;
            maxSeats = mSeats;
            passengers = new Customer[maxSeats];
            numPassengers = 0;
        }

        public int getFlightNumber() { return flightNumber; }
        public string getOrigin() { return origin; }
        public string getDestination() { return destination; }
        public int getMaxSeats() { return maxSeats; }
        public int getNumPassengers() { return numPassengers; }

        public void setFlightNumber(int flightNumber) { this.flightNumber = flightNumber; }
        public void setOrigin(string origin) { this.origin = origin; }
        public void setDestination(string destination) { this.destination = destination; }

        public void setMaxSeats(int maxSeats)
        {
            Customer[] temp = new Customer[maxSeats];
            for (int i = 0; i < maxSeats || i < numPassengers; i++)
                temp[i] = passengers[i];
            this.maxSeats = maxSeats;
            passengers = temp;
        }


        public bool addPassenger(Customer cust)
        {
            if (numPassengers >= maxSeats || findPassenger(cust.getCustomerId()) >= 0) return false;// flight is full or customer is already on flight
            passengers[numPassengers] = cust;
            numPassengers++;
            return true;
        }

        public int findPassenger(int custId)
        {
            for (int i = 0; i < numPassengers; i++)
            {
                if (custId == passengers[i].getCustomerId())
                    return i;
            }
            return -1;
        }

        public bool removePassanger(int custId)
        {
            int index = findPassenger(custId);
            if (index < 0) return false;
            numPassengers--;
            passengers[index] = passengers[numPassengers];
            return true;
        }

        public string getPassengerList()
        {
            string pList = "Passenger List\n";
            for (int i = 0; i < numPassengers; i++)
            {
                pList += passengers[i].toString() + "\n";
            }
            return pList;
        }

        public string toString()
        {
            return string.Format("Flight {0} from {1} to {2} \r\n Maximum Seats Available: {3} \r\nNumber of Passangers: {4} \r\n\r\n", flightNumber, origin, destination, maxSeats, numPassengers);
        }

    }
}
