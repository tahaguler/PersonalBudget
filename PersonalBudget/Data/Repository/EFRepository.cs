using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace PersonalBudget.Api.Data.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public EFRepository(DbContext dbContext)
        {
            if (dbContext == null)
                throw new ArgumentNullException("dbContext can not be null.");
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public void Add(T Entity)
        {
            throw new NotImplementedException();
        }

        public ValueTask<EntityEntry<T>> AddAsync(T entity, CancellationToken cancellationToken = default(CancellationToken))
        {
            return _dbSet.AddAsync(entity, cancellationToken);
        }
    }
}
