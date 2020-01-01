using PersonalBudget.Core.Budget;
using PersonalBudget.EntityFrameworkCore;
using PersonalBudget.EntityFrameworkCore.Repository;
using PersonalBudget.Helper;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;

namespace PersonalBudget.Application.Budget
{
    public class BudgetAppService : IBudgetAppService
    {
        private readonly IRepository<Core.Budget.Budget> _budgetRepo;
        private readonly IRepository<BudgetExpense> _budgetExpenseRepository;
        private readonly IMapper _mapper;

        public BudgetAppService(IRepository<Core.Budget.Budget> budgetRepo, IRepository<BudgetExpense> budgetExpenseRepository, IMapper mapper)
        {
            _budgetRepo = budgetRepo;
            _budgetExpenseRepository = budgetExpenseRepository;
            _mapper = mapper;
        }

        public IEnumerable<Core.Budget.Budget> GetAllBudget()
        {
            IEnumerable<Core.Budget.Budget> budgetList = _budgetRepo.GetAll();
            return budgetList;
        }

        public Task<int> CreateBudget(Core.Budget.Budget budget)
        {
            budget.CreateDate = DateHelper.Instance.GetCurrentUniversalFormat();
            budget.IsDeleted = false;
            throw new System.NotImplementedException();
        }
    }
}