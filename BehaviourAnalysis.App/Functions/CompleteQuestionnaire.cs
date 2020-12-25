using System;
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

        public CompleteQuestionnaire(IQuestionnaireService questionnaireService)
        {
            _questionnaireService = questionnaireService;
        }

        [FunctionName("CompleteQuestionnaire")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "post", Route = "questionnaire")] Questionnaire request, ILogger log)
        {
            try
            {
                log.LogInformation("Complete questionnaire function processed a request.");
                var questionnaire = await _questionnaireService.SaveQuestionnaire(request);
                return new CreatedResult("CompleteQuestionnaire", questionnaire);
            }
            catch (Exception ex)
            {
                log.LogError("An Exception occured while saving questionnaire.", ex);
                return new BadRequestObjectResult(ex);
            }
        }
    }
}
