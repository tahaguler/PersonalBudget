using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace PersonalBudget.EntityFrameworkCore.Repository
{
    public class EFRepository<T> : IRepository<T> where T : class
    {
        public IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {
            throw new NotImplementedException();
        }

        public Task<int> AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
