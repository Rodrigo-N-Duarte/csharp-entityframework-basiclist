using Microsoft.EntityFrameworkCore;

namespace todolist.Models
{
    public class TodoContext : DbContext
    {
        public TodoContext(DbContextOptions<TodoContext> dbContextOptions) : base(dbContextOptions) { }

        public DbSet<TodoItem> TodoItems { get; set; } = null!;
    }
}
