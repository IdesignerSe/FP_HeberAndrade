using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InNutrition.Controllers
{
    public class ProgramHabitController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Program(int id)
        {
            return Ok("This IActionResult Program id is " + id);
        }

        public IActionResult Details(int id)
        {
            return Ok("This IActionResult Details id is " + id);
        }
    }
}
