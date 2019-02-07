using System.Collections.Generic;
using DITemplate.Repository.Interfaces;
using DITemplate.Serivces.Entities;
using DITemplate.Serivces.Interfaces;

namespace DITemplate.Serivces.Classes
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository employeeRepository;

        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            this.employeeRepository = employeeRepository;
        }

        public List<EmployeeEntity> GetAllEmployee()
        {
            var employees = employeeRepository.GetAllEmployees();
            List<EmployeeEntity> employeeEntities = new List<EmployeeEntity>();

            foreach (var employee in employees)
            {
                employeeEntities.Add(Mapper.EmployeeEntityMapper(employee));
            }

            return employeeEntities;
        }
    }
}
