
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Extensions.Internal;
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


        public Task<bool> AllAsync(Expression<Func<T, bool>> predicate)
        {

            return _query.AllAsync(predicate);
        }

        public Task<int> CountAsync()
        {
            return _query.CountAsync();
        }

        public Task<int> CountAsync(Expression<Func<T, bool>> predicate)
        {
            return _query.CountAsync(predicate);
        }

        public Task<T> FirstAsync()
        {
            return _query.FirstAsync();
        }

        public Task<T> FirstAsync(Expression<Func<T, bool>> predicate)
        {

            return _query.FirstAsync(predicate);
        }

        public Task<T> LastAsync()
        {
            return _query.LastAsync();
        }

        public Task<T> LastAsync(Expression<Func<T, bool>> predicate)
        {
            return _query.LastAsync(predicate);
        }

        public Task<T> LastOrDefaultAsync()
        {
            return _query.LastOrDefaultAsync();
        }

        public  Task<T> LastOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return _query.LastOrDefaultAsync(predicate);
        }

        public Task<T> SingleAsync()
        {
            return _query.SingleAsync();
        }

        public Task<T> SingleAsync(Expression<Func<T, bool>> predicate)
        {
            return _query.SingleAsync(predicate);
        }

        public Task<T> SingleOrDefaultAsync()
        {
            return _query.SingleOrDefaultAsync();
        }

        public Task<T> SingleOrDefaultAsync(Expression<Func<T, bool>> predicate)
        {
            return _query.SingleOrDefaultAsync(predicate);
        }

        public Task<T> MinAsync()
        {
            return _query.MinAsync();
        }

        //public Task<TResult> MinAsync<T, TResult>(Expression<Func<T, TResult>> selector)
        //{
        //    return _query.MinAsync(_maxSelector, selector);
        //}

        public Task<T> MaxAsync()
        {
            return _query.MaxAsync();
        }

        //public static Task<TResult> MaxAsync<TSource, TResult>(Expression<Func<TSource, TResult>> selector)
        //{
        //    return ExecuteAsync<TSource, TResult>(_maxSelector, source, selector, cancellationToken);
        //}

        //public Task<decimal> SumAsync()
        //{
        //    return _query.SumAsync();
        //}

        //public Task<bool> ContainsAsync<TSource>(TSource item)
        //{
        //    return _query.ContainsAsync(
        //        Expression.Constant(item, typeof(TSource)));
        //}

        public Task<List<T>> ToListAsync()
            => _query.AsAsyncEnumerable().ToList();

        public Task<T[]> ToArrayAsync()
           => _query.AsAsyncEnumerable().ToArray();

    }
}
