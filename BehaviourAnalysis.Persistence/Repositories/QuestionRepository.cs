using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

using BehaviourAnalysis.Domain.Interfaces;
using BehaviourAnalysis.Domain.Models;

namespace BehaviourAnalysis.Persistence.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        private readonly DatabaseContext _context;

        public QuestionRepository(DatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<Question>> GetQuestions()
        {
            return await _context.Questions
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
