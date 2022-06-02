using System.ComponentModel.DataAnnotations;

namespace Assignment02.Models
{
    public class StudentModel
    {
        [Key]
        public int? StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public virtual int? CourseId { get; set; }

    }
}
