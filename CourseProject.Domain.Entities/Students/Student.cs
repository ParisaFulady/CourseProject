using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Entities.Students
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime SabteNameDate { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; }
    }
}
