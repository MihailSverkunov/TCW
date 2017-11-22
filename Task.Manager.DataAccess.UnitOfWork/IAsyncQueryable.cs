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

        Task<bool> AllAsync(Expression<Func<TSource, bool>> predicate);

        Task<int> CountAsync();

        Task<int> CountAsync(Expression<Func<TSource, bool>> predicate);

        Task<TSource> FirstAsync();

        Task<TSource> FirstAsync(Expression<Func<TSource, bool>> predicate);

        Task<TSource> LastAsync();

        Task<TSource> LastAsync(Expression<Func<TSource, bool>> predicate);

        Task<TSource> LastOrDefaultAsync();

        Task<TSource> LastOrDefaultAsync(Expression<Func<TSource, bool>> predicate);

        Task<TSource> SingleAsync();

        Task<TSource> SingleAsync(Expression<Func<TSource, bool>> predicate);

        Task<TSource> SingleOrDefaultAsync();

        Task<TSource> SingleOrDefaultAsync(Expression<Func<TSource, bool>> predicate);

        Task<TSource> MinAsync();

        // Task<TResult> MinAsync<T, TResult>(Expression<Func<T, TResult>> selector);

        Task<TSource> MaxAsync();

        //Task<TResult> MaxAsync<TSource, TResult>(Expression<Func<TSource, TResult>> selector)

        

        Task<List<TSource>> ToListAsync();

        Task<TSource[]> ToArrayAsync();
    }
}
