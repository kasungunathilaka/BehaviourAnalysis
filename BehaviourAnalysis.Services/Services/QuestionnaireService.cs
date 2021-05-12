using System.Collections.Generic;
using System.Threading.Tasks;
using BehaviourAnalysis.Domain.Constants;
using BehaviourAnalysis.Domain.Interfaces;
using BehaviourAnalysis.Domain.Models;
using BehaviourAnalysis.Services.Interfaces;

namespace BehaviourAnalysis.Services.Services
{
    public class QuestionnaireService : IQuestionnaireService
    {
        private IQuestionnaireRepository _questionnaireRepository { get; set; }

        public QuestionnaireService(IQuestionnaireRepository questionnaireRepository)
        {
            _questionnaireRepository = questionnaireRepository;
        }

        public async Task<Questionnaire> SaveQuestionnaire(List<Question> questions)
        {
            Questionnaire questionnaire = new Questionnaire
            {
                Nervous = (int)questions.Find(q => q.QuestionId == (int)Questions.Nervous).Answer,
                Panic = (int)questions.Find(q => q.QuestionId == (int)Questions.Panic).Answer,
                BreathingRapidly = (int)questions.Find(q => q.QuestionId == (int)Questions.BreathingRapidly).Answer,
                Sweating = (int)questions.Find(q => q.QuestionId == (int)Questions.Sweating).Answer,
                TroublesInConcentration = (int)questions.Find(q => q.QuestionId == (int)Questions.TroublesInConcentration).Answer,
                TroublesInSleeping = (int)questions.Find(q => q.QuestionId == (int)Questions.TroublesInSleeping).Answer,
                TroublesWithWork = (int)questions.Find(q => q.QuestionId == (int)Questions.TroublesWithWork).Answer,
                Hopeless = (int)questions.Find(q => q.QuestionId == (int)Questions.Hopeless).Answer,
                Angry = (int)questions.Find(q => q.QuestionId == (int)Questions.Angry).Answer,
                OverReacting = (int)questions.Find(q => q.QuestionId == (int)Questions.OverReacting).Answer,
                ChangesInEating = (int)questions.Find(q => q.QuestionId == (int)Questions.ChangesInEating).Answer,
                SuicidalThoughts = (int)questions.Find(q => q.QuestionId == (int)Questions.SuicidalThoughts).Answer,
                Tired = (int)questions.Find(q => q.QuestionId == (int)Questions.Tired).Answer,
                CloseFriend = (int)questions.Find(q => q.QuestionId == (int)Questions.CloseFriend).Answer,
                SocialMediaAddiction = (int)questions.Find(q => q.QuestionId == (int)Questions.SocialMediaAddiction).Answer,
                WeightGain = (int)questions.Find(q => q.QuestionId == (int)Questions.WeightGain).Answer,
                MaterialPossession = (int)questions.Find(q => q.QuestionId == (int)Questions.MaterialPossession).Answer,
                Shy = (int)questions.Find(q => q.QuestionId == (int)Questions.Shy).Answer,
                StressfulMemories = (int)questions.Find(q => q.QuestionId == (int)Questions.StressfulMemories).Answer,
                Nightmares = (int)questions.Find(q => q.QuestionId == (int)Questions.Nightmares).Answer,
                AvoidingPeople = (int)questions.Find(q => q.QuestionId == (int)Questions.AvoidingPeople).Answer,
                NegativeThoughts = (int)questions.Find(q => q.QuestionId == (int)Questions.NegativeThoughts).Answer,
                TroublesInFocusing = (int)questions.Find(q => q.QuestionId == (int)Questions.TroublesInFocusing).Answer,
                BlamingYourself = (int)questions.Find(q => q.QuestionId == (int)Questions.BlamingYourself).Answer
            };
            return await _questionnaireRepository.SaveQuestionnaire(questionnaire);
        }
    }
}
