
namespace ISBN
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entry messages
            Messages.HelloMessage();
            var inputStr = Messages.InputMessage();

            // Initializing the objects
            InputChecker inputChecker = new InputChecker();
            StringManage stringManage = new StringManage();

            if (inputChecker.IsStringCorrect(inputStr))
            {
                int sumOfNineDigits = stringManage.StringAccumulator(inputStr);
                int controlNum = stringManage.FindTheControlNum(sumOfNineDigits);

                Messages.SuccessMessage(inputStr, controlNum);
            }
            else
            {
                Messages.WrongInputMessage();
            }
        }
    }
}
