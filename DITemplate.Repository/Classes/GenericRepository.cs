using DITemplate.DbFactory.Interfaces;
using DITemplate.DB;
using DITemplate.Repository.Interfaces;

namespace DITemplate.Repository.Classes
{

    public class GenericRepository : IGenericRepository
    {
        private DITemplateEntities dbContext;

        protected IDbFactory DbFactory
        {
            get;
            private set;
        }

        public GenericRepository(IDbFactory dbFactory)
        {
            this.DbFactory = dbFactory;
        }

        public GenericRepository(DITemplateEntities dbContext)
        {
            this.dbContext = dbContext;
        }

        protected DITemplateEntities DbContext
        {
            get
            {
                return dbContext ?? (dbContext = DbFactory.Init());
            }
        }

        public void Dispose()
        {
            this.dbContext.Dispose();
        }

        public int SaveChanges()
        {
            if (this.dbContext != null)
            {
                return this.dbContext.SaveChanges();
            }
            return 0;
        }
    }
}
