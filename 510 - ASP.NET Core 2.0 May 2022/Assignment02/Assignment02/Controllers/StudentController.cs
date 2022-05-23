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
        public ActionResult Create(StudentModel studentCreate)
        {
            using(var db = new SchoolDbContext())
            {
                db.Add(studentCreate);
                db.SaveChanges();
                TempData["students"] = db.Students.ToList();
            }
            return View("Index");
        }

        // GET: StudentController/Edit/5
        
        public ActionResult Edit(StudentModel student)
        {
            using(var db = new SchoolDbContext())
            {
                TempData["studentbyid"] = db.Students.Where(s=>s.StudentId == student.StudentId).FirstOrDefault();
            }
            return View();
        }

        // POST: StudentController/Edit/5
        public ActionResult Update(StudentModel studentUpdate)
        {
            using(var db =new SchoolDbContext())
            {
                var studentTemp = db.Students.Where(s=>s.StudentId==studentUpdate.StudentId).FirstOrDefault();

                studentTemp.FirstName = studentUpdate.FirstName;
                studentTemp.LastName = studentUpdate.LastName;
                studentTemp.Email = studentUpdate.Email;
                studentTemp.Phone = studentUpdate.Phone;

                db.SaveChanges();
                TempData["students"] = db.Students.ToList();
            }

            return View("Index");
        }

        /*
         * DELETE
         */
        public ActionResult Delete(StudentModel student)
        {
            using (var db = new SchoolDbContext())
            {
                TempData["studenttodelete"] = db.Students.Where(s => s.StudentId == student.StudentId).FirstOrDefault();
            }
            return View();
        }

        public ActionResult DeleteFinal(StudentModel studentDelete)
        {
            using (var db = new SchoolDbContext())
            {
                db.Attach(studentDelete);
                db.Students.Remove(studentDelete);
                db.SaveChanges();
                TempData["students"] = db.Students.ToList();
            }
            return View("Index");
        }
    }
}
