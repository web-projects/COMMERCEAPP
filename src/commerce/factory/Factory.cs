using System;
using System.Collections.Generic;
using System.Text;
using WPA.CommerceApp.core;
using WPA.CommerceApp.Helpers;
using WPA.CommerceApp.Interfaces;

namespace WPA.CommerceApp.factory
{
    public static class Factory
    {
        public static ILogger CreateLogger()
        {
            return new Logger();
        }
    }
}
