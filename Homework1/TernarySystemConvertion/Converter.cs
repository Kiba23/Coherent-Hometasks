using System.Linq;

namespace TernarySystemConvertion
{
    public class Converter
    {
        public bool IsTernaryHasProperNumber(int number)
        {
            string result = "";
            while (number != 0)
            {
                // Main convertion algorithm
                int ternaryNum = number % 3;
                number /= 3;

                // Appending the values
                result += ternaryNum;
            }

            // Insert this line if you want to get proper ternary number, because it's shown in reverse.
            // However, we don't need this for checking numbers
            //result = new string(result.Reverse().ToArray());

            // Checking if number has two 2's
            return result.Where(a => a == '2').Count() == 2;
        }
    }
}
