using Microsoft.Extensions.DependencyInjection;
using PersonalBudget.EntityFrameworkCore.Repository;

namespace PersonalBudget.EntityFrameworkCore
{
    public static class EFCoreServiceCollectionExtension
    {
        public static IServiceCollection AddPersonalBudgetEntityFrameworkCore(this IServiceCollection services)
        {
            services.AddScoped(typeof(IRepository<>), typeof(EFRepository<>));
            services.AddScoped<PersonalBudgetDbContext>();
            return services;
        }
    }
}
