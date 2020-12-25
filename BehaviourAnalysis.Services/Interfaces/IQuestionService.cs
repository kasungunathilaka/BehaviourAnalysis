using System.Collections.Generic;
using System.Threading.Tasks;

using BehaviourAnalysis.Domain.Models;

namespace BehaviourAnalysis.Services.Interfaces
{
    public interface IQuestionService
    {
        Task<List<Question>> GetQuestions();
    }
}
