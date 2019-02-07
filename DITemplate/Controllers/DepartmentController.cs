using System.Web.Http;
using DITemplate.Serivces.Interfaces;

namespace DITemplate.Controllers
{
    [RoutePrefix("api/department")]
    public class DepartmentController : ApiController
    {
        private readonly IDepartmentService departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }

        [HttpGet]
        public IHttpActionResult GetAllDepartments()
        {
            return this.Ok(departmentService.GetADepartmentEntities());
        }
    }
}
