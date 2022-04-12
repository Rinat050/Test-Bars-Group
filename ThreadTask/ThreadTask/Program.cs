using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadTask
{
    class Program
    {
        static DummyRequestHandler handler = new DummyRequestHandler();

        static void Main(string[] args)
        { 
            string message;

            Console.WriteLine("Приложение запущено.");
            Console.WriteLine("Введите текст запроса для отправки. " +
                              "Для выхода введите /exit");

            while ((message = Console.ReadLine()) != "/exit")
            {
                Console.WriteLine($"Будет послано сообщение '{message}'");
                Console.WriteLine("Введите аргументы сообщения. " +
                                  "Если аргументы не нужны - введите /end");

                List<string> arguments = new List<string>();
                string argument;
                while ((argument = Console.ReadLine()) != "/end")
                {
                    arguments.Add(argument);
                    Console.WriteLine("Введите аргумент следующего сообщения. " +
                                      "Для окончания добавления аргументов введите /end");
                }

                var id = Guid.NewGuid().ToString("D");
                ThreadPool.QueueUserWorkItem(callBack => 
                           SendMessage(id, message, arguments.ToArray()));

                Console.WriteLine($"Было отправлено сообщение '{message}'. " +
                                  $"Присвоен идентификатор {id}");
                Console.WriteLine("Введите текст запроса для отправки. " +
                                  "Для выхода введите /exit");
            }
        }

        private static void SendMessage(string id, string message, string[] arguments)
        {
            try
            {
                var result = handler.HandleRequest(message,arguments);
                Console.WriteLine($"Сообщение с идентификатором {id} " +
                                  $"получило ответ - {result}");
            } 
            catch(Exception ex)
            {
                Console.WriteLine($"Сообщение с идентификатором {id} " +
                                  $"упало с ошибкой: {ex.Message}");
            }
        }
    }
}