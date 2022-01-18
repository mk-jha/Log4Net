using log4net;
using log4net.Config;
using System;
using System.IO;
using System.Reflection;

namespace Log4NetDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initiating logger repository attributtes.
            // This line we can write in any common utility for e.g. Loghelper.cs, so we do not need to create everytime  
            var loggerRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());

            // Getting configuration info from log4net.config file 
            // This line we can write in any common utility for e.g. Loghelper.cs so we do not need to create everytime 
            XmlConfigurator.Configure(loggerRepository, new FileInfo("log4net.config"));

            // Creating logger object here 
            var logger = LogManager.GetLogger(typeof(Program));
            logger.Info("Logging Info!");
            logger.Warn("Logging Warning!");
            logger.Error("Logging Error!");
            logger.Fatal("Logging Fatal error!");
            
        }
    }
}
