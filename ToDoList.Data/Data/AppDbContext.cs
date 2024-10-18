using Microsoft.EntityFrameworkCore;
using ToDoList.Models.Models;

namespace ToDoList.Data.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<ToDo> ToDos { get; set; }
    }
}
