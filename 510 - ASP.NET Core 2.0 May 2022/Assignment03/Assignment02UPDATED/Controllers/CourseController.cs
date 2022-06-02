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
        // GET: CourseController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CourseController/Create
        [HttpPost]
        public ActionResult Create(CourseModel course)
        {
            using (var db = new SchoolDbContext())
            {
                db.Courses.Add(course);
                db.SaveChanges();
                TempData["courses"] = db.Courses.ToList();
            }

            return View("Index");
        }

        // GET: CourseController/Edit/5
        public ActionResult Edit(CourseModel item)
        {
            using(var db = new SchoolDbContext())
            {
                TempData["coursebyid"] = db.Courses.Where(c => c.CourseId == item.CourseId).FirstOrDefault();
            }

            return View();
        }

        // POST: CourseController/Edit/5
        [HttpPost]
        public ActionResult Update(CourseModel item)
        {
            using(var db = new SchoolDbContext())
            {
                var CourseTemp = db.Courses.Where(c => c.CourseId == item.CourseId).FirstOrDefault();
                CourseTemp.CourseId = item.CourseId;
                CourseTemp.CourseName = item.CourseName;
                db.SaveChanges();
                TempData["courses"] = db.Courses.ToList();
            }

            return View("Index");
        }

        // GET: CourseController/Delete/5
        [HttpPost]
        public ActionResult Delete(CourseModel course)
        {
            using(var db = new SchoolDbContext())
            {
                TempData["coursebyid"] = db.Courses.Where(c=>c.CourseId ==course.CourseId).FirstOrDefault();
            }
            return View();
        }

        // POST: CourseController/Delete/5
        [HttpPost]
        public ActionResult DeleteFinal(CourseModel courseDelete)
        {
            using(var db =new SchoolDbContext())
            {
                db.Attach(courseDelete);
                db.Courses.Remove(courseDelete);
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
