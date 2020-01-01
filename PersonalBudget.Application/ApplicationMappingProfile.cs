using AutoMapper;
using PersonalBudget.Core.Budget;
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalBudget.Application
{
    public class ApplicationMappingProfile : Profile
    {
        public ApplicationMappingProfile()
        {
            CreateMap<BudgetDto, Core.Budget.Budget>();
        }
    }
}
