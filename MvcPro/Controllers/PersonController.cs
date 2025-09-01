namespace MvcPro.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MvcPro.Models;

    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Person ps)
        {
            ViewBag.Message = "Xin chào " + ps.FullName + " - " + ps.BirthDay.ToString("dd/MM/yyyy");
            return View();
        }

        public IActionResult Welcome()
        {
            ViewData["Message"] = "Your welcome message";
            return View();
        }
    }
}
