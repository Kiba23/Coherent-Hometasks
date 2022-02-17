
namespace StackDataType.Interfaces
{
    public interface IStack<T>
    {
        void Push(T value);
        T Pop();
        bool IsEmpty();
    }
}
