using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using CRUD.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRUD.Controllers {
    public class HomeController : Controller {

        private MyContext dbContext;

        // here we can "inject" our context service into the constructor
        public HomeController (MyContext context) {
            dbContext = context;
        }

        [HttpGet ("")] //Home Page
        public IActionResult Index () {
            IEnumerable<Dish> AllDishes = dbContext.Dishes.OrderByDescending (p => p.CreatedAt);
            ViewBag.data = AllDishes; //index

            return View ();
        }

        [HttpGet ("new")] //form page to add user
        public IActionResult New () 
        {

            return View ();
        }

        [HttpGet ("edit/{{id}}")] // go to dish page
        public IActionResult Edit (int id) {
            Dish dish = dbContext.Dishes.SingleOrDefault (a => a.DishId == id);
            return View ();
        }

        [HttpPost ("AddDish")] //Add dish
        public IActionResult AddDish (Dish newDish) {
            dbContext.Add (newDish);
            dbContext.SaveChanges ();
            return RedirectToAction ("Index");
        }

        [HttpGet ("{id}")] //view one dish
        public IActionResult ShowOne (int id, Dish  food) {
            Dish dish = dbContext.Dishes.FirstOrDefault (a => a.DishId == id);
            //IEnumerable<Dish> AllDishes = dbContext.Dishes.FirstOrDefault (p => p.CreatedAt);
            Console.WriteLine ("//////////////////////////////////////");
            Console.WriteLine (dish);
            Console.WriteLine ("//////////////////////////////////////");
            Console.WriteLine ("//////////////////////////////////////");
            Console.WriteLine (id);
            Console.WriteLine ("//////////////////////////////////////");
            ViewBag.show = dish;
            return View (dish);
        }
        [HttpGet ("edit/{id}")] //view update page
        public IActionResult Edit (int id, Dish  food) {
            Dish dish = dbContext.Dishes.FirstOrDefault (a => a.DishId == id);
            
            ViewBag.show = dish;
            return View ("Edit",dish);
        }

        [HttpPost ("edit/{id}")] // update data
        public IActionResult Update (int id, Dish EditDish) {
            Dish dish = dbContext.Dishes.SingleOrDefault (a => a.DishId == id);
            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine(dish);
            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine(id);
            Console.WriteLine("//////////////////////////////////");
            Console.WriteLine(EditDish.Name);
            Console.WriteLine("//////////////////////////////////");
            dish.Name = EditDish.Name;
            dish.Chef = EditDish.Chef;
            dish.Description = EditDish.Description;
            dish.Tastiness = EditDish.Tastiness;
            dish.Calories = EditDish.Calories;
            dish.UpdatedAt = EditDish.UpdatedAt;
            dbContext.SaveChanges ();
            return RedirectToAction ("Index");
        }

        [HttpGet ("delete/{id}")] // delete
        public IActionResult Delete (int id) {
            Dish RetrievedUser = dbContext.Dishes.SingleOrDefault (user => user.DishId == id);

            // Then pass the object we queried for to .Remove() on Users
            dbContext.Dishes.Remove (RetrievedUser);

            // Finally, .SaveChanges() will remove the corresponding row representing this User from DB 
            dbContext.SaveChanges ();

            return RedirectToAction ("Index");
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}