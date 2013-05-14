using System;
using System.Linq;
using log4net;

namespace Logging
{
    class Log4NetExample
    {
        static void Main()
        {
            log4net.Config.BasicConfigurator.Configure();

            ILog log = log4net.LogManager.GetLogger(typeof(Log4NetExample));
            ILog debugLog = LogManager.GetLogger("Debug");
            ILog exceptionLog = LogManager.GetLogger("Exception");

            log.Debug("Bla bla bla ...Debug!");
            log.Info("How beautyful the console looks like");
            log.Warn("You are great you did this");
            log.Error("Pesho-Gosho Error");
            log.Fatal("sadi the great");

            debugLog.Info("Press key:");
            string input = Console.ReadLine();
            try
            {
                int n = int.Parse(input);
            }
            catch (Exception ex) 
            {
                exceptionLog.Error(ex.Message);
            }
        }
    }
}