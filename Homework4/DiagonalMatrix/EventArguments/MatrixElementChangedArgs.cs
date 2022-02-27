using System;

namespace DiagonalMatrix.EventArguments
{
    public class MatrixElementChangedArgs<T> : EventArgs
    {
        public int IndexI { get; } 
        public int IndexJ { get; } 
        public T OldValue { get; } 
        public T NewValue { get; }


        public MatrixElementChangedArgs(int indexI, int indexJ, T oldValue, T newValue)
        {
            IndexI = indexI;
            IndexJ = indexJ;
            OldValue = oldValue;
            NewValue = newValue;
        }
    }
}
