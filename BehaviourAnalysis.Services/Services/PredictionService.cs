using BehaviourAnalysis.Domain.Models;
using BehaviourAnalysis.Services.Interfaces;
using BehaviourAnalysisML.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourAnalysis.Services.Services
{
    public class PredictionService : IPredictionService
    {
        public string PredictDisorder(Questionnaire questionnaire)
        {
            ModelInput sampleData = new ModelInput()
            {
                Feeling_nervous = questionnaire.Nervous,
                Panic = questionnaire.Panic,
                Breathing_rapidly = questionnaire.BreathingRapidly,
                Sweating = questionnaire.Sweating,
                Trouble_in_concentration = questionnaire.TroublesInConcentration,
                Having_trouble_in_sleeping = questionnaire.TroublesInSleeping,
                Having_trouble_with_work = questionnaire.TroublesWithWork,
                Hopelessness = questionnaire.Hopeless,
                Anger = questionnaire.Angry,
                Over_react = questionnaire.OverReacting,
                Change_in_eating = questionnaire.ChangesInEating,
                Suicidal_thought = questionnaire.SuicidalThoughts,
                Feeling_tired = questionnaire.Tired,
                Close_friend = questionnaire.CloseFriend,
                Social_media_addiction = questionnaire.SocialMediaAddiction,
                Weight_gain = questionnaire.WeightGain,
                Material_possessions = questionnaire.MaterialPossession,
                Introvert = questionnaire.Shy,
                Popping_up_stressful_memory = questionnaire.StressfulMemories,
                Having_nightmares = questionnaire.Nightmares,
                Avoids_people_or_activities = questionnaire.AvoidingPeople,
                Feeling_negative = questionnaire.NegativeThoughts,
                Trouble_concentrating = questionnaire.TroublesInConcentration,
                Blamming_yourself = questionnaire.BlamingYourself
            };

            ModelOutput predictionResult = ConsumeModel.Predict(sampleData);
            return predictionResult.Prediction;
        }
    }
}
