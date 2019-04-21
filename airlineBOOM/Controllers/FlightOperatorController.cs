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

        // Office - Assign Flight Setting
        [HttpGet]
        [Route("/FlightOperator/AssignFlightSetting", Name = "flightOperatorAssignFlightSetting")]
        public ActionResult AssignFlightSetting()
        {
            // Search and return all flight settings
            ViewBag.flightSettings = _db.FlightSettings
                .Include(flightSetting => flightSetting.FlightSettingMeteorology)
                .Include(flightSetting => flightSetting.FlightSettingVisibility)
                .Include(flightSetting => flightSetting.FlightSettingSetoff); ;

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

            TempData["flightId"] = flight.Id;
            TempData["flightSettingId"] = flightSetting.Id;

            return RedirectToAction("assignFlightCrew", "flightOperator");
        }

        // Office - Create Flight
        [HttpGet]
        [Route("/FlightOperator/AssignFlightCrew", Name = "flightOperatorAssignFlightCrew")]
        public ActionResult AssignFlightCrew()
        {
            Console.WriteLine("Type: " + TempData["flight"]);
            ViewBag.flight = TempData["flight"];

            return View("assignFlightCrew");
        }
    }
}