using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers {
    public class HomeController : Controller {
        [Route ("")]
        [HttpGet]
        public IActionResult Index () 
        {
            //if not in session(when you first go to the page or restart)
            if(HttpContext.Session.GetInt32("Counter")==null)
            {
                //set the count to start at 0
                HttpContext.Session.SetInt32("Counter", 0);
                //int? IntVariable = HttpContext.Session.GetInt32("Counter");
            }

            
            ViewBag.Count = HttpContext.Session.GetInt32("count");
            ViewBag.CurrentTime = DateTime.Now;
            ViewBag.Message = "The Time is:";
            return View ();
        }

        [HttpPost("")]
        public IActionResult Generate () 
        {
            Random rand = new Random();

            List<string> Passcode = new List<string>()
            {
                "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z","1","2","3","4","5","6","7","8","9","0"
            };
            string newcodes = "";
            for(var i=0;i<14;i++){
                newcodes+=Passcode[rand.Next(0,36)];
            }
            ViewBag.newcodes = newcodes;

            HttpContext.Session.SetInt32("Counter", (int)HttpContext.Session.GetInt32("Counter")+1);//increment up by 1
            //ViewBag Method; put passcode in the bag to carry over to html

            //setting a variable to use in other places (viewbag)
            int? IntVariable = HttpContext.Session.GetInt32("Counter");
            ViewBag.Counter = IntVariable;
            return View("Index");
        }
        [HttpGet]//reset button
        [Route("clear")]
        public IActionResult Clear()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }

    }
}