using Microsoft.EntityFrameworkCore;
using PracticeAngular.Models;
using System;

namespace PracticeAngular.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    }
}
