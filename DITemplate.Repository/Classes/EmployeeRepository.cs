using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using DITemplate.DB;
using DITemplate.Repository.Interfaces;

namespace DITemplate.Repository.Classes
{
    public class EmployeeRepository : GenericRepository, IEmployeeRepository
    {
        private DITemplateEntities dbContext;
        public EmployeeRepository(DITemplateEntities dbContext) : 
            
            
            base(dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<Employee> GetAllEmployees()
        {
            return dbContext.Employees.ToList();
        }
    }
}
