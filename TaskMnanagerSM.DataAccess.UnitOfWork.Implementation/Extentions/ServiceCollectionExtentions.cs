using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskMnanagerSM.DataAccess.UnitOfWork.Implementation;

namespace TaskManagerSM.DataAccess.UnitOfWork.Implementation.Extentions
{
    public static class ServiceCollectionExtentions
    {
        public static IServiceCollection RegisterUnitOfWork(this IServiceCollection services, string connectionString)
        {
            services

                .AddDbContext<Db.TasksContext>(options => options.UseSqlServer(connectionString))
                .AddScoped<IUnitOfWork, UnitOfWork>()
                .AddTransient<IAsyncQueryableFactory, AsyncQueryableFactory>();
            return services;
        }
    }
}
