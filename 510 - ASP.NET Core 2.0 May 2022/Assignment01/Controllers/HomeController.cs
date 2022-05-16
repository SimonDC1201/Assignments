using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Assignment01.Models;
using Microsoft.Extensions.Logging;

namespace Assignment01.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [Route("")]
        [Route("Home")]
        [Route("Home/Index")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("Home/Students")]
        public IActionResult Student()
        {
            StudentViewModel svm = new StudentViewModel();
            List<DTO.Student> students = new List<DTO.Student>()
            {
                new DTO.Student{StudentId = 1, FirstName = "Melanie", LastName = "Morneau", EmailAddress="MelanieFakeMail@provider.com", PhoneNumber="555-5555", Course="Mathematique"},
                new DTO.Student{StudentId = 2, FirstName = "Simon", LastName = "Dionne-Couture", EmailAddress="SimonFakeMail@provider.com", PhoneNumber="555-5553", Course="Francais"},

            };
            svm.Students = students;
            return View(svm);
        }

        [Route("Home/Instructors")]
        public IActionResult Instructors()
        {
            InstructorViewModel ivm = new InstructorViewModel();
            List<DTO.Instructor> instructors = new List<DTO.Instructor>()
            {
                new DTO.Instructor{InstructorId = 101, FirstName = "Judith", LastName = "Forneau", EmailAddress="MelanieFakeMail@provider.com",Course="Mathematique"},
                new DTO.Instructor{InstructorId = 102, FirstName = "Nomis", LastName = "Douture", EmailAddress="SimonFakeMail@provider.com", Course="Francais"},

            };
            ivm.Instructor = instructors;
            return View(ivm);
        }

        [Route("Home/Courses")]
        public IActionResult Courses()
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
        
        //public IActionResult _Layout()
        //{
        //    return View();
        //}
        IActionResult Privacy()
        {
            return View();
        }
    }
}
