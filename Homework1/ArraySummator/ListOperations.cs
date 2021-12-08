using System;
using System.Collections.Generic;
using System.Linq;

namespace ArraySummator
{
    public class ListOperations
    {
        public List<int> GetListFromUser()
        {
            int arrSize;
            int[] array;

            // Getting array size from user
            Console.WriteLine(Messages.InputArraySize);
            var arrSizeInput = Console.ReadLine();

            // Converting array size string to int
            arrSize = int.Parse(arrSizeInput);

            // Checking if array size input satisfies the condition
            if (arrSize < 2 || arrSize > 50)
            {
                Console.WriteLine(Messages.WrongInput);
                throw new Exception("Wrong input.");
            }

            // Asking each element of array from user
            array = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                Console.WriteLine((i + 1) + Messages.InputArrayNumber);
                array[i] = int.Parse(Console.ReadLine());
            }

            return array.ToList();
        }

        public int CalculateNeededSum(List<int> valuesFromUser)
        {
            int sum = 0;

            // In case values are empty
            if (valuesFromUser.Count == default || valuesFromUser == default)
            {
                throw new Exception("Values are empty.");
            }

            // Finding the index of the first max number
            int maxValue = valuesFromUser.Max();
            int maxIndex = valuesFromUser.LastIndexOf(maxValue); // LastIndexOf() - in order to get the most right max element

            // Finding the index of the first min number
            int minValue = valuesFromUser.Min();
            int minIndex = valuesFromUser.IndexOf(minValue);

            // In case min value stands before max value
            if (maxIndex > minIndex)
            {
                for (int i = minIndex; i <= maxIndex; i++)
                {
                    sum += valuesFromUser[i];
                }
            }
            // In case min value stands after max value
            else
            {
                for (int i = maxIndex; i <= minIndex; i++)
                {
                    sum += valuesFromUser[i];
                }
            }

            return sum;
        }

        public string DisplayList(List<int> valuesFromUser) // To output whole list inline
        {
            string originalArray = "";
            foreach (var element in valuesFromUser)
            {
                originalArray += element + " ";
            }
            return originalArray;
        }
    }
}
