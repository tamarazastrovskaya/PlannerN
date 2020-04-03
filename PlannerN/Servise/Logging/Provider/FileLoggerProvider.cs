using Microsoft.Extensions.Logging;
using System;

namespace PlannerN.Services.Logging.Provider
{
    internal class FileLoggerProvider : ILoggerProvider
   
    {
        private string path;
       
        public FileLoggerProvider(string _path)
        {
            this.path = _path;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return FileLogger(path);
        }

        private ILogger FileLogger(string path)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {

        }
    }
}