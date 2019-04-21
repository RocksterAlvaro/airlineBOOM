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
    public class PilotController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public PilotController(
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
        [Route("/Pilot/GetFlights", Name = "pilotGetFlights")]
        public ActionResult GetFlights()
        {
            ViewBag.flights = _db.Flights
                .Include(flight => flight.Origin)
                .Include(flight => flight.Destiny);

            return View("getFlights");
        }
    }
}