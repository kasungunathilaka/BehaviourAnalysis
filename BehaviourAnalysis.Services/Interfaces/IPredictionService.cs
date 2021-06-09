using BehaviourAnalysis.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BehaviourAnalysis.Services.Interfaces
{
    public interface IPredictionService
    {
        string PredictDisorder(Questionnaire questionnaire);
    }
}
