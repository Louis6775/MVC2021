using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Mvc2021.Controllers
{
    public class CollegeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Maths()
        {
            return View();
        }

        public IActionResult English()
        {
            return View();
        }

        public IActionResult ComputerScience()
        {
            return View();
        }
    }
}