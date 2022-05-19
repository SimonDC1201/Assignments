using Assignment02.Models;
using System;
using System.Collections.Generic;

namespace Assignment02.Data.MockRepo
{
    public class CourseMockRepo
    {
        
        private List<Course> _courses = new List<Course>()
        {
            new Course {CourseId= "c_001", CourseName="French" , StudentRegistered= new List<Student>()},
            new Course {CourseId= "c_002", CourseName="English", StudentRegistered= new List<Student>() }
        };
            

        public List<Course> GetAll()
        {
            List<Student> students = new StudentMockRepo().GetAll();

            for (int j = 0; j < _courses.Count; j++)
            {
                for (int i = 0; i < students.Count; i++)
                {
                    if (_courses[j].CourseName == students[i].StudentCourseRegistered)
                    {
                        _courses[j].StudentRegistered.Add(students[i]);
                    }
                }
            }
            return _courses;
            
        }
    }
}
