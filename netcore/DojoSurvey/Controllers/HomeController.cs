using System.Collections.Generic;
using System;
using DojoSurvey.Models;
using Microsoft.AspNetCore.Mvc;
namespace DojoSurvey.Controllers 
{
    public class HomeController : Controller 
    {

        [HttpPost ("method")]
        public IActionResult Create (HogwartsStudent student) {

            if (ModelState.IsValid) {
                return View("Info", student);
            } else 
            {
                return View("Index");
            }
        }

    
        [HttpGet ("")]
        public IActionResult Index () {
            return View ();
        }

    //     [HttpGet ("Info")]
    //     public IActionResult Info (HogwartsStudent student) {
    //         ViewBag.name = student.Name;
    //         ViewBag.comment = student.Comment;
    //         ViewBag.location = student.Location;
    //         ViewBag.language = student.Language;
    //         return View ("info");
    //     }
    }
}