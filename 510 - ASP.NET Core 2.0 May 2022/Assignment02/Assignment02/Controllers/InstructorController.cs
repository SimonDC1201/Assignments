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

        // GET: InstructorController/Details/5
        public ActionResult Details(int id)
        {
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

        // GET: InstructorController/Delete/5
        public ActionResult Delete(InstructorModel item)
        {
            using (var db = new SchoolDbContext())
            {
                TempData["instructorbyid"] = db.Instructors.Where(i => i.InstructorId == item.InstructorId).FirstOrDefault();
            }
            return View();
        }

        // POST: InstructorController/Delete/5
        [HttpPost]
        public ActionResult DeleteFinal(InstructorModel asdfasdf)
        {
            using (var db = new SchoolDbContext())
            {
                db.Attach(asdfasdf);
                db.Instructors.Remove(asdfasdf);
                db.SaveChanges();
                TempData["instructors"] = db.Instructors.ToList();
            }
            return View("Index");
        }
    }
}
