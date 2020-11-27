using System;
using System.Collections.Generic;
using System.Text;

using BehaviourAnalysis.Domain;
using BehaviourAnalysis.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace BehaviourAnalysis.Persistence
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Question> Customers { get; set; }
        public DbSet<Questionnaire> Franchisees { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new QuestionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionnaireEntityTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
