using CourseProject.Domain.Entities.Courses;
using CourseProject.Domain.Entities.Instructors;
using CourseProject.Domain.Entities.Students;
using CourseProject.InfraStructures.EF.Courses.Configuration;
using CourseProject.InfraStructures.EF.Instructors.Configuration;
using CourseProject.InfraStructures.EF.Students.Configuration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.InfraStructures.EF
{
    public class CourseDBContext:DbContext
    {
        public CourseDBContext(DbContextOptions<CourseDBContext> option) : base(option)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<StudentCourse> StudentCourse { get; set; }
        public DbSet<Course> Course { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<CourseInstructor> CourseInstructor { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new CourseInstructorConfiguration());
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentCourseConfigurtion());
        
            base.OnModelCreating(modelBuilder);
        }

    }
}
