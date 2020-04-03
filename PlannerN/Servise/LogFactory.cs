using Microsoft.Extensions.Logging;
using PlannerN.Services.Logging.Provider;
using System;

namespace PlannerN.Services
{
    static class LogFactory<T> 
    {
        public static Logger<T> CreateLog(IServiceProvider serviceProvider) =>
            (Logger<T>)LoggerFactory.Create(builder =>
            {
                builder 


                    .AddProvider(new FileLoggerProvider("log")); 
               
            }
            ).CreateLogger<T>();
    }
}
