using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InNutrition.Controllers
{
    public class ProgramHabitController : Controller
    {
        [Route("ProgramHabit/Index/{id?}")]
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Program(int id)
        {
            return Ok("This IActionResult Program id is " + id);
        }

        // OTHERS EXEMPLES From a query
        //public IActionResult GetDurationData([FromQuery] string values)
        //{
        //    return Ok("The value : " + value + " is from Query string);
        //}

        //WITH POSTMAN
        // using POSTMAN this mostly use with APIs
        // [HttpPost]
        //public IActionResult Post([FromHeader] string parentrequestId)
        //{
        //    return Ok($"Got a header with parentRequestId: " {parentRequestId}!" );
        //}

        //Another exemple Request Body
        // using POSTMAN this mostly use with APIs
        // [HttpPost]
        //public IActionResult AddDetails([FromBody] ProgramHabit program)
        //{
        //   return Ok(program);
        //}

        //Another exemple PASS PARAMEMETERS in a form
        // using POSTMAN this mostly use with APIs
        // 
        // [HttpPost]
        //public IActionResult SaveFile([FromForm] string filename, [FromForm] IFormFile file)
        //{
        //    return Ok("Success);
        //}  


        public IActionResult Details(int id)
        {
            return Ok("This IActionResult Details id is " + id);
        }
    }
}
