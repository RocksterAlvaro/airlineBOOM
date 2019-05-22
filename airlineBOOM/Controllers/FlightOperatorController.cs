using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using airlineBOOM.Data;
using airlineBOOM.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace airlineBOOM.Controllers
{
    public class FlightOperatorController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;

        public FlightOperatorController(
            AppDbContext db,
            UserManager<AppUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        // Flight Operator - Assign Flight Setting
        [HttpGet]
        [Route("/FlightOperator/AssignFlightSetting", Name = "flightOperatorAssignFlightSetting")]
        public ActionResult AssignFlightSetting()
        {
            // Search and return all flight settings
            ViewBag.flightSettings = _db.FlightSettings
                .Include(flightSetting => flightSetting.FlightSettingMeteorology)
                .Include(flightSetting => flightSetting.FlightSettingVisibility)
                .Include(flightSetting => flightSetting.FlightSettingSetoff);

            // Search and return all flights
            ViewBag.flights = _db.Flights
                .Include(flight => flight.Origin)
                .Include(flight => flight.Destiny);

            return View("assignFlightSetting");
        }
        
        [HttpPost]
        [Route("/FlightOperator/AssignFlightSetting", Name = "flightOperatorAssignFlightSetting")]
        public async Task<ActionResult> PostAssignFlightSetting()
        {
            var flight = await _db.Flights.FindAsync(Request.Form["selectedFlight"]);
            var flightSetting = await _db.FlightSettings.FindAsync(Request.Form["selectedSetting"]);

            // Keep the flightId & the flightSettingId
            TempData["flightId"] = flight.Id;
            TempData["flightSettingId"] = flightSetting.Id;

            return RedirectToAction("assignFlightCrew", "flightOperator");
        }

        // Office - Create Flight
        [HttpGet]
        [Route("/FlightOperator/AssignFlightCrew", Name = "flightOperatorAssignFlightCrew")]
        public async Task<ActionResult> GetAssignFlightCrew()
        {
            // Get all the FlightSettings
            var FlightSettings = _db.FlightSettings
                .Include(flightSetting => flightSetting.FlightSettingMeteorology)
                .Include(flightSetting => flightSetting.FlightSettingVisibility)
                .Include(flightSetting => flightSetting.FlightSettingSetoff);

            // Get all the Flights
            var Flights = _db.Flights
                .Include(flight => flight.Origin)
                .Include(flight => flight.Destiny);
            
            // Get all pilots
            var pilots = await _userManager.GetUsersInRoleAsync("Pilot");

            // Set the selected FlightSetting
            ViewBag.flightSetting = FlightSettings.SingleOrDefault(flightSetting => flightSetting.Id == TempData["flightSettingId"].ToString());

            // Set the selected Flight
            ViewBag.flight = Flights.SingleOrDefault(flight => flight.Id == TempData["flightId"].ToString());

            // Set all the pilots
            ViewBag.pilots = pilots;

            // Get all PilotTests
            var pilotTests = _db.PilotTests
                .Include(PilotTest => PilotTest.PilotMeteorologyTest)
                .Include(PilotTest => PilotTest.PilotVisibilityTest)
                .Include(PilotTest => PilotTest.PilotSetoffTest)
                .Include(PilotTest => PilotTest.SimulationSetting);

            // Create a temporal value for selected PilotTests
            List<PilotTest> selectedPilotTests = new List<PilotTest>();

            // Set selected PilotTests to temporal variables
            foreach (PilotTest pilotTest in pilotTests)
            {
                if (pilotTest.SimulationSetting.Id == ViewBag.flightSetting.Id)
                {
                    selectedPilotTests.Add(pilotTest);
                }
            }

            // Set the selected PilotTests
            ViewBag.pilotTests = selectedPilotTests;

            // Keep the flightId
            TempData["flightId"] = ViewBag.flight.Id;

            return View("assignFlightCrew");
        }

        // Office - Create Flight
        [HttpPost]
        [Route("/FlightOperator/AssignFlightCrew", Name = "flightOperatorAssignFlightCrew")]
        public async Task<ActionResult> PostAssignFlightCrewAsync()
        {
            // Search the selected pilot & flight
            var pilot = await _userManager.FindByIdAsync(Request.Form["selectedPilot"]);
            var flight = _db.Flights.Find(TempData["flightId"]);
            
            // Assign the pilot to the flight
            flight.Pilot = pilot;

            // Save changes
            await _db.SaveChangesAsync();

            return RedirectToAction("login", "home");
        }
    }
}