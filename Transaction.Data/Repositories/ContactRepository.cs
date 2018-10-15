using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction.Data.Infrastructure;
using Transaction.Models.Models;

namespace Transaction.Data.Repositories
{
    public interface IContact : IRepository<Contact>
    {
    }

    public class ContactRepository : RepositoryBase<Deliver>, IDeliver
    {
        public ContactRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
