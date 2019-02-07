using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITemplate.Repository.Interfaces;
using DITemplate.Serivces.Entities;
using DITemplate.Serivces.Interfaces;

namespace DITemplate.Serivces.Classes
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public List<ProjectEntity> GetAllProjectEntities()
        {
            var projects = projectRepository.GetAllProjects();
            List<ProjectEntity> projectEntities = new List<ProjectEntity>();

            foreach (var project in projects)
            {
                projectEntities.Add(Mapper.ProjectEntityMapper(project));
            }

            return projectEntities;
        }
    }
}
