using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRsoft.Store.UI.Infra
{
    public class SeriLogFile : ILogCustom
    {
        private readonly Logger _logger;

        public SeriLogFile()
        {
            _logger = new LoggerConfiguration().WriteTo.File($"logs/{DateTime.Now.Year}/{DateTime.Now.Month}.txt").CreateLogger();
        }

        public void Error(string msg)
        {
            throw new NotImplementedException();
        }

        public void Info(string msg)
        {
            throw new NotImplementedException();
        }

        public void Warning(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
