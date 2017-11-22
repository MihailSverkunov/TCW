using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;
using TaskManagerSM.DataAccess.Projects;

using TaskManagerSM.Entities;
using TaskManagerSM.ViewModel.Projects;
using AutoMapper;
using TaskManagerSM.DataAccess.UnitOfWork;

namespace TaskManagerSM.DataAccess.DbImplementation.Projects
{
    public class ProjectQuery : IProjectQuery
    {


        private IUnitOfWork Uow { get; }
        private IAsyncQueryableFactory Factory { get; }
        public ProjectQuery(IUnitOfWork uow, IAsyncQueryableFactory factory)
        {
            Uow = uow;
            Factory = factory;
        }

        public async Task<ProjectResponse> RunAsync(int projectId)
        {


            //for (int i = 0; i < 1000; i++)
            //{
            //    //message
            //    if(cancel)
            //    {
            //        return;
            //    }
            //}
            Mapper.Initialize(cfg => cfg.CreateMap<Project, ProjectResponse>()
                                        .ForMember("OpenTasksCount", otc => otc.MapFrom(src => src.Tasks.Count(t => t.Status != Entities.TaskStatus.Completed))));

            var query = Uow.Projects
                .Select(p => Mapper.Map<ProjectResponse>(p));
            //{
            //    Id = p.Id,
            //    Name = p.Name,
            //    Description = p.Description,
            //    OpenTasksCount = p.Tasks.Count(t => t.Status != Entities.TaskStatus.Completed)
            //}

            return await Factory.CreateAsyncQueryable(query).FirstOrDefaultAsync(pr => pr.Id == projectId);

            

            //cancelationToken
            //toListAsync
            //toArrayASync
        }
    }
}