using System.Linq;

namespace ISBN
{
    public class InputChecker
    {
        public bool IsStringCorrect(string inputStr)
        {
            if (inputStr.Length == 9 && inputStr.All(char.IsDigit))
                return true;

            return false;
        }
    }
}
