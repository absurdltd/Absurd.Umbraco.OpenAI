using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using OpenAI_API;
using System.Threading.Tasks;
using Umbraco.Cms.Web.BackOffice.Controllers;
using Umbraco.Cms.Web.Common.Attributes;

namespace AbsurdOpenAI.Controllers
{
    [PluginController("OpenAI")]
    public class CompletionController : UmbracoAuthorizedApiController
    {
        private readonly OpenAIAPI _client;

        public CompletionController(IConfiguration configuration)
        {
            var apiKey = configuration.GetValue<string>("OpenAI:ApiKey");
            _client = new OpenAIAPI(apiKey, Engine.Davinci);
        }
        [HttpGet]
        public async Task<IActionResult> GetText(string text)
        {
            var request = new CompletionRequest(text)
            {
                MaxTokens = 256,
                Temperature = 0.7,
                TopP = 1,
                FrequencyPenalty = 0,
                PresencePenalty = 0
            };
            var completion = await _client.Completions.CreateCompletionAsync(request);

            return new JsonResult(completion.ToString());
        }
    }
}
