using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using LoginReg.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LoginReg.Controllers {
    public class HomeController : Controller {

        private MyContext dbContext;
        public HomeController (MyContext context) {
            dbContext = context;
        }

        [HttpGet ("")] // main page
        public IActionResult Index () {
            return View ();
        }

        [HttpPost ("register")] //add user to db
        public IActionResult Register (User user) // need user info from class
        {
            if (ModelState.IsValid) {
                var ExistingUser = dbContext.Users.Any (a => a.Email == user.Email);
                if (ExistingUser) {

                    ModelState.AddModelError ("Email", "*This email already exist");
                    return View ("Index");
                }
                var hasher = new PasswordHasher<User> ();
                user.Password = hasher.HashPassword (user, user.Password);
                dbContext.Add (user);
                dbContext.SaveChanges ();
                HttpContext.Session.SetInt32("UserId", user.UserId);//store user
                return RedirectToAction ("Success");

            } else {
                return View ("Index");
            }
        }

        [HttpGet ("Login")]
        public IActionResult LoginPage () {
            return View ();
        }

        [HttpPost ("Login")]
        public IActionResult Login (Login userl) 
        {
            if (ModelState.IsValid) 
            {
                Console.WriteLine ("--------2--------");
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = dbContext.Users.FirstOrDefault (u => u.Email == userl.Email);
                // If no user exists with provided email
                if (userInDb == null) 
                {
                    Console.WriteLine ("-----------3-----------");
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError ("Email", "you dont exist");
                    return View ("LoginPage");
                }

                // Initialize hasher object
                var hasher = new PasswordHasher<Login> ();

                // varify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword (userl, userInDb.Password, userl.Password);

                // result can be compared to 0 for failure
                if (result == 0) 
                {
                    Console.WriteLine ("-------4-----------");
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("Password", "*Incorrect Password");
                    return View("LoginPage");
                }
                HttpContext.Session.SetInt32("UserID", userInDb.UserId);
                return RedirectToAction("Success");

            }
            return View ("LoginPage");
        }

        [HttpGet ("Success")]
        public IActionResult Success () {
            if(HttpContext.Session.GetInt32("UserID")  == null)
            {
                    return RedirectToAction("LoginPage");
            }
            User userInSession = dbContext.Users.Find(HttpContext.Session.GetInt32("UserID")) ;
            return View("Success");
        }

        [HttpGet("Logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("LoginPage");
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}