using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Traveless.Data
{
    internal class ReservationManager
    {
        //private const string reservationsFile = @"C:\Users\Anton\source\repos\Traveless\Resources\Files\reservations.csv"; //No need for reservations file, use list

        public static List<Reservation> listOfReservations = new List<Reservation>();

        //public ReservationManager()
        //{
        //    LoadListOfReservations();
        //}

        //public void LoadListOfReservations() //Do this same things with the entered/selected values in Blazor
        //{
        //    string reservationCode = "Test Reservation Code";
        //    string flightCode = "Test Flight Code";
        //    string airline = "Test Airline";
        //    string cost = "Test Cost";
        //    string name = "Test Name";
        //    string citizenship = "Test Citizenship";
        //    string status = "Active";
        //    Reservation reservations = new Reservation(reservationCode, flightCode, airline, cost, name, citizenship, status);
        //    listOfReservations.Add(reservations);
        //}

        public static List<Reservation> GetReservations() //Returns list of reservations
        {
            return listOfReservations;
        }

        //Load list of reservation information here?
        //Writing to reservations file vs loading list of reservations which gets added to when button is pressed


    }
}
