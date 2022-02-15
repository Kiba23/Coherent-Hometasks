using System;

namespace DiagonalMatrix
{
    public class DiagonalMatrix<T>
    {
        private T[] DiagonalElements { get; }
        public readonly int Size;


        public DiagonalMatrix(params T[] elements)
        {
            if (elements.Length <= 0)
            {
                throw new ArgumentException("Enter the proper amount of values.");
            }

            DiagonalElements = elements;
            Size = elements.Length;
        }

        public T this[int i, int j]
        {
            get
            {
                IsIndexerInputCorrect(i, j);

                if (i != j)
                {
                    return default(T);
                }
                return DiagonalElements[i];
            }
            set
            {
                IsIndexerInputCorrect(i, j);

                if (i != j)
                {
                    return;
                }
                DiagonalElements[i] = value;
            }
        }

        private bool IsIndexerInputCorrect(int i, int j)
        {
            if (i < 0 || j < 0 || i >= Size || j >= Size)
            {
                throw new IndexOutOfRangeException("Incorrect index.");
            }
            return true;
        }

        public override string ToString()
        {
            string result = "";
            foreach (var item in DiagonalElements)
            {
                result += item + " ";
            }
            return result;
        }
    }
}
