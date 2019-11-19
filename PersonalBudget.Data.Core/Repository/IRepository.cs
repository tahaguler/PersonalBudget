using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace PersonalBudget.Data.Core.Repository
{
   public interface IRepository<T> where T : class

   {
   void AddAsync(T Entity); // ToDo: Add cancellation token parameter.


   }
}
