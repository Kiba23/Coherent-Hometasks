using System;

namespace TernarySystemConvertion
{
    public static class ParseHelper
    {
        public static int IntTryParse(string str)
        {
            return int.TryParse(str, out int result) ? result : throw new Exception("Convertion error.");
        }
    }
}
