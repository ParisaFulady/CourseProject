using CourseProject.Domain.Entities.Students;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.InfraStructures.EF.Students.Configuration
{
    public class StudentCourseConfigurtion : IEntityTypeConfiguration<StudentCourse>
    {
        public void Configure(EntityTypeBuilder<StudentCourse> builder)
        {
            builder.ToTable("tblStudentCourse");
        }
    }
}
