using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
namespace Portfolio.Controllers //be sure to use your own project's namespace!
{
    public class HelloController : Controller //remember inheritance??
    {
        //for each route this controller is to handle:
        [HttpGet("")]//associated route string (exclude the leading /)
        public IActionResult Index () 
        {
            ViewBag.Example = "Hello World";
            return View();
        }
        [HttpGet("project")]
        public IActionResult project()
        {
            return View();
        }

        [HttpGet("contact")]
        public IActionResult contact()
        {
            return View();
        }

    }
}