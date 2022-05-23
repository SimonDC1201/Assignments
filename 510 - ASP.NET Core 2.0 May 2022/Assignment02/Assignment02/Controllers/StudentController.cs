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
                TempData["students"] = db.Students.ToList();
            }
            return View("Index");
        }

        // GET: StudentController/Edit/5
        [HttpPost]
        public ActionResult Edit(StudentModel item)
        {
            using(var db = new SchoolDbContext())
            {
                TempData["studentbyid"] = db.Students.Where(s=>s.StudentId == item.StudentId).FirstOrDefault();
            }
            return View();
        }

        // POST: StudentController/Edit/5
        public ActionResult Update(StudentModel student)
        {
            using(var db =new SchoolDbContext())
            {
                var studentTemp = db.Students.Where(s=>s.StudentId==student.StudentId).FirstOrDefault();

                studentTemp.StudentId = student.StudentId;
                studentTemp.FirstName = student.FirstName;
                studentTemp.LastName = student.LastName;
                studentTemp.Email = student.Email;
                studentTemp.Phone = student.Phone;
                studentTemp.CourseId = student.CourseId;

                db.SaveChanges();
                TempData["students"] = db.Students.ToList();
            }

            return View("Index");
        }

        // GET: StudentController/Delete/5
        public ActionResult Delete(StudentModel item)
        {
            using (var db = new SchoolDbContext())
            {
                TempData["studentbyid"] = db.Students.Where(s => s.StudentId == item.StudentId).FirstOrDefault();
            }
            return View();
        }

        // POST: StudentController/Delete/5
        [HttpPost]
        public ActionResult DeleteFinal(StudentModel student)
        {
            using (var db = new SchoolDbContext())
            {
                db.Attach(student);
                db.Students.Remove(student);
                db.SaveChanges();
                TempData["students"] = db.Students.ToList();
            }
            return View("Index");
        }
    }
}
