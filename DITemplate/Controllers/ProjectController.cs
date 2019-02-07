using System.Web.Http;
using DITemplate.Serivces.Interfaces;

namespace DITemplate.Controllers
{
    [RoutePrefix("api/project")]
    public class ProjectController : ApiController
    {
        private readonly IProjectService projectService;

        public ProjectController(IProjectService projectService)
        {
            this.projectService = projectService;
        }

        [HttpGet]
        public IHttpActionResult GetAllProjects()
        {
            return this.Ok(projectService.GetAllProjectEntities());
        }
    }
}
