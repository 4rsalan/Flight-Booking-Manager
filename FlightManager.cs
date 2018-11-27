using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp2129Assignment3
{
    class FlightManager
    {
        private int maxFlights;
        private int numFlights;
        private Flight[] flights;

        public FlightManager(int maxFlt)
        {
            maxFlights = maxFlt;
            flights = new Flight[maxFlt];
        }

        public bool addFlight(int flNum, string org, string dest, int mS)
        {
            if (numFlights >= maxFlights || flightExist(flNum))// flight array is full or flight already exists
            {
                return false;
            }
            Flight flt = new Flight(flNum, org, dest, mS);
            flights[numFlights] = flt;
            numFlights++;
            return true;
        }

        private int findFlight(int flNo)
        {
            for (int i = 0; i < numFlights; i++)
            {
                if (flNo == flights[i].getFlightNumber())
                {
                    return i;
                }
            }
            return -1;// -1 is place holder for not found
        }

        public bool flightExist(int flNo)
        {
            if (findFlight(flNo) != -1)
            {
                return true;
            }
            return false;
        }

        public Flight getFlight(int flNo)
        {
            int index = findFlight(flNo);
            if (index != -1)
            {
                return flights[index];
            }
            return null;
        }

        public bool deleteFlight(int flNo)
        {
            int index = findFlight(flNo);
            if (index < 0) return false; //flight not found
            flights[index] = flights[--numFlights];
            return true;
        }

        public string getFlightList()
        {
            string temp = "";
            for (int i = 0; i < numFlights; i++)
            {
                temp += flights[i].toString() + "\n";
            }
            return temp;
        }

    }
}
