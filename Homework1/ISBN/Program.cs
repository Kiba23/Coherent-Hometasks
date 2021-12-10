using System;
using System.Linq;

namespace ISBN
{
    class Program
    {
        private const int MaxInputDigits = 9;

        static void Main(string[] args)
        {
            // Entry messages
            Console.WriteLine($"Hello. This is an ISBN calculator =) \nEnter a {MaxInputDigits} digit string. ");
            Console.WriteLine("\n\nNumbers: ");
            var inputStr = Console.ReadLine();

            if (inputStr.Length == MaxInputDigits && inputStr.All(char.IsDigit))
            {
                int valueAfterExpression = 0;
                int iterations = 0;

                // Calculating the expression, multiplying each input digit by sequence[10..1]
                for (int i = 10; i > 1; i--)
                {
                    valueAfterExpression += i * int.Parse(inputStr[iterations].ToString());
                    iterations++;
                }

                // Calculating value needed to get Control Number
                int valueToAdd = 0;
                while ((valueAfterExpression + valueToAdd) % 11 != 0)
                {
                    valueToAdd++;
                }

                // Checking if control number equals 10 to write 'X' instead. And printing the message
                Console.WriteLine($"ISBN number is - {inputStr}{(valueToAdd == 10 ? "X" : valueToAdd)}.\n");
            }
            else
            {
                Console.WriteLine("Wrong string format. Try again.");
                throw new Exception("Wrong string.");
            }
        }
    }
}
