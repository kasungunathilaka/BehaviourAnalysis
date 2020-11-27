using System;
using System.Collections.Generic;
using System.Text;

namespace BehaviourAnalysis.Domain.Models
{
    public class Questionnaire
    {
        public int QuestionnaireId { get; set; }
        public bool Nervous { get; set; }
        public bool Panic { get; set; }
        public bool BreathingRapidly { get; set; }
        public bool Sweating { get; set; }
        public bool TroublesInConcentration { get; set; }
        public bool TroublesInSleeping { get; set; }
        public bool TroublesWithWork { get; set; }
        public bool Hopeless { get; set; }
        public bool Angry { get; set; }
        public bool OverReacting { get; set; }
        public bool ChangesInEating { get; set; }
        public bool SuicidalThoughts { get; set; }
        public bool Tired { get; set; }
        public bool CloseFriend { get; set; }
        public bool SocialMediaAddiction { get; set; }
        public bool WeightGain { get; set; }
        public bool MaterialPossession { get; set; }
        public bool Shy { get; set; }
        public bool StressfulMemories { get; set; }
        public bool Nightmares { get; set; }
        public bool AvoidingPeople { get; set; }
        public bool NegativeThoughts { get; set; }
        public bool TroublesInFocusing { get; set; }
        public bool BlamingYourself { get; set; }
    }
}
