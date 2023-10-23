using FirstMVCDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMVCDemo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewData["message"] = "This is sample text in viewdata";
            List<string> names = new List<string>()
            {
                "Akshay","Amol","Tushar","Vivek","Kishor"
            };
           
            // Working with ViewBag --> When we add ViewBag we need to create new property.
            ViewBag.Year = 2023;
            ViewBag.Month = "Oct";
            ViewBag.Names = names;
            //TempData.
            TempData["Company"] = "Think Quotient";
            TempData.Keep("Company");

            ViewData["list"] = names; // implicit --> object

           
            List<string> cities = new List<string>()
            {
                "Pune","Mumbai","Parli","Ambajogai","Delhi"
            };
            ViewData["list1"] = cities;
            return View();
        }

        public IActionResult Privacy()
        {
            var name = TempData["Company"];
            // To remove the values from TempData.
            TempData.Clear();
            return View();
        }
        public IActionResult AboutUs()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}