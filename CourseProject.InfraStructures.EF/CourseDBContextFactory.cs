using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseProject.InfraStructures.EF
{
    public class CourseDBContextFactory : IDesignTimeDbContextFactory<CourseDBContext>
    {
        public CourseDBContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<CourseDBContext>();
            builder.UseSqlServer("Server=.;Database=CourseProjectDB;User Id = sa;Password = ABCabc123456; ");

            return new CourseDBContext(builder.Options);
        }
    }
}
