using CourseProject.Domain.Entities.Courses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Entities.Instructors
{
    public class CourseInstructor
    {
        public int CourseInstructorID { get; set; }
        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }
        public int CourseID { get; set; }
        public Course Course { get; set; }
    }
}
