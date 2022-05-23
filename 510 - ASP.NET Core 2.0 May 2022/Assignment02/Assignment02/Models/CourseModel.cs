using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Assignment02.Models
{
    public class CourseModel
    {
        [Key]
        [Required]
        public int? CourseId { get; set; }
        public string CourseName { get; set; }
        public List<StudentModel> StudentRegistered { get; set; }
        
    }
}
