using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Test.Models;
using Microsoft.EntityFrameworkCore;

namespace Test.Controllers
{
    public class HomeController : Controller
    {
        private MyContext dbContext;
    
// here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("register")]
        public IActionResult Register()
        {
            return View("Register");
        }

        [HttpPost]
        [Route ("processregistration")]
        public IActionResult ProcessRegistration (User newUser) {
            if (ModelState.IsValid) {
                if (dbContext.Users.Any (u => u.Email == newUser.Email)) {
                    ModelState.AddModelError ("Email",
                        "Email already in use. Please log in.");
                    return View ("Register");
                }
                PasswordHasher<User> Hasher = new PasswordHasher<User> ();
                newUser.Password = Hasher.HashPassword (newUser, newUser.Password);
                dbContext.Users.Add (newUser);
                dbContext.SaveChanges ();
                User loggedUser = dbContext.Users.FirstOrDefault ((u => u.Email == newUser.Email));
                HttpContext.Session.SetInt32 ("logged", loggedUser.UserId);
                return RedirectToAction ("Dashboard");
            } else {
                return View ("Register");
            }
        }

        [HttpGet]
        [Route ("dashboard")]
        public IActionResult Dashboard () {
            int flag = CheckLogged();
            if (flag == 0) {
                return View ("Index");
            }
            User loggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("logged"));
            PopulateBag ();
            List<Event> eventsWithGuestsAndUsers = dbContext.Eventss
                .Include (w => w.Guests)
                .ThenInclude (g => g.User)
                .ToList ();
            ViewBag.EventsWithGuestsAndUsers = eventsWithGuestsAndUsers;
            return View ("Dashboard", loggedUser);
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost("processlogin")]
        public IActionResult ProcessLogin (LoginUser userSubmission) {
            if (ModelState.IsValid) {
                var userInDb = dbContext.Users.FirstOrDefault (u => u.Email == userSubmission.Email);
                if (userInDb == null) {
                    ModelState.AddModelError ("Email", "Invalid Email");
                    return View ("Login");
                }

                var hasher = new PasswordHasher<LoginUser> ();
                var result = hasher.VerifyHashedPassword (userSubmission, userInDb.Password, userSubmission.Password);
                if (result == 0) {
                    ModelState.AddModelError ("Password", "Invalid Password");
                    return View ("Login");
                }
                User loggedUser = userInDb;
                HttpContext.Session.SetInt32 ("logged", loggedUser.UserId);
                return RedirectToAction ("Dashboard");
            } else {
                return View ("Login");
            }
        }

        
        [HttpGet ("newevent")]
        public IActionResult NewEvent () 
        {
            int flag = CheckLogged();
            if (flag == 0) {
                return View ("Index");
            }
            return View ("NewEvent");
        }

        [HttpPost]
        [Route ("processevent")]
        public IActionResult ProcessEvent (Event newEvent) 
        {
            if (ModelState.IsValid) {
                if (newEvent.EventDate < DateTime.Now) {
                    TempData["alertMessage"] = "<p style='color:red;'>Date of event must be in the future.</p>";
                    return RedirectToAction ("NewEvent");
                }
                User loggedUser = dbContext.Users.FirstOrDefault (u => u.UserId == HttpContext.Session.GetInt32 ("logged"));
                newEvent.Creator = loggedUser;
                newEvent.UserId = loggedUser.UserId;
                Event dashName = new Event ();
                dashName.EventDate = newEvent.EventDate;
                dashName.EventDuration = newEvent.EventDuration;
                dashName.EventTime = newEvent.EventTime;
                dashName.Title = newEvent.Title;
                dashName.UserId = newEvent.UserId;
                dbContext.Eventss.Add (dashName);
                dbContext.SaveChanges ();
                return RedirectToAction ("ViewEvent", new { eventId = newEvent.EventId });
            }
            return View ("newEvent");
        }

        [HttpGet ("logout")]
        public IActionResult Logout () 
        {
            HttpContext.Session.Clear ();
            return View ("Index");
        }

        [HttpGet ("viewevent/{eventId}")]
        public IActionResult ViewEvent (int eventId) {
            int flag = CheckLogged();
            if (flag == 0) {
                return View ("Index");
            }
            Event retrievedEvent= dbContext.Eventss.FirstOrDefault (w => w.EventId == eventId);
            GetEventGuests(eventId);
            ViewBag.ertEvent = retrievedEvent;
            return View ("ViewEvent");
        }
        
        [HttpGet ("delete/{eventId}")]
        public IActionResult DeleteEvent (int eventId) {
            Event retrievedEvent = dbContext.Eventss.FirstOrDefault (w => w.EventId == eventId);
            dbContext.Eventss.Remove (retrievedEvent);
            dbContext.SaveChanges ();
            PopulateBag ();
            return RedirectToAction ("Dashboard");
        }

        [HttpGet ("RSVP/{eventId}")]
        public IActionResult RSVPToEvent (int eventId) {
            Event retrievedEvent = dbContext.Eventss.FirstOrDefault (w => w.EventId == eventId);
            User loggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("logged"));
            RSVP newRSVP = new RSVP() {
                UserId = loggedUser.UserId,
                EventId = retrievedEvent.EventId,
                User = loggedUser,
                Event = retrievedEvent,
            };
            dbContext.RSVPs.Add(newRSVP);
            dbContext.SaveChanges ();
            PopulateBag ();
            return RedirectToAction ("Dashboard");
        }

        
        [HttpGet ("unRSVP/{eventId}")]
        public IActionResult UnRSVPToEvent (int eventId) {
            Event retrievedEvent = dbContext.Eventss.FirstOrDefault (w => w.EventId == eventId);
            User loggedUser = dbContext.Users.FirstOrDefault(u => u.UserId == HttpContext.Session.GetInt32("logged"));
            List<RSVP> retrievedRSVPs = dbContext.RSVPs
                .Where(r => r.EventId == retrievedEvent.EventId).ToList();
            RSVP retrievedRSVP = retrievedRSVPs.FirstOrDefault(r => r.UserId == loggedUser.UserId);
            dbContext.Remove(retrievedRSVP);
            dbContext.SaveChanges ();
            PopulateBag ();
            return RedirectToAction ("Dashboard");
        }




        public void GetEventGuests (int eventId) {
            List<RSVP> eventGuests = dbContext.RSVPs
                .Where(r => r.EventId == eventId)
                .Include(r => r.User)
                .ToList();
            ViewBag.EventGuests = eventGuests;
        }


        public void PopulateBag () 
        {
            User loggedUser = dbContext.Users.FirstOrDefault (u => u.UserId == HttpContext.Session.GetInt32 ("logged"));
            List<RSVP> usersRSVPs = dbContext.RSVPs.Where (r => r.User.Equals (loggedUser)).ToList ();
            ViewBag.LoggedUserId = HttpContext.Session.GetInt32 ("logged");
            
            ViewBag.LoggedUser = loggedUser;
            ViewBag.UsersRSVPs = usersRSVPs;
        }


        public int CheckLogged ()
        {
            int flag = 1;
            if (HttpContext.Session.GetInt32 ("logged") == null) {
                flag = 0;
                TempData["alertMessage"] = "<p style='color:red;'>Please login or register.</p>";
            }
            return flag;
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
