using Assignment02.Models;
using System.Collections.Generic;
namespace Assignment02.Data.MockRepo
{
    public class InstructorMockRepo
    {
        private List<Instructor> _instructors = new List<Instructor>()
        {
            new Instructor {InstructorId= "i_001", InstructorFirstName="Simon", InstructorLastName="Dionne", InstructorEmail="Simon@FakeEmail.com", InstructorCourse="French"},
            new Instructor {InstructorId= "i_002", InstructorFirstName="Cedrik", InstructorLastName="Couture", InstructorEmail="Cedrik@FakeEmail.com", InstructorCourse="English"}
        };

        public List<Instructor> GetAll()
        {
            return _instructors;
        }
    }
}
