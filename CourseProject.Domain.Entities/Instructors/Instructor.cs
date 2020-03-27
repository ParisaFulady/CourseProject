using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.Domain.Entities.Instructors
{
   public class Instructor
    {
        public int InstructorID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<CourseInstructor> CourseInstructor { get; set; }
    }
}
