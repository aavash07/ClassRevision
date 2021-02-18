using Class_revision.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class_revision.Controllers
{
    public class CollegeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(CollegeModel college)
        {
            //data save logic

            return RedirectToAction(nameof(Create));
        }
    }
}
