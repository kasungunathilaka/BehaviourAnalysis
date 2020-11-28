using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using BehaviourAnalysis.Services.Interfaces;

namespace BehaviourAnalysis.App.Functions
{
    public class GetQuestions
    {
        private IQuestionService _questionService { get; set; }

        public GetQuestions(IQuestionService questionService)
        {
            _questionService = questionService;
        }

        [FunctionName("GetQuestions")]
        public async Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "get", Route = "questions")] HttpRequest req, ILogger log)
        {
            try
            {
                log.LogInformation("Get questions function processed a request.");

                return new OkObjectResult(await _questionService.GetQuestions());
            }
            catch (Exception ex)
            {
                return new BadRequestObjectResult(ex);
            }
        }
    }
}
