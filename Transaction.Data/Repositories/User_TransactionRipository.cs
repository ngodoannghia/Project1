using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction.Data.Infrastructure;
using Transaction.Models.Models;

namespace Transaction.Data.Repositories
{
    public interface IUser_Transaction : IRepository<User_Transaction>
    {
    }

    public class ContactDetailRepository : RepositoryBase<User_Transaction>, IUser_Transaction
    {
        public ContactDetailRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
