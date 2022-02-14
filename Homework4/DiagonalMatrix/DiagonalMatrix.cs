using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagonalMatrix
{
    public class DiagonalMatrix<T>
    {
        private T[] DiagonalElements { get; }
        public readonly int Size;


        public DiagonalMatrix(int size, params T[] elements)
        {
            if (size <= 0 || elements.Length != size)
            {
                throw new ArgumentException("Size isn't appropriate.");
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
    }
}
