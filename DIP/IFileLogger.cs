using System;

namespace DIP;

public interface IFileLogger
{
    /// <summary>
    /// To write logs
    /// </summary>
    /// <param name="message"></param>
    void Log(string message);
}
