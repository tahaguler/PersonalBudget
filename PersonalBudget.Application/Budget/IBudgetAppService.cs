using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudget.Application.Budget
{
    public interface IBudgetAppService
    {
         IEnumerable<Core.Budget.Budget> GetAllBudget();
        
        Task<int> CreateBudget(Core.Budget.Budget budget);
        
    }
}
