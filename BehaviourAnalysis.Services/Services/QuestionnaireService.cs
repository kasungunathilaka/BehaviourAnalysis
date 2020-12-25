using System.Threading.Tasks;

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

        public async Task<Questionnaire> SaveQuestionnaire(Questionnaire questionnaire)
        {
            return await _questionnaireRepository.SaveQuestionnaire(questionnaire);
        }
    }
}
