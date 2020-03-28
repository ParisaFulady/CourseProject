using CourseProject.Domain.Entities.Instructors;
using CourseProject.Domain.Entities.Students;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Entities.Courses
{
   public class Course
    {
        public int CourseID { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public ICollection<StudentCourse> StudentCourse { get; set; }
        public ICollection<CourseInstructor> CourseInstructor { get; set; }
    }
}
