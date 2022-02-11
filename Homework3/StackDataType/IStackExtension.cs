using StackDataType.Interfaces;

namespace StackDataType
{
    public static class IStackExtension
    {
        // This is in case you want to save data in initial stack.
        public static IStack<T> Reverse<T>(this IStack<T> stack) 
        {
            IStack<T> newStack = stack.DeepCopy();
            IStack<T> resultStack = new Stack<T>();

            for (int i = stack.LastElementIndex; i >= 0; i--)
            {
                resultStack.Push(newStack.Pop());
            }

            return resultStack;
        }
        // This is in case you want to leave stack empty after this method, because Pop method deletes the values from original stack.
        public static IStack<T> ReverseAndClearStack<T>(this IStack<T> stack) 
        {
            IStack<T> newStack = new Stack<T>();

            for (int i = stack.LastElementIndex; i >= 0; i--)
            {
                newStack.Push(stack.Pop());
            }

            return newStack;
        }
    }
}
