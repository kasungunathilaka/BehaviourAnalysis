using System;
using System.Collections.Generic;
using System.Text;

using BehaviourAnalysis.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BehaviourAnalysis.Persistence.EntityConfigurations
{
    class QuestionEntityTypeConfiguration : IEntityTypeConfiguration<Question>
    {
        public void Configure(EntityTypeBuilder<Question> builder)
        {
            builder.ToTable("Question");

            builder.Property(q => q.QuestionBody)
                .IsRequired(true)
                .HasMaxLength(300);
        }
    }
}
