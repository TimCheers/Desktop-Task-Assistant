using Desktop_Task_Assistant.Models;
using Microsoft.EntityFrameworkCore;
using Npgsql;

namespace Desktop_Task_Assistant.Data
{
    internal class ApplicationDbContext : DbContext
    {
        private NpgsqlConnectionStringBuilder build;
        public DbSet<Category> Categories { get; set; }
        public DbSet<CategoryGroup> CategoryGroups { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<Dashboard> Dashboards { get; set; }
        public DbSet<Priority> Priorities { get; set; }
        public DbSet<Repeat> Repeats { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<TaskStatus> TaskStatuses { get; set; }
        public ApplicationDbContext()
        {
            build = new NpgsqlConnectionStringBuilder
            {
                Host = "localhost",
                Port = 5432,
                Database = "TaskAss",
                Username = "postgres",
                Password = "123321",
            };
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(build.ToString());
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //дополнительные настройки моделей здесь, если необходимо
        }
    }
}
