using DITemplate.DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DITemplate.DbFactory.Interfaces
{
    public interface IDbFactory
    {
        DITemplateEntities Init();
    }
}
