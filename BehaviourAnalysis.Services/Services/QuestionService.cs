using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using BehaviourAnalysis.Domain.Interfaces;
using BehaviourAnalysis.Domain.Models;
using BehaviourAnalysis.Services.Interfaces;

namespace BehaviourAnalysis.Services.Services
{
    public class QuestionService : IQuestionService
    {
        private IQuestionRepository _questionRepository { get; set; }

        public QuestionService(IQuestionRepository questionRepository)
        {
            _questionRepository = questionRepository;
        }

        public async Task<List<Question>> GetQuestions()
        {
            return await _questionRepository.GetQuestions();
        }
    }
}
