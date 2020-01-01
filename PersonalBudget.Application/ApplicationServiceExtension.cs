using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PersonalBudget.Application.Budget;
using PersonalBudget.Core.Budget;

namespace PersonalBudget.Application
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddPersonalBudgetApplication(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(ApplicationMappingProfile));
            services.AddTransient<IBudgetAppService, BudgetAppService>();
            return services;
        }
    }
}
