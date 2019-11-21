using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalBudget.Api.Data.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        Task<int> Update(T entity);

        void Add(T entity);
        Task<int> AddAsync(T entity);
    }
}