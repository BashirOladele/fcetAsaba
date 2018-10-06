using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FcetAsaba_MVC.Models;

namespace FcetAsaba_MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Entrepreneurship()
        {
            return View();
        }
        
        public IActionResult Portal()
        {
            return View();
        }
       
        public IActionResult Admission()
        {
            return View();
        }
        public IActionResult Conferences()
        {
            return View();
        }
        public IActionResult Seminar()
        {
            return View();
        }
        public IActionResult Workshop()
        {
            return View();
        }
        public IActionResult SIWES()
        {
            return View();
        }
        public IActionResult Matiriculation()
        {
            return View();
        }
        public IActionResult Graduation()
        {
            return View();
        }
        public IActionResult Convocation()
        {
            return View();
        }
        public IActionResult Journals()
        {
            return View();
        }
        public IActionResult Books()
        {
            return View();
        }
        public IActionResult References()
        {
            return View();
        }
        public IActionResult Research()
        {
            return View();
        }
        public IActionResult AcademyDirectorate()
        {
            return View();
        }
        public IActionResult SchlOfEduc()
        {
            return View();
        }
        public IActionResult BusEdu()
        {
            return View();
        }
        public IActionResult TechEdu()
        {
            return View();
        }
        public IActionResult VocEdu()
        {
            return View();
        }
        public IActionResult CompSciEdu()
        {
            return View();
        }
        public IActionResult NCE()
        {
            return View();
        }
        public IActionResult BEd()
        {
            return View();
        }
        public IActionResult Postgraduate()
        {
            return View();
        }
        public IActionResult Masters()
        {
            return View();
        }
        public IActionResult Calender18and19()
        {
            return View();
        }
        public IActionResult ICTUnit()
        {
            return View();
        }
        public IActionResult Librarian()
        {
            return View();
        }
        public IActionResult FCETAsaba()
        {
            return View();
        }
        public IActionResult Provost()
        {
            return View();
        }
        public IActionResult DProvost()
        {
            return View();
        }
        public IActionResult Registrar()
        {
            return View();
        }
        public IActionResult Deans()
        {
            return View();
        }
        public IActionResult Directors()
        {
            return View();
        }
        public IActionResult council()
        {
            return View();
        }
        public IActionResult HoFDept()
        {
            return View();
        }
        
    }
}
