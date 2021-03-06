﻿// <auto-generated />
using System;
using CourseProject.InfraStructures.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;


namespace CourseProject.InfraStructures.EF.Migrations
{
    [DbContext(typeof(CourseDBContext))]
    partial class CourseDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CourseProject.Domain.Entities.Courses.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<decimal>("Price");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("CourseID");

                    b.ToTable("tblCourse");
                });

            modelBuilder.Entity("CourseProject.Domain.Entities.Instructors.CourseInstructor", b =>
                {
                    b.Property<int>("CourseInstructorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID");

                    b.Property<int>("InstructorID");

                    b.HasKey("CourseInstructorID");

                    b.HasIndex("CourseID");

                    b.HasIndex("InstructorID");

                    b.ToTable("tblCourseInstructor");
                });

            modelBuilder.Entity("CourseProject.Domain.Entities.Instructors.Instructor", b =>
                {
                    b.Property<int>("InstructorID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<string>("ImageUrl")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("InstructorID");

                    b.ToTable("tblInstructor");
                });

            modelBuilder.Entity("CourseProject.Domain.Entities.Students.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FirstName")
                        .HasMaxLength(100);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime>("SabteNameDate");

                    b.HasKey("StudentID");

                    b.ToTable("tblStudents");
                });

            modelBuilder.Entity("CourseProject.Domain.Entities.Students.StudentCourse", b =>
                {
                    b.Property<int>("StudentCourseID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseID");

                    b.Property<decimal>("Grade");

                    b.Property<int>("StudentID");

                    b.HasKey("StudentCourseID");

                    b.HasIndex("CourseID");

                    b.HasIndex("StudentID");

                    b.ToTable("tblStudentCourse");
                });

            modelBuilder.Entity("CourseProject.Domain.Entities.Instructors.CourseInstructor", b =>
                {
                    b.HasOne("CourseProject.Domain.Entities.Courses.Course", "Course")
                        .WithMany("CourseInstructor")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CourseProject.Domain.Entities.Instructors.Instructor", "Instructor")
                        .WithMany("CourseInstructor")
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("CourseProject.Domain.Entities.Students.StudentCourse", b =>
                {
                    b.HasOne("CourseProject.Domain.Entities.Courses.Course", "Course")
                        .WithMany("StudentCourse")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("CourseProject.Domain.Entities.Students.Student", "Student")
                        .WithMany("StudentCourse")
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
