using System;

namespace EventDelegate
{
    class Publisher
    {
        public event EventHandler<char> OnKeyPressed;

        public void Run ()
        {
            char symbol;

            while ((symbol = Console.ReadKey().KeyChar) != 'c')
            {
                OnKeyPressed?.Invoke(this, symbol);
            }
        }
    }
}