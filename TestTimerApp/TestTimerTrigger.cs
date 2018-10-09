using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace TestTimerApp
{
    public static class TestTimerTrigger
    {
        [FunctionName("TestTimer")]
        public static void Run([TimerTrigger("0 */5 * * * *")]TimerInfo myTimer, ILogger log)
        {
            Console.WriteLine($"Successfully logged at {DateTime.Now}");
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}