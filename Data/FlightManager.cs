using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Traveless.Data
{
    internal class FlightManager
    {
        private const string FlightsFile = @"C:\Users\Anton\source\repos\Traveless\Resources\Files\flights.csv";
        public static List<Flight> flights = new List<Flight>();

        public FlightManager()
        {
            populateFlights();
        }

        private void populateFlights()
        {
            Flight flight;

            foreach(string csvLine in System.IO.File.ReadLines(FlightsFile))
            {
                string[] cells = csvLine.Split(",");

                string flightCode = cells[0];
                string airline = cells[1];
                string from = cells[2];
                string to = cells[3];
                string day = cells[4];
                string time = cells[5];
                int cost = int.Parse(cells[6]);

                flight = new Flight(flightCode, airline, from, to, day, time, cost);
                flights.Add(flight);
            }
        }

        public static List<Flight> GetFlights()
        {
            return flights;
        }
    }
}
