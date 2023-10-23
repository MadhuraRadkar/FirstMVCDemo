using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstMVCDemo.Controllers
{
    public class StudentController : Controller
    {
        
        
            public IActionResult StudentDetails()
            {
                List<string> city = new List<string>()
            {
                "Pune","Mumbai","Parli","Latur","Ambajogai"
            };
                ViewData["city"] = new SelectList(city);

                return View();
            }
            [HttpPost]

            public IActionResult StudentDetails(IFormCollection form, ICollection<string> subjects)
            {
                ViewBag.RollNo = form["RollNo"];
                ViewBag.Name = form["username"];
                ViewBag.Gender = form["gender"];
                ViewBag.City = form["city"];
                ViewBag.Subjects = subjects;
                return View("DisplayStudents");
            }
        
    }
}
