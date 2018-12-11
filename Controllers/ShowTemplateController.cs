using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace BikeShop.Controllers
{
    public class ShowTemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Bicycles()
        {
            return View();
        }
        public IActionResult Parts()
        {
            return View();
        }
        public IActionResult Accessories()
        {
            return View();
        }
        public IActionResult Extras()
        {
            return View();
        }
        public IActionResult Cart()
        {
            return View();
        }
    }
}