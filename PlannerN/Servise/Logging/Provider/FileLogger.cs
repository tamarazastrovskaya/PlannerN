using Microsoft.Build.Framework;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace PlannerN.Services.Logging.Provider
{
    internal class FileLogger : Microsoft.Build.Framework.ILogger 
    {
        private string filepath;
        private static object _loc = new object();

        public Microsoft.Build.Framework.LoggerVerbosity Verbosity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Parameters { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        
        public FileLogger(string path) 
        {
            filepath = path;
        }

        public IDisposable BeginScope<TState>(TState state)
        {
            throw new NotImplementedException();
        }

        public bool IsEnabled(Microsoft.Extensions.Logging.LogLevel logLevel)
        {
            return true;
        }

        public void Log<TState>( 
            Microsoft.Extensions.Logging.LogLevel logLevel,
            EventId eventId,
            TState state,
            Exception exception,
            Func<TState, Exception, string> formatte
            )
        {
            if (formatte != null)
            {
                lock (_loc)
                {
                    File.AppendAllText(
                        filepath, formatte(state, exception) + Environment.NewLine
                       
                        );
                }
            }
        }

        public void Initialize(Microsoft.Build.Framework.IEventSource eventSource)
        {
            throw new NotImplementedException();
        }

        public void Shutdown()
        {
            throw new NotImplementedException();
        }
    }
}