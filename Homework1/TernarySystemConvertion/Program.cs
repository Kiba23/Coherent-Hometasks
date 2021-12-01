
namespace TernarySystemConvertion
{
    class Program
    {
        static void Main(string[] args)
        {
            // Entry of application
            Messages.HelloMessage();
            string[] inputs = Messages.InputMessage();

            // Parsing
            var a = ParseHelper.IntTryParse(inputs[0]);
            var b = ParseHelper.IntTryParse(inputs[1]);

            if (a <= b && a > 0 && b > 0)
            {
                Converter converter = new Converter();

                for (int i = a; i <= b; i++)
                {
                    if (converter.IsTernaryHasProperNumber(i))
                        Messages.ResultNumberOutput(i);
                }
            }
            else
            {
                Messages.WrongValuesOutput();
            }
        }
    }
}
