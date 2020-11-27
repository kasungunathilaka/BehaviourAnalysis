using System;
using System.Collections.Generic;
using System.Text;

using BehaviourAnalysis.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BehaviourAnalysis.Persistence.EntityConfigurations
{
    class QuestionnaireEntityTypeConfiguration : IEntityTypeConfiguration<Questionnaire>
    {
        public void Configure(EntityTypeBuilder<Questionnaire> builder)
        {
            builder.ToTable("Questionnaire");

            builder.Property(q => q.Nervous)
                .IsRequired(true);

            builder.Property(q => q.Panic)
                .IsRequired(true);

            builder.Property(q => q.BreathingRapidly)
                .IsRequired(true);

            builder.Property(q => q.Sweating)
                .IsRequired(true);

            builder.Property(q => q.TroublesInConcentration)
                .IsRequired(true);

            builder.Property(q => q.TroublesInSleeping)
                .IsRequired(true);

            builder.Property(q => q.TroublesWithWork)
                .IsRequired(true);

            builder.Property(q => q.Hopeless)
                .IsRequired(true);

            builder.Property(q => q.Angry)
                .IsRequired(true);

            builder.Property(q => q.OverReacting)
                .IsRequired(true);

            builder.Property(q => q.ChangesInEating)
                .IsRequired(true);

            builder.Property(q => q.SuicidalThoughts)
                .IsRequired(true);

            builder.Property(q => q.Tired)
                .IsRequired(true);

            builder.Property(q => q.CloseFriend)
                .IsRequired(true);

            builder.Property(q => q.SocialMediaAddiction)
                .IsRequired(true);

            builder.Property(q => q.WeightGain)
                .IsRequired(true);

            builder.Property(q => q.MaterialPossession)
                .IsRequired(true);

            builder.Property(q => q.Shy)
                .IsRequired(true);

            builder.Property(q => q.StressfulMemories)
                .IsRequired(true);

            builder.Property(q => q.Nightmares)
                .IsRequired(true);

            builder.Property(q => q.AvoidingPeople)
                .IsRequired(true);

            builder.Property(q => q.NegativeThoughts)
                .IsRequired(true);

            builder.Property(q => q.TroublesInFocusing)
                .IsRequired(true);

            builder.Property(q => q.BlamingYourself)
                .IsRequired(true);
        }
    }
}
