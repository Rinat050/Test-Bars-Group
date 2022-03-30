using System;

namespace Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            LocalFileLogger<int> firstLogger = new LocalFileLogger<int>("C:/Users/Пользователь/Рабочий стол/test.txt");

            firstLogger.LogInfo("info firstLogger");
            firstLogger.LogError("error firstLogger", new NullReferenceException());
            firstLogger.LogWarning("warning firstLogger");

            LocalFileLogger<string> secondLogger = new LocalFileLogger<string>("C:/Users/Пользователь/Рабочий стол/test2.txt");

            secondLogger.LogInfo("info secondLogger");
            secondLogger.LogError("error secondLogger", new StackOverflowException());
            secondLogger.LogWarning("warning secondLogger");
        }
    }
}