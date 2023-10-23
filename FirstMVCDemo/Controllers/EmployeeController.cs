using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstMVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult EmployeeDetails()
        {
            List<string> city = new List<string>()
            {
                "Pune","Mumbai","Parli","Latur","Ambajogai"
            };
            ViewData["city"] = new SelectList(city);

            List<string> department = new List<string>()
            {
                "Admin","Development","Sales","HR","Testing"
            };
            ViewData["department"] = new SelectList(department);

            return View();
        }

        [HttpPost]

        public IActionResult EmployeeDetails(IFormCollection form, ICollection<string> skills)
        {
            ViewBag.ID = form["ID"];
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["gender"];
            ViewBag.Department = form["department"];
            ViewBag.Salary = form["salary"];
            ViewBag.City = form["city"];
            ViewBag.Skills = skills;
            return View("DisplayEmployee");
        }
    }
}
