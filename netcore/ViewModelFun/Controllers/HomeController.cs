using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModelFun.Models;

namespace ViewModelFun.Controllers {
    public class HomeController : Controller {
    public List<User> Human () 
    {
        return new List<User> ()
        {
        new User() {FirstName = "Moose", LastName = "Phillips"},
        new User() { FirstName = "Ricky", LastName = "Thames" },
        new User() { FirstName = "Sally", LastName = "McSally" },
        };

    }
        [HttpGet ("")]
        public IActionResult Index () {
            string words = "Hello I am words.";

            return View ("Index", words);
        }

        [HttpGet ("numbers")]
        public IActionResult Numbers () {
            int[] num = { 1, 2, 3, 4, 5 };
            return View (num);
        }

        [HttpGet ("users")]
        public IActionResult Users () {
             var users = Human();
            return View (users);
        }

        [HttpGet ("user")]
        public IActionResult OneUser () {
            // var user = Human()[0];
            // return View (user);
            var rand = new Random();
            var users = Human();

            // grab random user (could just create one, grab first, etc...)
            var user = users[rand.Next(users.Count)];
            return View(user);

        }

    }
}