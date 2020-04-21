using Microsoft.Extensions.Configuration;
using Serilog;
using System;

namespace LoggingApp.Log
{
    public class Logging
    {
        public readonly ILogger logger;

        public Logging(string categoryName)
        {
            var config = new ConfigurationBuilder()
                    .AddJsonFile("json1.json")
                    .Build();
            var computQueueName = config["ComputQueueName"];
            var outputQueueName = config["OutputQueueName"];
            var storageAccountName = config["StorageAccountName"];
            var storageAccountKey = config["StorageAccountKey"];
            var DataLakeUri = config["DataLakeUri"];
            var dataLakeDirectoryName = config["DataLakeDirectoryName"];

            Serilog.Log.Logger  = new LoggerConfiguration()
               .MinimumLevel.Debug()
               .WriteTo.Console()
               .WriteTo.File("logs\\myapp.txt", rollingInterval: RollingInterval.Day)
               .CreateLogger();
            logger = Serilog.Log.Logger;

        }
    }
}
