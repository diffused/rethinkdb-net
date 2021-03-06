using System;
using System.ComponentModel;

namespace RethinkDb
{
    [ImmutableObject(true)]
    public interface ILogger
    {
        bool IsLoggingEnabled(LoggingCategory category);
        void Log(LoggingCategory category, string text);
    }
}

