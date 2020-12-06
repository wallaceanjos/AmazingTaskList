using AmazingTaskList.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace AmazingTaskList.Infrastructure
{
    public class AmazingTaskListDbContext : DbContext
    {
        public DbSet<TaskItem> TaskItems { get; set; }

        public AmazingTaskListDbContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AmazingTaskListDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=FalseData Source=(localdb)\MSSQLLocalDB;Initial Catalog=AmazingTaskListDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
