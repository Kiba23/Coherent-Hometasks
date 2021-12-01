using System;

namespace ISBN
{
    public class StringManage
    {
        public int StringAccumulator(string inputStr)
        {
            int sumOfNineDigits = 0;

            // Each digit checking and summing
            foreach (var digit in inputStr)
            {
                sumOfNineDigits += int.Parse(digit.ToString());
            }

            return sumOfNineDigits;
        }

        public int FindTheControlNum(int sumOfNineDigits)
        {
            // Iterating through 10 numbers to find the divisible of 11.
            // The closest divisibles could be only in range of 10 numbers (from 81 - sum of
            // maximum possible number of user's input)
            for (int i = 0; i <= 10; i++)
            {
                if ((sumOfNineDigits + i) % 11 == 0)
                    return i;
            }
            throw new Exception("Out of 10"); // just in case
        }
    }
}
