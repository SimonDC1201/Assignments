using System.Collections.Generic;
namespace Assignment02.Models
{
    public class Course
    {
        public string CourseId { get; set; }
        public string CourseName { get; set; }
        public List<Student> StudentRegistered { get; set; }
    }
}
