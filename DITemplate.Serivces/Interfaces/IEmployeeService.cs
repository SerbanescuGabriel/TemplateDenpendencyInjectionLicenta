using DITemplate.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITemplate.Serivces.Entities;

namespace DITemplate.Serivces.Interfaces
{
    public interface IEmployeeService
    {
        List<EmployeeEntity> GetAllEmployee();
    }
}
