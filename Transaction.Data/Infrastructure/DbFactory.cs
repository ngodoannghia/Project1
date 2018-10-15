using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transaction.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private TransactionDbContext dbContext;

        public TransactionDbContext Init()
        {
            return dbContext ?? (dbContext = new TransactionDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
