using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp2129Assignment3
{
    public class AirlineCoordinator
    {
        private FlightManager flightMan;
        private CustomerManager customerMan;
        private BookingManager bookMan;

        public AirlineCoordinator(int custIdSeed, int bookIdSeed, int maxCustomers, int maxFlights, int maxBookings)
        {
            customerMan = new CustomerManager(custIdSeed, maxCustomers);
            flightMan = new FlightManager(maxFlights);
            bookMan = new BookingManager(bookIdSeed, maxBookings);
        }

        public bool addFlight(int flNo, string origin, string destination, int maxSeats)
        { return flightMan.addFlight(flNo, origin, destination, maxSeats); }
        public bool addCustomer(string fName, string lName, string phone)
        { return customerMan.addCustomer(fName, lName, phone); }
        public string flightList()
        { return flightMan.getFlightList(); }
        public string customerList()
        { return customerMan.getCustomerList(); }
        public string bookingList()
        { return bookMan.getBookingList(); }
        public bool deleteCustomer(int cId)
        {
            if (customerMan.getCustomer(cId) != null)
                bookMan.delAllBookingsForCust(cId);
            return customerMan.deleteCustomer(cId);
        }
        public bool deleteFlight(int flightNo)
        {
            if (flightMan.getFlight(flightNo) != null)
                bookMan.delAllBookingsOnFlight(flightNo);
            return flightMan.deleteFlight(flightNo);
        }
        public bool deleteBooking(int bID)
        { return bookMan.deleteBooking(bID); }
        public int addBooking(int cID, int fID)
        {
            Customer passanger = customerMan.getCustomer(cID);
            Flight flight = flightMan.getFlight(fID);
            DateTime date = DateTime.Today;
            if (passanger == null)
                return 1; //customer doesn't exist
            if (flight == null)
                return 2;//flight doesn't exist
            return (bookMan.addBooking(passanger, flight, date)); /* return 0 if add sucessfully
                                                                   * return 3 if max bookings reached
                                                                   * return 4 if flight is full 
                                                                   * return 5 passanger is already on flight
                                                                   */

        }
    }
}
