
namespace ArraySummator
{
    public static class TypeConverter
    {
        public static int StrToInt(string str)
        {
            if (int.TryParse(str, out int result))
            {
                return result;
            }
            Messages.WrongInputMessage();
            return 0;
        }
    }
}
