using System;

namespace TernarySystemConvertion
{
    public static class Messages
    {
        public static void HelloMessage()
        {
            Console.WriteLine("Hello. This is a Ternary Checker =) " +
                "\nEnter a two number range. ");
        }

        public static string[] InputMessage()
        {
            Console.WriteLine("\n\nFirst number: ");
            var inputFirst = Console.ReadLine();
            Console.WriteLine("Second number: ");
            var inputSecond = Console.ReadLine();

            return new string[] { inputFirst, inputSecond };
        }

        public static void ResultNumberOutput(int num)
        {
            Console.WriteLine($"\nNumber containing exactly two 2's in their ternary number is: {num}.");
        }

        public static void WrongValuesOutput()
        {
            Console.WriteLine("Enter a proper positive values.");
        }
    }
}
