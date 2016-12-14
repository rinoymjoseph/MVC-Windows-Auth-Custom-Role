using MVCAuthSample.DBModel.Entity.Security;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCAuthSample.DBModel
{
    public class MVCAuthSampleDBContext : DbContext
    {
        public MVCAuthSampleDBContext() : base("MVCAuthSampleContext")
        {
        }

        public DbSet<User> Users { get; set; }

        public DbSet<Role> Roles { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
