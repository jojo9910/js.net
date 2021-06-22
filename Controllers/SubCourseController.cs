using Microsoft.AspNetCore.Mvc;
using React5.Database;
using React5.Models;
using React5.Services;
using System;

namespace React5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubCourseController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "yes";

        }

        /*[HttpPost]
        public IActionResult Create([FromBody] Subcourse newSubcourse)
        {
            SubCourseServices.Add(newSubcourse);
            return CreatedAtAction(nameof(Create), newSubcourse);

        }*/
        [HttpPost]
/*        [Route("/topic")]*/
        public IActionResult Topic([FromBody] Topic newTopic)
        {
            Console.WriteLine("okqay");
            SubCourseServices.AddTopic(newTopic);
            return CreatedAtAction(nameof(Topic), newTopic);
        }
    }
}
