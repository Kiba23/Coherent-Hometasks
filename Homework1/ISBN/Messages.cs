using System;

namespace ISBN
{
    public static class Messages
    {
        public static void HelloMessage()
        {
            Console.WriteLine("Hello. This is an ISBN calculator =) " +
                "\nEnter a nine digit string. ");
        }

        public static string InputMessage()
        {
            Console.WriteLine("\n\nNumbers: ");
            var inputStr = Console.ReadLine();

            return inputStr;
        }

        public static void WrongInputMessage()
        {
            Console.WriteLine("Wrong string format. Try again.");
            throw new Exception("Wrong string.");
        }

        public static void SuccessMessage(string inputStr, int controlNum)
        {
            // Checking if control number equals 10 to write 'X' instead. And printing the message
            Console.WriteLine($"ISBN number is - {inputStr}{(controlNum == 10 ? "X" : controlNum)}.\n");
        }
    }
}
