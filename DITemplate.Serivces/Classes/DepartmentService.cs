using System.Collections.Generic;
using DITemplate.Repository.Interfaces;
using DITemplate.Serivces.Entities;
using DITemplate.Serivces.Interfaces;

namespace DITemplate.Serivces.Classes
{
    public class DepartmentService : IDepartmentService
    {
        private IDepartmentRepository departmentRepository;

        public DepartmentService(IDepartmentRepository departmentRepository)
        {
            this.departmentRepository = departmentRepository;
        }

        public List<DepartmentEntity> GetADepartmentEntities()
        {
            var departments = departmentRepository.GetAllDepartments();
            List<DepartmentEntity> departmentEntities = new List<DepartmentEntity>();

            foreach (var department in departments)
            {
                departmentEntities.Add(Mapper.DepartmentEntityMapper(department));
            }

            return departmentEntities;
        }
    }
}
