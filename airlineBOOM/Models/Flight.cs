﻿using airlineBOOM.Models.FlightSettingVariables;
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
        public Visibility FlightVisibility { get; set; }
        public Meteorology FlightMeteorology { get; set; }
        public Setoff FlightSetoff { get; set; }
        public Pilot Pilot { get; set; }
        public Pilot CoPilot { get; set; }
        public Hostess Auxiliary1 { get; set; }
        public Hostess Auxiliary2 { get; set; }
        public Hostess Auxiliary3 { get; set; }

        // Origin & destiny cities
        public City Origin { get; set; }
        public City Destiny { get; set; }
    }
}
