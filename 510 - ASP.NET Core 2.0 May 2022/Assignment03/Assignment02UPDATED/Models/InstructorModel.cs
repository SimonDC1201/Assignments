using System.ComponentModel.DataAnnotations;

namespace Assignment02.Models
{
    public class InstructorModel
    {
        [Key]
        public int? InstructorId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public virtual int? CourseId { get; set; }
    }
}
