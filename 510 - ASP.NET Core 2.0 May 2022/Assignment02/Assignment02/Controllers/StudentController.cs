using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment02.Models;
using System.Linq;

namespace Assignment02.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentController
        public ActionResult Index()
        {
            using(var db = new SchoolDbContext()) 
            {
            TempData["students"] =  db.Students.ToList();
            }
            return View();
        }

        // GET: StudentController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: StudentController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentController/Create
        [HttpPost]
        public ActionResult Create(StudentModel student)
        {
            using(var db = new SchoolDbContext())
            {
                db.Add(student);
                db.SaveChanges();
            }
            return View(student);
        }

        // GET: StudentController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: StudentController/Edit/5
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

        // GET: StudentController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: StudentController/Delete/5
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
