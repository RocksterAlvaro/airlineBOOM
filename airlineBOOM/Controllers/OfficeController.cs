using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using airlineBOOM.Data;
using airlineBOOM.Models;
using airlineBOOM.Models.FlightSettingVariables;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace airlineBOOM.Controllers
{
    public class OfficeController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public OfficeController(
            AppDbContext db,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // Office - Create Flight
        [HttpGet]
        [Route("/Office/CreateFlight", Name = "officeCreateFlight")]
        public ActionResult CreateFlight()
        {
            return View("createFlight");
        }

        [HttpPost]
        [Route("/Office/CreateFlight", Name = "officeCreateFlight")]
        public async Task<ActionResult> CreateFlight(Flight flight)
        {
            // Search in the database for the meteorology, visibility and setoff values registered by the user
            Meteorology flightMeteorology = await _db.Meteorologies.FindAsync(double.Parse(Request.Form["flightMeteorology"]));
            Visibility flightVisibility = await _db.Visibilities.FindAsync(double.Parse(Request.Form["flightVisibility"]));
            Setoff flightSetoff = await _db.Setoffs.FindAsync(double.Parse(Request.Form["flightSetoff"]));

            // Set the meteorology, visibily and setoff values
            flight.FlightMeteorology = flightMeteorology;
            flight.FlightVisibility = flightVisibility;
            flight.FlightSetoff = flightSetoff;

            // Save changes in local memory
            var result = await _db.Flights.AddAsync(flight);

            // Save the changes in the database
            _db.SaveChanges();
            
            return RedirectToAction("login", "home");
            /*
            if (result.Succeed) { return RedirectToAction("index", "home"); }
            else { return Content("User login failed", "text/html"); }
            */
        }
    }
}