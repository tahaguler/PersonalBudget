using PersonalBudget.EntityFrameworkCore.Repository;
using PersonalBudget.Helper;
using System.Collections.Generic;

namespace PersonalBudget.Api.Services
{
    public class PersonalBudgetService
    {
        IRepository<Budget> supplyRepo = new EFRepository<Budget>(new PersonalBudgetDbContext());

        public IEnumerable<Budget> GetAllBudget()
        {
            IEnumerable<Budget> budgetList = supplyRepo.GetAll();
            return budgetList;
        }

        public Budget ParseAddBudgetRequestToBudget(BudgetDto addBudgetRequest)
        {
            Budget budget = new Budget();
            budget.Name = addBudgetRequest.Name;
            budget.Category = addBudgetRequest.Category;
            budget.CreateUser = addBudgetRequest.CreateUser;
            budget.TenantId = ConvertHelper.Instance.ConvertToInt(addBudgetRequest.TenantId);
            return budget;
        }

        public async void CreateNewBudget(Budget budget)
        {
            budget.CreateDate = DateHelper.Instance.GetCurrentUniversalFormat();
            budget.IsDeleted = false;
            await supplyRepo.AddAsync(budget);
        }
    }
}
