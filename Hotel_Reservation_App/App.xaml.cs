using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Hotel_Reservation_App
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

       protected override void OnStartup(StartupEventArgs e)
        {
            Hotel hotel = new Hotel("Wadad Suites");

            hotel.MakeReservation(new Reservation(
                new RoomID(1, 3),
                "Wadad",
                new DateTime(2020, 8, 4),
                new DateTime(2020, 8, 18)
                ));
            base.OnStartup(e);
        }

    }
}
