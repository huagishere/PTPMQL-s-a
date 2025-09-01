namespace MvcPro.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using MvcPro.Models;
    public class BmiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Welcome()
        {
            ViewData["Message"] = "BT3";
            return View();
        }
        [HttpPost]
        public IActionResult Index(Bmi bmi)
        {
            bmi.kqbmi = bmi.weight / (bmi.height * bmi.height);
            if (bmi.kqbmi < 18)
            {
                bmi.message = "Thiếu cân";
            }
            else if (bmi.kqbmi >= 18 && bmi.kqbmi <= 25)
            {
                bmi.message = "Bình thường";
            }
            else if (bmi.kqbmi >= 25 && bmi.kqbmi <= 30)
            {
                bmi.message = "Thừa cân";
            }
            else
            {
                bmi.message = "Béo phì";
            }
            ViewBag.sobmi = "Số BMI của bạn là:" + " " + bmi.kqbmi + " " + bmi.message;
            return View(bmi);
        }
    }
}