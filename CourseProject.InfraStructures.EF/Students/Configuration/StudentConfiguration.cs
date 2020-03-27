using CourseProject.Domain.Entities.Students;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.InfraStructures.EF.Students.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("tblStudents");
            builder.Property(c => c.FirstName).HasMaxLength(100);
            builder.Property(c => c.LastName).HasMaxLength(100).IsRequired();

        }
    }
}
