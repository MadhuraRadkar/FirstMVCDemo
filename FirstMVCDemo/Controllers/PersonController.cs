using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FirstMVCDemo.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult PersonalDetails()
        {
            List<string> city = new List<string>()
            {
                "Pune","Mumbai","Parli","Latur","Ambajogai"
            };
            ViewData["city"] = new SelectList(city);

            return View();
        }
        [HttpPost]

        public IActionResult PersonalDetails(IFormCollection form, ICollection<string> hobbies)
        {
            ViewBag.Name = form["username"];
            ViewBag.Gender = form["gender"];
            ViewBag.City = form["city"];
            ViewBag.Hobbies = hobbies;
            return View("DisplayDetails");
        }

    }
}
