using System;

namespace DIP;

public class FileLogger : IFileLogger
{
    public void Log(string message)
    {
        System.Console.WriteLine($"Content log {message}");
    }
}
