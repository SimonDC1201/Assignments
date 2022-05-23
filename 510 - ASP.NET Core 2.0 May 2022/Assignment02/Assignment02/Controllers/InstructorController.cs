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
                db.Add(instructors);
                db.SaveChanges();
                TempData["instructors"] = db.Instructors.ToList();
            }
            return View("Index");
        }

        // GET: InstructorController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: InstructorController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public ActionResult Delete(InstructorModel instructorDelete)
        {
            using (var db = new SchoolDbContext())
            {
                TempData["instructorbyid"] = db.Instructors.Where(i => i.InstructorId == instructorDelete.InstructorId).FirstOrDefault();
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
                TempData["instructors"] = db.Instructors.ToList();
            }
            return View("Index");
        }
    }
}
