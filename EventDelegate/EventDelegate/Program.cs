using System;

namespace EventDelegate
{
    class Program
    {
        static void Main(string[] args)
        {
            var publisher = new Publisher();

            publisher.OnKeyPressed += ShowInfo;

            publisher.Run();
        }

        static void ShowInfo(object sender, char symbol)
        {
            Console.WriteLine($"\nSymbol - {symbol}");
        }
    }
}