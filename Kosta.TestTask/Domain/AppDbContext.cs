using Kosta.TestTask.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Kosta.TestTask.Domain
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}