using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITemplate.DB;
using DITemplate.Repository.Interfaces;

namespace DITemplate.Repository.Classes
{
    public class ProjectRepository : IProjectRepository
    {

        private readonly DITemplateEntities dbContext;

        public ProjectRepository(DITemplateEntities dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Project> GetAllProjects()
        {
            return dbContext.Projects.ToList();
        }
    }
}
