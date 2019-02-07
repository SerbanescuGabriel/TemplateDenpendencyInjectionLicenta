using DITemplate.DB;
using DITemplate.Serivces.Entities;

namespace DITemplate.Serivces
{
    public class Mapper
    {
        public static EmployeeEntity EmployeeEntityMapper(Employee employee)
        {
            return new EmployeeEntity()
            {
                EmployeeId = employee.EmployeeId,
                FirstName = employee.FirstName,
                LastName = employee.LastName
            };
        }

        public static DepartmentEntity DepartmentEntityMapper(Department department)
        {
            return new DepartmentEntity()
            {
                DepartmentId = department.DepartmentId,
                DepartmentName = department.DepartmentName
            };
        }

        public static ProjectEntity ProjectEntityMapper(Project project)
        {
            return new ProjectEntity()
            {
                ProjectId = project.ProjectId,
                ProjectName = project.ProjectName
            };
        }
    }
}
