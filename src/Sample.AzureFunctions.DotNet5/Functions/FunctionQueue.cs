﻿using Microsoft.Azure.WebJobs;
using Microsoft.Azure.Functions.Worker.Pipeline;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet5.Functions
{
    public class FunctionQueue
    {
        [FunctionName(nameof(FunctionQueue))]
        public static string Run([QueueTrigger("functionstesting2")] Book myQueueItem, FunctionExecutionContext context)
        {
            var logger = context.Logger;
            logger.LogInformation($"Book name = {myQueueItem.Name}");

            // Queue Output
            return "queue message";
        }
    }

    public class Book
    {
        public string Name { get; set; }

        public string Id { get; set; }
    }
}
