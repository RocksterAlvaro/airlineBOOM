using airlineBOOM.Models.FlightSettingVariables;
using System;
using System.ComponentModel.DataAnnotations;

namespace airlineBOOM.Models
{
    // Custom table
    public class Flight
    {
        // Unique ID
        public string Id { get; set; }

        // Parameters
        public Boolean Flown { get; set; }
        public double Hours { get; set; }
        public DateTime Date { get; set; }
        public string AirplaneState { get; set; }
        public int TicketsSold { get; set; }
        public AppUser Pilot { get; set; }
        public AppUser CoPilot { get; set; }
        public AppUser Auxiliary1 { get; set; }
        public AppUser Auxiliary2 { get; set; }
        public AppUser Auxiliary3 { get; set; }

        // Origin & destiny cities
        public City Origin { get; set; }
        public City Destiny { get; set; }
    }
}
