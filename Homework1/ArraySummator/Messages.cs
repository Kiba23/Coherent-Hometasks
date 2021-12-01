using System;

namespace ArraySummator
{
    public static class Messages
    {
        public static void EntryMessage()
        {
            Console.WriteLine("Hello. This is a Array Summator =)\n");
        }

        public static string InputArrSizeFromUser()
        {
            Console.WriteLine("Enter desired number of elemenents in array (min-2): ");
            var arrSize = Console.ReadLine();

            return arrSize;
        }

        public static int InputArrNumberFromUser(int index)
        {
            Console.WriteLine($"Please enter a {index + 1} number of array: ");
            var number = Console.ReadLine();

            return TypeConverter.StrToInt(number);
        }

        public static void OriginalArrayMessage(ArrayOperations array)
        {
            Console.Write("\nOriginal array is: " + array);
        }

        public static void SumOfArrayMessage(ArrayOperations array)
        {
            Console.WriteLine("\nThe sum of the array elements located between the smallest " +
                "element and the largest element is: " + array.GetSum());
        }

        public static void WrongInputMessage()
        {
            Console.WriteLine("Wrong input. Please try again.");
            throw new Exception("Wrong input.");
        }
    }
}
