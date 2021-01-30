using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadComponents
{
    public static class LoggerDefines
    {
        private static readonly Action<ILogger, string, string, Exception> _headManagerTitle;

        static LoggerDefines()
        {
            _headManagerTitle = LoggerMessage.Define<string,string>(LogLevel.Information, 0, "Page title '{title}' set via property.Existing value was '{pageTitle}'");
        }

        public static void HeadManagerTitle(this ILogger logger, string title, string pageTitle)
        {
            _headManagerTitle(logger, title, pageTitle, null);
        }
    }
}
