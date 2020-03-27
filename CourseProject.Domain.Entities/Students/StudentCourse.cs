using CourseProject.Domain.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Entities.Students
{
   public class StudentCourse
    {
        public int StudentCourseID { get; set; }
        public Decimal Grade { get; set; }
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
