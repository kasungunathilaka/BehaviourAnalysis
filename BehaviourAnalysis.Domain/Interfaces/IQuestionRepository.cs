using System.Collections.Generic;
using System.Threading.Tasks;

using BehaviourAnalysis.Domain.Models;

namespace BehaviourAnalysis.Domain.Interfaces
{
    public interface IQuestionRepository
    {
        Task<List<Question>> GetQuestions();
    }
}
