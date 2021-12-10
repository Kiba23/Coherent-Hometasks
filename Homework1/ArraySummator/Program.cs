using System;

namespace ArraySummator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console hello message
            Console.WriteLine(Messages.Entry);

            // Logic part functions with list
            ListOperations listOperations = new ListOperations();
            var valuesFromUser = listOperations.GetListFromUser();
            var sum = listOperations.CalculateNeededSum(valuesFromUser);

            // Original list output
            Console.Write(Messages.OriginalListOutput + listOperations.IntListAsString(valuesFromUser));

            // Sum output
            Console.WriteLine(Messages.SumOutput + sum);
        }
    }
}
