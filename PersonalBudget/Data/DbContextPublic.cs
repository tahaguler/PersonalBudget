using Microsoft.EntityFrameworkCore;
using PersonalBudget.Api.Models;

namespace PersonalBudget.Api.Data
{
    public class DbContextPublic : DbContext
    {
        public DbContextPublic()
        {

        }

        public DbContextPublic(DbContextOptions<DbContextPublic> options) : base(options) // ToDo: Learn what does this base thing mean
        {

        }

        // public virtual DbSet<Budget> Budgets { get; set; } // ToDo: Why did we put virtual here?
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<BudgetExpense> BudgetLogs { get; set; } // ToDo: Why did we put virtual here?

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); // ToDo: What does this do?
            optionsBuilder.UseSqlServer(
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PersonalBudget;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // ToDo: What does this do?
        }
    }
}
