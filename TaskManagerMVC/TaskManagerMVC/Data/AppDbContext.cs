using Microsoft.EntityFrameworkCore;
using TaskManagerMVC.Entities;

namespace TaskManagerMVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<TaskEntity> Tasks { get; set; }
    }
}
