using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_App
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        public string Name { get; }

        public Hotel( string name)
        {
            _reservationBook = new ReservationBook();
            Name = name;
        }

        public IEnumerable<Reservation> GetReservationsForUsers(string username)
        {
            return _reservationBook.GetReservationsForUser(username);
        }

        public void MakeReservation (Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
