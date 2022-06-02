using Assignment02.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Assignment02.Controllers
{
    public class InstructorController : Controller
    {
        // GET: InstructorController
        public ActionResult Index()
        {
            using (var db = new SchoolDbContext())
            {
                TempData["instructors"] = db.Instructors.ToList();
            }
            return View();
        }
        
        // GET: InstructorController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: InstructorController/Create
        [HttpPost]
        public ActionResult Create(InstructorModel instructors)
        {
            using (var db = new SchoolDbContext())
            {
                db.Instructors.Add(instructors);
                db.SaveChanges();
                TempData["instructors"] = db.Instructors.ToList();
            }
            return View("Index");
        }

        public ActionResult Edit(InstructorModel instructor)
        {
            using (var db = new SchoolDbContext())
            {
                TempData["instructorbyid"] = db.Instructors.Where(i => i.InstructorId == instructor.InstructorId).FirstOrDefault();
            }
                return View();
        }

        // GET: InstructorController/Edit/5
        [HttpPost]
        public ActionResult Update(InstructorModel instructor)
        {
            using(var db = new SchoolDbContext())
            {
                var instructorTemp = db.Instructors.Where(i => i.InstructorId == instructor.InstructorId).FirstOrDefault();
                instructorTemp.FirstName = instructor.FirstName;
                instructorTemp.LastName = instructor.LastName;
                instructorTemp.Email = instructor.Email;
                instructorTemp.CourseId = instructor.CourseId;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult Delete(InstructorModel instructor)
        {
            using (var db = new SchoolDbContext())
            {
                TempData["instructorbyid"] = db.Instructors.Where(i => i.InstructorId == instructor.InstructorId).FirstOrDefault();
            }
            return View();
        }

        [HttpPost]
        public ActionResult DeleteFinal(InstructorModel instructorDeleteFinal)
        {
            using (var db = new SchoolDbContext())
            {
                db.Attach(instructorDeleteFinal);
                db.Instructors.Remove(instructorDeleteFinal);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
