using CourseProject.Domain.Entities.Instructors;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.InfraStructures.EF.Instructors.Configuration
{
    public class CourseInstructorConfiguration : IEntityTypeConfiguration<CourseInstructor>
    {
        public void Configure(EntityTypeBuilder<CourseInstructor> builder)
        {
            builder.ToTable("tblCourseInstructor");
        }
    }
}
