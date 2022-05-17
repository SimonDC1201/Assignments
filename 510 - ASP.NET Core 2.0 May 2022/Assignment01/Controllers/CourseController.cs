using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Assignment01.Models;
using System.Collections.Generic;

namespace Assignment01.Controllers
{
    public class CourseController : Controller
    {
        [Route("Course/Course")]
        public IActionResult Course()
        {
            CourseViewModel cvm = new CourseViewModel();

            List<DTO.Course> courses = new List<DTO.Course>()
            {
                new DTO.Course{CourseId = 0001, CourseName = "Mathematique", CourseNumber = 123, Description="This is Mathematic 0001"},
                new DTO.Course{CourseId = 0002, CourseName = "Francais", CourseNumber= 456, Description="This is French 0002"},

            };
            cvm.Course = courses;
            return View(cvm);
        }
    }
}
