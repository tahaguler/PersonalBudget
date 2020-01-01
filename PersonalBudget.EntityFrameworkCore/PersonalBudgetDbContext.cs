using Microsoft.EntityFrameworkCore;
using PersonalBudget.Core.Budget;

namespace PersonalBudget.EntityFrameworkCore
{
 public    class PersonalBudgetDbContext : DbContext
    {
        public PersonalBudgetDbContext(DbContextOptions<PersonalBudgetDbContext> options) : base(options)
        // ToDo: Learn what does this base thing mean
        {

        }
        public DbSet<Budget> Budgets { get; set; }
        public DbSet<BudgetExpense> BudgetExpenses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder); // ToDo: What does this do?
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); // ToDo: What does this do?
        }
    }
}