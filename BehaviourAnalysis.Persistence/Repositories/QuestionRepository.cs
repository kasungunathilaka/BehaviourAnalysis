using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using BehaviourAnalysis.Domain.Interfaces;
using BehaviourAnalysis.Domain.Models;
using Microsoft.EntityFrameworkCore;

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
