using System;
using aspprojekt.Models;
using Microsoft.EntityFrameworkCore;

namespace aspprojekt.Data
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options)
        {
        }

        // Tabell
        public DbSet<Courses> Courses { get; set; }
    }
}
