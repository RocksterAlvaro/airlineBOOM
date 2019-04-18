﻿using airlineBOOM.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using airlineBOOM.Models.FlightSettingVariables;

namespace airlineBOOM.Data
{
    public class AppDbContext : IdentityDbContext<AppUser>
    {
        // DbCOntext Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        // My tables
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Pilot> Pilots { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<SimulatorTest> SimulatorTests { get; set; }
        public DbSet<FlightSetting> FlightSettings { get; set; }
        public DbSet<Visibility> Visibilities { get; set; }
        public DbSet<Meteorology> Meteorologies { get; set; }
        public DbSet<Setoff> Setoffs { get; set; }
    }
}
