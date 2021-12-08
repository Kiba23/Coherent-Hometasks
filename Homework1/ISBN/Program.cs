using System;
using System.Linq;

namespace ISBN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entry messages
            Console.WriteLine("Hello. This is an ISBN calculator =) \nEnter a nine digit string. ");
            Console.WriteLine("\n\nNumbers: ");
            var inputStr = Console.ReadLine();

            if (inputStr.Length == 9 && inputStr.All(char.IsDigit))
            {
                int sumOfNineDigits = 0;

                // Each digit checking and summing
                foreach (var digit in inputStr)
                {
                    sumOfNineDigits += int.Parse(digit.ToString());
                }

                int controlNum = 0;

                // Iterating through 10 numbers to find the divisible of 11.
                // The closest divisibles could be only in range of 10 numbers (from 81 - sum of
                // maximum possible number of user's input)
                for (int i = 0; i <= 10; i++)
                {
                    if ((sumOfNineDigits + i) % 11 == 0)
                    {
                        controlNum = i;
                        break;
                    }
                }

                // Checking if control number equals 10 to write 'X' instead. And printing the message
                Console.WriteLine($"ISBN number is - {inputStr}{(controlNum == 10 ? "X" : controlNum)}.\n");
            }
            else
            {
                Console.WriteLine("Wrong string format. Try again.");
                throw new Exception("Wrong string.");
            }
        }
    }
}
