using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MRG_HomeAssignment.Lib.DomainClass;

namespace MRG_HomeAssignment.Lib
{
    public class UserContext:DbContext
    {
        public UserContext() 
            : base("name=UserDB")
        {
            Database.SetInitializer<UserContext>(new DropCreateDatabaseIfModelChanges<UserContext>());
        }

        public virtual DbSet<mrgreenCustomer> MrgreenCustomers { get; set; }
        public virtual DbSet<redbetCustomer> RedbetCustomers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
