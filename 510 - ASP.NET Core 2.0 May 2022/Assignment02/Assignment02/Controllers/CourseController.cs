using Assignment02.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace Assignment02.Controllers
{
    public class CourseController : Controller
    {
        // GET: CourseController
        public ActionResult Index()
        {
            using(var db = new SchoolDbContext())
            {
                TempData["courses"] = db.Courses.ToList();
            }
            return View();
        }

        // GET: CourseController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CourseModel course)
        {
            using(var db = new SchoolDbContext())
            {
                db.Courses.Add(course);
                db.SaveChanges();
                db.Courses.ToList();
            }

            return View("Index");
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CourseController/Edit/5
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

        // GET: CourseController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
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
    }
}
