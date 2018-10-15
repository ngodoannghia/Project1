using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction.Data.Infrastructure;
using Transaction.Models.Models;

namespace Transaction.Data.Repositories
{
    public interface IDeliver : IRepository<Deliver>
    {
    }

    public class DeliverRepository : RepositoryBase<Deliver>, IDeliver
    {
        public DeliverRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
