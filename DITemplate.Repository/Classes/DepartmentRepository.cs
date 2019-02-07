using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITemplate.DB;
using DITemplate.Repository.Interfaces;

namespace DITemplate.Repository.Classes
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private DITemplateEntities dbContext;

        public DepartmentRepository(DITemplateEntities dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Department> GetAllDepartments()
        {
            return dbContext.Departments.ToList();
        }
    }
}
