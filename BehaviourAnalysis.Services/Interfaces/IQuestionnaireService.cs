using System.Threading.Tasks;

using BehaviourAnalysis.Domain.Models;

namespace BehaviourAnalysis.Services.Interfaces
{
    public interface IQuestionnaireService
    {
        Task<Questionnaire> SaveQuestionnaire(Questionnaire questionnaire);
    }
}
