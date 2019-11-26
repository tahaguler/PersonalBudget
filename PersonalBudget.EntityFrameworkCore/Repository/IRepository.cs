using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;


namespace PersonalBudget.EntityFrameworkCore.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll(Expression<Func<T, bool>> predicate = null);

        Task<int> AddAsync(T entity);
    }
}
