using StackDataType.Interfaces;
using System;

namespace StackDataType
{
    public class Stack<T> : IStack<T>
    {
        public const int MAX_STACK_SIZE = 10;

        public int LastElementIndex { get; private set; } = -1; // -1 because of first value in array should be at index 0.
        T[] Data = new T[MAX_STACK_SIZE];


        public void Push(T value)
        {
            if (LastElementIndex + 1 >= MAX_STACK_SIZE)
            {
                throw new Exception("Stack is full.");
            }

            LastElementIndex++;
            Data[LastElementIndex] = value;
        }
        public T Pop()
        {
            if (LastElementIndex < 0)
            {
                throw new Exception("Stack is empty.");
            }

            var popValue = Data[LastElementIndex];
            Data[LastElementIndex] = default(T); // Zeroing the value.
            LastElementIndex--;
            return popValue;
        }
        public bool IsEmpty()
        {
            return LastElementIndex < 0 ? true : false;
        }
        public Stack<T> DeepCopy()
        {
            var newStack = new Stack<T>();
            for (int i = 0; i < MAX_STACK_SIZE; i++)
            {
                newStack.Data[i] = this.Data[i];
            }
            newStack.LastElementIndex = this.LastElementIndex;

            return newStack;
        }
        public override string ToString()
        {
            string arr = "";
            foreach (var item in Data)
            {
                arr += item + " ";
            }
            return arr;
        }
    }
}
