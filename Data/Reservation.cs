using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{
    internal class Reservation
    {
        public string ReservationCode { get; set; }
        public string FlightCode { get; set; }
        public string Airline { get; set; }
        public string Cost { get; set; }
        public string Name { get; set; }
        public string Citizenship { get; set; }
        public string Status { get; set; }



        public Reservation() { }

        //Add to list constructor
        public Reservation(string reservationCode, string flightCode, string airline, string cost, string name, string citizenship, string status)
        {
            ReservationCode = reservationCode;
            FlightCode = flightCode;
            Airline = airline;
            Cost = cost;
            Name = name;
            Citizenship = citizenship;
            Status = status;
        }
        public override string ToString()
        {
            return $"{ReservationCode}, {FlightCode}, {Airline}, {Cost}, {Name}, {Citizenship}, {Status}";
        }


    }
}
