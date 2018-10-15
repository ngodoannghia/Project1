using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Data.Infrastructure
{
    
    public class UnitOfWork:IUnitOfWork
    {
        private readonly IDbFactory dbFactory;
        public TransactionDbContext dbContext;
        public UnitOfWork(IDbFactory dbFactory)
        {
            this.dbFactory = dbFactory;
        }

        public TransactionDbContext DbContext
        {
            get { return dbContext ?? (dbContext = dbFactory.Init()); }
        }
        public void Commit()
        {
            dbContext.SaveChanges();
        }
    }
}
