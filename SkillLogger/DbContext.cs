using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SkillLogger.Program;

namespace SkillLogger
{
    public class MyDbContext : DbContext
    {
        // Define the DbSet for your entities
        public DbSet<MyEntity> MyEntities { get; set; }

        // Constructor with connection string passed to the base class
        public MyDbContext() : base("PostgresConnection") { }

        // OnModelCreating can be used for configuring model properties
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            // Configure table names, relationships, etc. if needed
        }
    }

}
