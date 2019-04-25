using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using airlineBOOM.Data;
using airlineBOOM.Models;
using airlineBOOM.Models.FlightSettingVariables;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace airlineBOOM.Controllers
{
    public class OfficeController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public OfficeController(
            AppDbContext db,
            UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        // Office - Create Flight
        [HttpGet]
        [Route("/Office/CreateFlight", Name = "officeCreateFlight")]
        public ActionResult CreateFlight()
        {
            ViewBag.cities = _db.Cities.ToArray();

            return View("createFlight");
        }

        [HttpPost]
        [Route("/Office/CreateFlight", Name = "officeCreateFlight")]
        public async Task<ActionResult> CreateFlight(Flight flight)
        {
            // Search in the database for the origin & destiny cities values registered by the user
            City originCity = await _db.Cities.FindAsync(Request.Form["originCity"]);
            City destinyCity = await _db.Cities.FindAsync(Request.Form["destinyCity"]);

            // Set the origin & destiny cities values
            flight.Origin = originCity;
            flight.Destiny = destinyCity;

            // Save changes in local memory
            var result = await _db.Flights.AddAsync(flight);

            // Save the changes in the database
            _db.SaveChanges();
            
            return RedirectToAction("login", "home");
        }

        // Office - Create Flight setting
        [HttpGet]
        [Route("/Office/CreateFlightSetting", Name = "officeCreateFlightSetting")]
        public ActionResult CreateFlightSetting()
        {
            return View("createFlightSetting");
        }

        [HttpPost]
        [Route("/Office/CreateFlightSetting", Name = "officeCreateFlightSetting")]
        public async Task<ActionResult> CreateFlightSetting(FlightSetting flightSetting)
        {
            // Search in the database for the meteorology, visibility and setoff values registered by the user
            Meteorology flightMeteorology = await _db.Meteorologies.FindAsync(double.Parse(Request.Form["flightSettingMeteorology"]));
            Visibility flightVisibility = await _db.Visibilities.FindAsync(double.Parse(Request.Form["flightSettingVisibility"]));
            Setoff flightSetoff = await _db.Setoffs.FindAsync(double.Parse(Request.Form["flightSettingSetoff"]));

            // Set the meteorology, visibily, setoff and setting score values of the flight setting
            flightSetting.FlightSettingMeteorology = flightMeteorology;
            flightSetting.FlightSettingVisibility = flightVisibility;
            flightSetting.FlightSettingSetoff = flightSetoff;
            flightSetting.calculateFlightSettingScore();

            // Save changes in local memory
            var result = await _db.FlightSettings.AddAsync(flightSetting);

            // Save the changes in the database
            _db.SaveChanges();

            return RedirectToAction("index", "home");
        }

        // Office - Create Pilot test
        [HttpGet]
        [Route("/Office/CreatePilotTest", Name = "officeCreatePilotTest")]
        public async Task<ActionResult> CreatePilotTestAsync()
        {
            ViewBag.pilots = await _userManager.GetUsersInRoleAsync("Pilot");
            ViewBag.flightSettings = _db.FlightSettings
                .Include(flightSetting => flightSetting.FlightSettingMeteorology)
                .Include(flightSetting => flightSetting.FlightSettingVisibility)
                .Include(flightSetting => flightSetting.FlightSettingSetoff);

            return View("createPilotTest");
        }

        [HttpPost]
        [Route("/Office/CreatePilotTest", Name = "officeCreatePilotTest")]
        public async Task<ActionResult> CreatePilotTest(PilotTest pilotTest)
        {
            // Assign the year of the test
            pilotTest.TestYear = new DateTime(Int32.Parse(Request.Form["selectedYear"]), 1, 1);

            // Search & assign the selected pilot
            AppUser pilot = await _userManager.FindByNameAsync(Request.Form["selectedPilot"]);
            pilotTest.PilotId = pilot.Id;

            // Search & assign the selected setting
            pilotTest.SimulationSetting = await _db.FlightSettings.FindAsync(Request.Form["selectedSetting"]);

            // Search & assign the selected meteorology, visibility & setoff values
            pilotTest.PilotMeteorologyTest = await _db.Meteorologies.FindAsync(double.Parse(Request.Form["PilotTestMeteorology"]));
            pilotTest.PilotVisibilityTest = await _db.Visibilities.FindAsync(double.Parse(Request.Form["pilotTestVisibility"]));
            pilotTest.PilotSetoffTest = await _db.Setoffs.FindAsync(double.Parse(Request.Form["pilotTestSetoff"]));

            // Calculate total score
            pilotTest.CalculatePilotTestScore();

            // Save changes in local memory
            var result = await _db.PilotTests.AddAsync(pilotTest);

            // Save the changes in the database
            _db.SaveChanges();

            return RedirectToAction("index", "home");
        }
    }
}