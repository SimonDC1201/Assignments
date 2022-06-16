using Microsoft.EntityFrameworkCore;

namespace ToDoList.Models
{
    public class ToDoDbContext : DbContext
    {
        public DbSet<ListItem> ListItems { get; set; }
        public ToDoDbContext() : base() { }
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options) { }

    }
}
