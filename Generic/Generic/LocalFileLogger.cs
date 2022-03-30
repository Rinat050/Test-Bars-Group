using System;
using System.IO;

namespace Generic
{
    class LocalFileLogger<T> : ILogger
    {
        string filePath;

        public LocalFileLogger(string path)
        {
            filePath = path;
        }

        public void LogInfo(string message)
        {
            File.AppendAllText(filePath, $"[Info]: [{typeof(T).Name}] : {message}\n");
        }

        public void LogWarning(string message)
        {
            File.AppendAllText(filePath, $"[Warning] : [{typeof(T).Name}] : {message}\n");
        }

        public void LogError(string message, Exception ex)
        {
            File.AppendAllText(filePath, $"[Error] : [{typeof(T).Name}] : {message}. {ex.Message}\n");
        }
    }
}