using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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

        public IEnumerable<T> GetAll()
        {
            return _dbSet;
        }

        public async Task<int> Update(T entity)
        {
            int result;
            try
            {
                _dbSet.Attach(entity);
                _dbContext.Entry(entity).State = EntityState.Modified;
                result = await _dbContext.SaveChangesAsync();
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        public void Add(T Entity)
        {
            throw new NotImplementedException();
        }

        public async Task<int> AddAsync(T entity)
        {
            int result = 0;
            try
            {
                await _dbSet.AddAsync(entity);
                result = await _dbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
            }
            return result;
        }
    }
}
