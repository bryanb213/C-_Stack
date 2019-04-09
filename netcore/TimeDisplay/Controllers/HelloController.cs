    using Microsoft.AspNetCore.Mvc;
    namespace YourNamespace.Controllers     //be sure to use your own project's namespace!
    {
        public class HelloController : Controller   //remember inheritance??
        {
            //for each route this controller is to handle:
            [HttpGet("")]     //associated route string (exclude the leading /)
            public IActionResult Index()
            {
                return View();
            }
        }
    }
