using System.ComponentModel.DataAnnotations;
using System.Net;
using System.Net.Http.Headers;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Options;

namespace FirstAZFunction
{
    class Employee
    {
        public string Name { get; set; }
    }
    public class Function1
    {
        private readonly ILogger _logger;

        public Function1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<Function1>();
            
            //Code to add console log provider.
            //var configureNamedOptions = new ConfigureNamedOptions<ConsoleLoggerOptions>("", null);
            //var optionsFactory = new OptionsFactory<ConsoleLoggerOptions>(new[] { configureNamedOptions }, Enumerable.Empty<IPostConfigureOptions<ConsoleLoggerOptions>>());
            //var optionsMonitor = new OptionsMonitor<ConsoleLoggerOptions>(optionsFactory, Enumerable.Empty<IOptionsChangeTokenSource<ConsoleLoggerOptions>>(), new OptionsCache<ConsoleLoggerOptions>());
            //loggerFactory.AddProvider(new ConsoleLoggerProvider(optionsMonitor));
        }
       
            

        [Function("Function3")]
        public async  Task<HttpResponseData> Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequestData req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            _logger.LogInformation("Niranjan");
            var response = req.CreateResponse();
            
            // response.Headers.Add("content-type","application/json");
            //throw new Exception("test exception");
            await response.WriteAsJsonAsync<Employee>(new Employee { Name = "Niranjan" }); //Wrting JSON
           //await response.WriteStringAsync("Welcome Niranjan on Azure Functions!"); //Writing string
           
            return response;
        }
    }
}
