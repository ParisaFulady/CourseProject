using CourseProject.Domain.Entities.Courses;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.InfraStructures.EF.Courses.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.ToTable("tblCourse");
            builder.Property(c => c.Title).HasMaxLength(200).IsRequired();
            builder.Property(c => c.ImageUrl).HasMaxLength(200).IsRequired();

        }
    }
}
