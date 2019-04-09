using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ChefnDish.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ChefnDish.Controllers {
    public class HomeController : Controller {
        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController (MyContext context) {
            dbContext = context;
        }

        [HttpGet("")]
        public IActionResult Chef () {
            List<Chef> AllChefs = dbContext.Chefs.Include(f => f.CreatedDishes).ToList();

            return View (AllChefs);
        }

        [HttpGet("new")]
        public IActionResult AddChef()
        {
            return View();
        }

        [HttpPost("chef/new")]
        public IActionResult AddChefs(Chef chef) //add chef
        {
            dbContext.Chefs.Add(chef);
            DateTime today = DateTime.Today;
            int age = today.Year - chef.Birthday.Year;
            chef.Age = age;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet("dish")]
        public IActionResult Dish () 
        {
            IEnumerable<Dish> AllDishes = dbContext.Dishes.OrderByDescending(p => p.Creator.FirstName);
            ViewBag.Dishes = AllDishes;
            IEnumerable<Chef> AllChefs = dbContext.Chefs.OrderByDescending(p => p.ChefId);
            ViewBag.Chefs = AllChefs;
            return View ();
        }

        [HttpGet("dish/new")]//show form to add dish
        public IActionResult NewDish()
        {
            IEnumerable<Chef> AllChefs = dbContext.Chefs.OrderByDescending(c => c.FirstName);
            ViewBag.Chefs = AllChefs;
            return View("AddDish");
        }

        [HttpPost("dishes/new")]
        public IActionResult AddDishes(Dish dish)
        {
            dbContext.Add(dish);
            
            dbContext.SaveChanges();
            return RedirectToAction("Dish");
        }

        

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}