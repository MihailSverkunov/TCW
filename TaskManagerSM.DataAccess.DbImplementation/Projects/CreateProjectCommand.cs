using System.Threading.Tasks;
using TaskManagerSM.DataAccess.Projects;
using TaskManagerSM.Entities;
using TaskManagerSM.ViewModel.Projects;
using AutoMapper;
using TaskManagerSM.DataAccess.UnitOfWork;

namespace TaskManagerSM.DataAccess.DbImplementation.Projects
{
    internal class CreateProjectCommand : ICreateProjectCommand
    {
        private IUnitOfWork Uow { get; }

        public CreateProjectCommand(IUnitOfWork uow)
        {
            Uow = uow;
        }

        public async Task<ProjectResponse> ExecuteAsync(CreateProjectRequest request)
        {
            var project = new Project
            {
                Name = request.Name,
                Description = request.Description
            };

            Uow.Projects.Add(project);
            await Uow.CommitAsync();

            return new ProjectResponse
            {
                Id = project.Id,
                Name = project.Name,
                Description = project.Description,
                OpenTasksCount = 0
            };
        }
    }
}