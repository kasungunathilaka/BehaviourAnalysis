﻿
namespace BehaviourAnalysis.Domain.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public string QuestionBody { get; set; }
        public int? Answer { get; set; }
    }
}
