using Assignment03.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment03.DTO
{
    public class AppDbContext : DbContext
    {
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public AppDbContext() : base() { }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
