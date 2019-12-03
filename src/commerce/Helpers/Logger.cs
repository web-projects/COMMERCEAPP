using System;
using System.Collections.Generic;
using System.Text;
using WPA.CommerceApp.Interfaces;

namespace WPA.CommerceApp.Helpers
{
    public class Logger : ILogger
    {
        public void Log(string message)
        {
            //                                          0123456789012345678:
            Console.WriteLine($"{DateTime.Now.ToString("yyyyMMdd-HHmmss.fff")}: {message}");
        }
    }
}
