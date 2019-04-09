using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuotingDojo.Models;
using DbConnection;

namespace QuotingDojo.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.quotes =  DbConnector.Query("SELECT * FROM quotes");
            //List<Dictionary<string, object>> AllUsers = DbConnector.Query("SELECT * FROM users");
            // To provide this data, we could use ViewBag or a View Model.  ViewBag shown here:
            
            return View();
        }
        [HttpPost("create")]
        public IActionResult Create(Quote dbData)// obj to send data
        {
            if(ModelState.IsValid)
            {
                DbConnector.Query($"INSERT INTO quotes (name, content) VALUES ('{dbData.Name}','{dbData.Content}');");
                return RedirectToAction("Index");
            }else
            {
                ViewBag.quotes =  DbConnector.Query("SELECT * FROM quotes");
            
                return View("Index");
            }
        
        }

    }
}
