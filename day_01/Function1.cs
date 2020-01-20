using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace day_01
{
    public static class Function1
    {
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("Day 01 of '25 Days of Serverless'");

            string[] dreidel = { "Nun","Gimmel","Hay","Shin" };
            Random random = new Random();
            var item = random.Next(0, dreidel.Length);

            return (ActionResult)new OkObjectResult(dreidel[item]);
        }
    }
}
