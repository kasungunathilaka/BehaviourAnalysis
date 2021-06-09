using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Extensions.Logging;

using BehaviourAnalysis.Domain.Models;
using BehaviourAnalysis.Services.Interfaces;

namespace BehaviourAnalysis.App.Functions
{
    public class CompleteQuestionnaire
    {
        private IQuestionnaireService _questionnaireService { get; set; }
        private IPredictionService _predictionService { get; set; }

        public CompleteQuestionnaire(IQuestionnaireService questionnaireService, IPredictionService predictionService)
        {
            _questionnaireService = questionnaireService;
            _predictionService = predictionService;
        }

        [FunctionName("CompleteQuestionnaire")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "questionnaire")] List<Question> questions, ILogger log)
        {
            try
            {
                log.LogInformation("Complete questionnaire function processed a request.");
                Questionnaire questionnaire = await _questionnaireService.SaveQuestionnaire(questions);
                string disorder = _predictionService.PredictDisorder(questionnaire);
                return new OkObjectResult(disorder);
            }
            catch (Exception ex)
            {
                log.LogError("An Exception occured while saving questionnaire.", ex);
                return new BadRequestObjectResult(ex);
            }
        }
    }
}
