using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp2129Assignment3
{
    class BookingManager
    {
        private Booking[] bookings;
        private static int currentBookNum;
        private int maxBookings;
        private int numBookings;

        public BookingManager(int seed, int maxBookings)
        {
            currentBookNum = seed;
            this.maxBookings = maxBookings;
            bookings = new Booking[maxBookings];
            numBookings = 0;
        }
        public int addBooking(Customer passanger, Flight flight, DateTime date)
        {
            if (numBookings >= maxBookings) return 3; //to many bookings
            if (!flight.addPassenger(passanger))
            {
                if (flight.getNumPassengers() >= flight.getMaxSeats())
                    return 4; //flight is full
                return 5;    //Passanger is already on flight
            }

            bookings[numBookings++] = new Booking(passanger, flight, date, currentBookNum);
            currentBookNum++;
            return 0;
        }
        private int findBooking(int findID)
        {
            for (int i = 0; i < numBookings; i++)
                if (bookings[i].getBookingId() == findID)
                    return i;
            return -1;
        }

        public bool bookingExist(int bookingId)
        { return findBooking(bookingId) > 0; }

        public Booking getBooking(int bookingId)
        {
            int index = findBooking(bookingId);
            if (index < 0) return null;
            return bookings[index];
        }

        public bool deleteBooking(int bookingId)
        {
            int index = findBooking(bookingId);
            if (index < 0) return false; //booking not found
            bookings[index].getFlight().removePassanger(bookings[index].getPassenger().getCustomerId());//remove passanger from flight
            bookings[index] = bookings[--numBookings];
            return true;
        }

        public void delAllBookingsOnFlight(int flNo) // deletes all bookings that have flight number matching flNo
        {
            for (int i = 0; i < numBookings; i++)
            {
                if (bookings[i].getFlight().getFlightNumber() == flNo)
                {
                    deleteBooking(bookings[i].getBookingId());
                    i--;//check current index again as it has changed to last index
                }
            }
        }

        public void delAllBookingsForCust(int cId)// deletes all bookings that have customer number matching CId
        {
            for (int i = 0; i < numBookings; i++)
                if (bookings[i].getPassenger().getCustomerId() == cId)
                {
                    deleteBooking(bookings[i].getBookingId());
                    i--;//check current index again as it has changed to last index
                }
        }

        public string getBookingList()
        {
            string result = "";
            for (int i = 0; i < numBookings; i++)
                result += bookings[i].toString();
            return result;
        }
    }
}
