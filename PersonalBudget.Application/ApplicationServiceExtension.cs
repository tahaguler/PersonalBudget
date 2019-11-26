using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using PersonalBudget.Core.Budget;

namespace PersonalBudget.Application
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddPersonalBudgetApplication(this IServiceCollection services)
        {
            services.AddAutoMapper();
            services.AddTransient<, >();
            return services;
        }
    }
}
