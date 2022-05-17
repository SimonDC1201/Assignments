using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Assignment01.Models;

namespace Assignment01.Controllers
{
    public class StudentController : Controller
    {
        [Route("Student/Student")]
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
    }
}
