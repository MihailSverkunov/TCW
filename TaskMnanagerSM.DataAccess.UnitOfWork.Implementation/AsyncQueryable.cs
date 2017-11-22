
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TaskManagerSM.DataAccess.UnitOfWork;

namespace TaskMnanagerSM.DataAccess.UnitOfWork.Implementation
{

    internal class AsyncQueryable<T> : IAsyncQueryable<T>
    {
        private readonly IQueryable<T> _query;

        public AsyncQueryable(IQueryable<T> query)
        {
            _query = query;
        }

        public Task<T> FirstOrDefaultAsync()
        {
            return _query.FirstOrDefaultAsync();
        }

        public Task<T> FirstOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return _query.FirstOrDefaultAsync(predicate);
        }


    }
}
