

using System.Linq;

namespace TaskManagerSM.DataAccess.UnitOfWork
{
    public interface IAsyncQueryableFactory
    {
        IAsyncQueryable<T> CreateAsyncQueryable<T>(IQueryable<T> query);
    }
}
