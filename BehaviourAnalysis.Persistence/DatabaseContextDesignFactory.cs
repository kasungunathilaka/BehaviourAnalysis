using System;
using System.Collections.Generic;
using System.Text;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BehaviourAnalysis.Persistence
{
    public class DatabaseContextDesignFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlServer("Data Source=KasunG;Initial Catalog=behaviourcore;Persist Security Info=True;User ID=bauser;Password=ba_user123;");

            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
