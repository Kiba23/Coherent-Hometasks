
namespace ArraySummator
{
    public static class InputChecker
    {
        public static void NumOfElementsCheck(int number)
        {
            if (number < 2 || number > 50)
            {
                Messages.WrongInputMessage();
            }
        }
    }
}
