using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp2129Assignment3
{
    class Booking
    {
        private Customer passanger;
        private Flight flight;
        private DateTime date;
        private int bookingId;

        public Booking(Customer passanger, Flight flight, DateTime date, int bookingId)
        {
            this.passanger = passanger;
            this.flight = flight;
            this.date = date;
            this.bookingId = bookingId;
        }

        public string toString()
        {
            return String.Format("=====Booking ID: {0} ======\r\nPassanger: {1} \r\nFlight: {2} \r\nDate: {3} \r\n\r\n", bookingId, passanger.toString(), flight.toString(), date.ToString("dd/MM/yyyy"));
        }
        public int getBookingId() { return bookingId; }
        public Flight getFlight() { return flight; }
        public Customer getPassenger() { return passanger; }
        public DateTime getDate() { return date; }
        public void setBookingId(int bookingId) { this.bookingId = bookingId; }
        public void setDate(DateTime date) { this.date = date; }
        public void setFlight(Flight flight) { this.flight = flight; }
        public void setPassenger(Customer passanger) { this.passanger = passanger; }
    }
}
