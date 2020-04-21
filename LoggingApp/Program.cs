using System;

namespace LoggingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //LoggingApp.Log.Logging logging = new Log.Logging("EngineWarpper.Program");
            Engine.ComputeOutput();            
            
            Console.WriteLine("Hello World!");
            //logging.logger.Debug("Hello World!");
        }
    }
}
