using StackDataType.Interfaces;
using System;

namespace StackDataType
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IntStack
            IStack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(3);
            stack.Push(15);
            stack.Push(66);
            stack.Push(13);
            stack.Push(3);

            stack.Pop();
            stack.Pop();
            stack.Pop();

            stack.Push(16);
            stack.Push(17);
            stack.Push(18);
            stack.Push(19);

            Console.WriteLine($"Initial Stack Data: {stack}");
            Console.WriteLine($"Stack Data after reverse: {stack.Reverse()}");
            Console.WriteLine($"Is stack empty? : {stack.IsEmpty()}\n");
            #endregion

            #region DoubleStack
            IStack<double> doubleStack = new Stack<double>();
            doubleStack.Push(3.1415);
            doubleStack.Push(5.5);
            doubleStack.Push(78.8);

            doubleStack.Pop();

            doubleStack.Push(13.35654343);

            Console.WriteLine($"Initial Stack Data: {doubleStack}");
            Console.WriteLine($"Stack Data after reverse and after clear : {doubleStack.ReverseAndClearStack()}, isEmpty? - {doubleStack.IsEmpty()}");
            #endregion
        }
    }
}
