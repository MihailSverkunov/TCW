using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TaskManagerSM.DataAccess.UnitOfWork;

namespace TaskMnanagerSM.DataAccess.UnitOfWork.Implementation
{
    public class AsyncQueryableFactory : IAsyncQueryableFactory
    {
        public IAsyncQueryable<T> CreateAsyncQueryable<T>(IQueryable<T> query)
        {
            return new AsyncQueryable<T>(query);
        }
    }
}
