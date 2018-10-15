using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transaction.Models.Models;

namespace Transaction.Data
{
    public class TransactionDbContext:DbContext
    {
        public TransactionDbContext() : base("Transactionconection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<User_Transaction> User_Transactions { get; set; }
        public DbSet<Deliver> Delivers { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

        }
    }
}
