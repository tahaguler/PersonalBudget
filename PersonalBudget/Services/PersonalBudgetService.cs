using PersonalBudget.Api.Data;
using PersonalBudget.Api.Data.Repository;
using PersonalBudget.Api.Helpers;
using PersonalBudget.Api.Models;
using PersonalBudget.Api.Models.RequestModels;
using System.Collections.Generic;

namespace PersonalBudget.Api.Services
{
    public class PersonalBudgetService
    {
        IRepository<Budget> supplyRepo = new EFRepository<Budget>(new DbContextPublic());

        public IEnumerable<Budget> GetAllBudget()
        {
            IEnumerable<Budget> budgetList = supplyRepo.GetAll();
            return budgetList;
        }

        public Budget ParseAddBudgetRequestToBudget(AddBudgetRequest addBudgetRequest)
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
