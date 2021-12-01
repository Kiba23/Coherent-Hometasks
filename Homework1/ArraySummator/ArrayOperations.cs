using System;
using System.Linq;

namespace ArraySummator
{
    public class ArrayOperations
    {
        private int ArrSize;
        private int[] Array;
        private int Sum = 0;

        public void GetArrayFromUser()
        {
            // Getting array size from user
            var arrSizeInput = Messages.InputArrSizeFromUser();

            // Converting array size string to int
            ArrSize = TypeConverter.StrToInt(arrSizeInput);

            // Checking if array size input satisfies the condition
            InputChecker.NumOfElementsCheck(ArrSize);

            // Asking each element of array from user
            Array = new int[ArrSize];
            for (int i = 0; i < ArrSize; i++)
            {
                Array[i] = Messages.InputArrNumberFromUser(i);
            }
        }

        public void CalculateNeededSum()
        {
            // In case values are empty
            if (ArrSize == default || Array == default)
                throw new Exception("Values are empty.");

            // Finding the index of the first max number
            int maxValue = Array.Max();
            int maxIndex = Array.ToList().IndexOf(maxValue);

            // Finding the index of the first min number
            int minValue = Array.Min();
            int minIndex = Array.ToList().IndexOf(minValue);

            // In case min value stands before max value
            if (maxIndex > minIndex)
            {
                for (int i = minIndex; i <= maxIndex; i++)
                {
                    Sum += Array[i];
                }
            }
            // In case min value stands after max value
            else
            {
                for (int i = maxIndex; i <= minIndex; i++)
                {
                    Sum += Array[i];
                }
            }
        }

        public int GetSum() { return Sum; } // Encapsulation

        public override string ToString() // To output whole array inline
        {
            string originalArray = "";
            foreach (var element in Array)
            {
                originalArray += element + " ";
            }
            return originalArray;
        }
    }
}
