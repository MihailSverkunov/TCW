using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerSM.DataAccess.UnitOfWork
{
    public interface IAsyncQueryable<TSource>
    {
        Task<TSource> FirstOrDefaultAsync();

        Task<TSource> FirstOrDefaultAsync(Expression<Func<TSource, bool>> predicate);
    }
}
