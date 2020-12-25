using System.Threading.Tasks;

using BehaviourAnalysis.Domain.Models;

namespace BehaviourAnalysis.Domain.Interfaces
{
    public interface IQuestionnaireRepository
    {
        Task<Questionnaire> SaveQuestionnaire(Questionnaire questionnaire);
    }
}
