using Microsoft.AspNetCore.Mvc;
using Assignment01.Models;
using System.Collections.Generic;

namespace Assignment01.Controllers
{
    public class InstructorController : Controller
    {
        [Route("Instructor/Instructor")]
        public IActionResult Instructor()
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
    }
}
