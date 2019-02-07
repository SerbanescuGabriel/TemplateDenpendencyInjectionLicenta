using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITemplate.Repository.Interfaces
{
    public interface IGenericRepository : IDisposable
    {
        int SaveChanges();
    }
}
