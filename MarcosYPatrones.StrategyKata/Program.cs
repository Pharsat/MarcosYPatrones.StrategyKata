using System;

namespace MarcosYPatrones.StrategyKata
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Viking();
            bool continueExecution = true;

            do
            {
                Console.WriteLine("Press 1 for move walking or 2 for move flying.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        context.SetMoveBehavior(new Walk());
                        context.StartMoving();
                        break;

                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        context.SetMoveBehavior(new Fly());
                        context.StartMoving();
                        break;
                    default:
                        continueExecution = false;
                        break;
                }

            }
            while (continueExecution);
        }
    }
}
