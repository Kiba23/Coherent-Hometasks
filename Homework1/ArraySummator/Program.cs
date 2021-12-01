
namespace ArraySummator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console hello message
            Messages.EntryMessage();

            // Logic part functions with array
            ArrayOperations arrayOperations = new ArrayOperations();
            arrayOperations.GetArrayFromUser();
            arrayOperations.CalculateNeededSum();

            // Original array output
            Messages.OriginalArrayMessage(arrayOperations);

            // Sum output
            Messages.SumOfArrayMessage(arrayOperations);
        }
    }
}
