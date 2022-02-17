using StackDataType.Interfaces;

namespace StackDataType
{
    public static class IStackExtension
    {
        // This is in case you want to leave stack empty after this method, because Pop method deletes the values from original stack.
        public static IStack<T> Reverse<T>(this IStack<T> stack) 
        {
            IStack<T> newStack = new Stack<T>();

            while (!stack.IsEmpty())
            {
                newStack.Push(stack.Pop());
            }

            return newStack;
        }
    }
}
