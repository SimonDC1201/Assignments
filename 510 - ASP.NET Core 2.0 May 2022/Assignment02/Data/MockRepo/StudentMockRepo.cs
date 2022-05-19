using Assignment02.Models;
using System.Collections.Generic;

namespace Assignment02.Data.MockRepo
{
    public class StudentMockRepo
    {
        private List<Student> _students = new List<Student>()
        {
            new Student {StudentId= "s_001", StudentFirstName="Simon", StudentLastName="Dionne", StudentCourseRegistered="French"},
            new Student {StudentId= "s_002", StudentFirstName="Cedrik", StudentLastName="Couture", StudentCourseRegistered="English"},
            new Student {StudentId= "s_003", StudentFirstName="Ginette", StudentLastName="Longueuil", StudentCourseRegistered="French"},
            new Student {StudentId= "s_004", StudentFirstName="Joe", StudentLastName="Doe", StudentCourseRegistered="French"},
        };

        public List<Student> GetAll()
        {
            return _students;
        }
    }
}
