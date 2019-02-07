using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DITemplate.DB;
using DITemplate.DbFactory.Interfaces;

namespace DITemplate.DbFactory.Classes
{
    public class DBFactory : IDbFactory
    {
        private DITemplateEntities dbContext;
        public DITemplateEntities Init()
        {
            return this.dbContext ?? (dbContext = new DITemplateEntities());
        }
    }
}
