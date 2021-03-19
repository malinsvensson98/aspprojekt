using System;
using aspprojekt.Models;
using Microsoft.EntityFrameworkCore;

namespace aspprojekt.Data
{
    public class WorkContext : DbContext
    {
        public WorkContext(DbContextOptions<WorkContext> options) : base(options)
        {
        }

        // Tabell
        public DbSet<Works> Works { get; set; }
    }
}
