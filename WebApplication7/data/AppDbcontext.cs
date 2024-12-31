using Microsoft.EntityFrameworkCore;
using WebApplication7.Models;

namespace WebApplication7.data
{
    public class AppDbcontext : DbContext
    {
        public DbSet<Assigment> Assigments { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student>students { get; set; }

        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options) { }

    }
}
