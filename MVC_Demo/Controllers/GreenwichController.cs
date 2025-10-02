using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;

namespace MVC_Demo.Controllers
{
    public class GreenwichController : Controller
    {
        public IActionResult Index()
        {
            CampusInfo model = new CampusInfo
            {
                Campus = "Greenwich Vietnam",
                Department = "Computing Department",
                Course = "Advanced Microservices",
                CourseCode = "AMD201"
            };
            return View(model);
        }

        public IActionResult Hanoi()
        {
            //int year = DateTime.Now.Year;

            ////ViewBag.Year = year;
            //ViewData["Year"] = year;
            //ViewBag.Campus = "Hanoi Campus";

            CampusInfo model = new CampusInfo
            {
                Year = DateTime.Now.Year,
                Campus = "Hanoi Campus",
                Department = "Computing Department"
            };

            return View(model);
        }

        public IActionResult HCMC()
        {
            CampusInfo mdl = new CampusInfo
            {
                Year = DateTime.Now.Year,
                Campus = "Ho Chi Minh Campus",
                Department = "Business Department",
                Course = "Digital Marketing",
                CourseCode = "DM301"
            };

            return View(mdl);
        }
    }
}
