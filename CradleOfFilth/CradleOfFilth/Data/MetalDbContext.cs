using CradleOfFilth.Models;
using Microsoft.EntityFrameworkCore;

namespace CradleOfFilth.Data
{
    public class MetalDbContext : DbContext
    {
        public MetalDbContext(DbContextOptions<MetalDbContext> options) : base(options)
        {
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}