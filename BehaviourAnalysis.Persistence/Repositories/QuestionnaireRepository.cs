using System.Threading.Tasks;

using BehaviourAnalysis.Domain.Interfaces;
using BehaviourAnalysis.Domain.Models;

namespace BehaviourAnalysis.Persistence.Repositories
{
    public class QuestionnaireRepository : IQuestionnaireRepository
    {
        private readonly DatabaseContext _context;

        public QuestionnaireRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<Questionnaire> SaveQuestionnaire(Questionnaire questionnaire)
        {
            await _context.Questionnaires.AddAsync(questionnaire);
            await _context.SaveChangesAsync();

            return questionnaire;
        }
    }
}
