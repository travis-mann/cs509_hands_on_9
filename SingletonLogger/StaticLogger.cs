using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs509_hands_on_9.SingletonLogger
{
    public static class StaticLogger
    {
        public static void Log(ILogLevel LogLevel, string message)
        {
            Console.ForegroundColor = LogLevel.Color;
            Console.WriteLine($"{LogLevel.Name}: {message}");
            Console.ResetColor();
            LogLevel.AfterEffect();
        }
    }
}
