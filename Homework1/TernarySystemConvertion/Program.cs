using System;

namespace TernarySystemConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entry of application
            Console.WriteLine(Messages.Entry);
            Console.WriteLine(Messages.AskFirstNumber);
            var inputFirst = Console.ReadLine();
            Console.WriteLine(Messages.AskSecondNumber);
            var inputSecond = Console.ReadLine();

            // Parsing
            var a = int.Parse(inputFirst);
            var b = int.Parse(inputSecond);

            if (a <= b && a > 0 && b > 0)
            {
                Converter converter = new Converter();

                for (int i = a; i <= b; i++)
                {
                    if (converter.IsTernaryHasProperNumber(i))
                    {
                        Console.WriteLine(Messages.ResultNumberOutput + i);
                    }
                }
            }
            else
            {
                Console.WriteLine(Messages.WrongValuesOutput);
            }
        }
    }
}
