
namespace StackDataType.Interfaces
{
    public interface IStack<T>
    {
        int LastElementIndex { get; }

        void Push(T value);
        T Pop();
        bool IsEmpty();
        Stack<T> DeepCopy();
    }
}
