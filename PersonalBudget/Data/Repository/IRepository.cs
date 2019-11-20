using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading;
using System.Threading.Tasks;

namespace PersonalBudget.Api.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        ValueTask<EntityEntry<T>> AddAsync(T entity, CancellationToken cancellationToken = default(CancellationToken));
    }
}
