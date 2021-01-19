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
            Questionnaire questionnaire = new Questionnaire {
                Nervous = (bool)questions.Find(q => q.QuestionId == (int)Questions.Nervous).Answer,
                Panic = (bool)questions.Find(q => q.QuestionId == (int)Questions.Panic).Answer,
                BreathingRapidly = (bool)questions.Find(q => q.QuestionId == (int)Questions.BreathingRapidly).Answer,
                Sweating = (bool)questions.Find(q => q.QuestionId == (int)Questions.Sweating).Answer,
                TroublesInConcentration = (bool)questions.Find(q => q.QuestionId == (int)Questions.TroublesInConcentration).Answer,
                TroublesInSleeping = (bool)questions.Find(q => q.QuestionId == (int)Questions.TroublesInSleeping).Answer,
                TroublesWithWork = (bool)questions.Find(q => q.QuestionId == (int)Questions.TroublesWithWork).Answer,
                Hopeless = (bool)questions.Find(q => q.QuestionId == (int)Questions.Hopeless).Answer,
                Angry = (bool)questions.Find(q => q.QuestionId == (int)Questions.Angry).Answer,
                OverReacting = (bool)questions.Find(q => q.QuestionId == (int)Questions.OverReacting).Answer,
                ChangesInEating = (bool)questions.Find(q => q.QuestionId == (int)Questions.ChangesInEating).Answer,
                SuicidalThoughts = (bool)questions.Find(q => q.QuestionId == (int)Questions.SuicidalThoughts).Answer,
                Tired = (bool)questions.Find(q => q.QuestionId == (int)Questions.Tired).Answer,
                CloseFriend = (bool)questions.Find(q => q.QuestionId == (int)Questions.CloseFriend).Answer,
                SocialMediaAddiction = (bool)questions.Find(q => q.QuestionId == (int)Questions.SocialMediaAddiction).Answer,
                WeightGain = (bool)questions.Find(q => q.QuestionId == (int)Questions.WeightGain).Answer,
                MaterialPossession = (bool)questions.Find(q => q.QuestionId == (int)Questions.MaterialPossession).Answer,
                Shy = (bool)questions.Find(q => q.QuestionId == (int)Questions.Shy).Answer,
                StressfulMemories = (bool)questions.Find(q => q.QuestionId == (int)Questions.StressfulMemories).Answer,
                Nightmares = (bool)questions.Find(q => q.QuestionId == (int)Questions.Nightmares).Answer,
                AvoidingPeople = (bool)questions.Find(q => q.QuestionId == (int)Questions.AvoidingPeople).Answer,
                NegativeThoughts = (bool)questions.Find(q => q.QuestionId == (int)Questions.NegativeThoughts).Answer,
                TroublesInFocusing = (bool)questions.Find(q => q.QuestionId == (int)Questions.TroublesInFocusing).Answer,
                BlamingYourself = (bool)questions.Find(q => q.QuestionId == (int)Questions.BlamingYourself).Answer
            };
            return await _questionnaireRepository.SaveQuestionnaire(questionnaire);
        }
    }
}
