using Microsoft.AspNetCore.Mvc;
using MvcPro.Models;

namespace MvcPro.Controllers
{
    public class CalController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Cal calc)
        {
            switch (calc.Operation)
            {
                case "tong":
                    calc.Result = calc.soA + calc.soB;
                    break;
                case "hieu":
                    calc.Result = calc.soA - calc.soB;
                    break;
                case "tich":
                    calc.Result = calc.soA * calc.soB;
                    break;
                case "thuong":
                    calc.Result = calc.soA / calc.soB;
                    break;
            }

            ViewBag.Message = "Kết quả:"+" "+calc.Result;
            return View(calc);
        }
    }
}
