using System;
using System.Collections.Generic;
using System.Text;

using BehaviourAnalysis.Domain.Models;
using BehaviourAnalysis.Persistence.EntityConfigurations;
using Microsoft.EntityFrameworkCore;

namespace BehaviourAnalysis.Persistence
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Questionnaire> Questionnaires { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new QuestionEntityTypeConfiguration());
            modelBuilder.ApplyConfiguration(new QuestionnaireEntityTypeConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
