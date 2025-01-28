using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Contoso.FakeCheck
{
    public class SchufaScore
    {
        private readonly ILogger<SchufaScore> _logger;

        public SchufaScore(ILogger<SchufaScore> logger)
        {
            _logger = logger;
        }

        [Function("SchufaScore")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
