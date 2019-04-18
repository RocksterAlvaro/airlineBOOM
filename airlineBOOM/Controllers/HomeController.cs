using airlineBOOM.Data;
using airlineBOOM.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace airlineBOOM.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public HomeController(
            AppDbContext db,
            UserManager<AppUser> userManager,
            SignInManager<AppUser> signInManager)
        {
            _db = db;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // Home
        [HttpGet]
        [Route("/")]
        [Route("/home")]
        public ActionResult Index()
        {
            return View("index"); // Redirect to index page
        }

        // Login
        [HttpGet]
        [Route("/home/login", Name = "homeLogin")]
        public async Task<ActionResult> Login()
        {
            // This should be removed!
            if (User.Identity.Name != null)
            {
                AppUser myUser = await _userManager.FindByNameAsync(User.Identity.Name);
                Console.WriteLine("Email from myUser in index:" + myUser.Email);

                ViewBag.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);
                Console.WriteLine("Email from ViewBag in index:" + ViewBag.AppUser.Email);
            }

            return View("login"); // Redirect to the login page
        }

        [HttpPost]
        [Route("/home/login")]
        public async Task<ActionResult> Login(AppUser appUser)
        {
            // Logout any previous session
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);

            // Login user
            var result = await _signInManager.PasswordSignInAsync(appUser.UserName, appUser.Password, false, false);

            if (result.Succeeded) { return RedirectToAction("index", "home"); }
            else { return Content("User login failed", "text/html"); }
        }

        //Logout
        [HttpGet]
        [Route("/home/logout", Name = "homeLogout")]
        public async Task<ActionResult> Logout(AppUser appUser)
        {
            // Logout any previous session
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);

            return View("index");
        }

        // Create user
        [HttpGet]
        [Route("/home/createUser", Name = "homeCreateUser")]
        public ActionResult OnGetCreateUser(AppUser appUser)
        {
            return View("createUser"); // Redirect to the create user page
        }

        [HttpPost]
        [Route("/home/createUser", Name = "homeCreateUser")]
        public async Task<ActionResult> OnPostCreateUser(AppUser appUser)
        {
            // Logout any previous session
            await HttpContext.SignOutAsync(IdentityConstants.ApplicationScheme);

            var result = await _userManager.CreateAsync(appUser, appUser.Password); // Create the user on the database

            var userRole = Request.Form["userRole"]; // Get the selected role by the user
            await _userManager.AddToRoleAsync(appUser, userRole); // Add to the user a role

            if (result.Succeeded) { return RedirectToAction("index", "home"); } // If succeeded return to index
            else { return Content("User creation failed", "text/html"); } // If failed, report it to the user
        }
    }
}