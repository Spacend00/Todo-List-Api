
using Microsoft.EntityFrameworkCore;
using ToDoListApi.Domain.Entities;

namespace ToDoListApi.Infrastructure.Contexts
{
    public class ToDoDbContext : DbContext
    {
        public ToDoDbContext(DbContextOptions<ToDoDbContext> options) : base(options) { }
        public DbSet<ToDoItem> ToDoItems { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>()
                .HasOne(t => t.Category)
                .WithMany(c => c.ToDoItems)
                .HasForeignKey(t => t.CategoryId);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ToDoDbContext).Assembly);
        }
    }
}
