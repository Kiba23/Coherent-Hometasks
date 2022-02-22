using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SparseMatrixOperations.Entities
{
    public class SparseMatrix : IEnumerable<int>
    {
        private Dictionary<(int Column, int Row), int> MatrixElements = new Dictionary<(int, int), int>();
        private (int Columns, int Rows) Size;


        public SparseMatrix(int columns, int rows)
        {
            if (columns > 0 && rows > 0)
            {
                Size = (columns, rows);
            }
            else
            {
                throw new ArgumentException("Size of matrix isn't appropriate.");
            }
        }

        public int this[int col, int row]
        {
            get
            {
                InputDimensionCheck(col, row);

                if (IsZeroElement(col, row)) // case when there is no element in such indexes, so the value is zero
                {
                    return default(int);
                }

                var elementIndex = (col, row);
                return MatrixElements.First(e => e.Key.Equals(elementIndex)).Value; // returning the value at corresponding indexes
            }
            set
            {
                InputDimensionCheck(col, row);

                var elementIndex = (col, row);
                MatrixElements.Add(elementIndex, value);
            }
        }

        private bool InputDimensionCheck(int col, int row)
        {
            if (col >= 0 && col < Size.Columns && row >= 0 && row < Size.Rows)
            {
                return true;
            }
            else
            {
                throw new ArgumentException("Input dimension isn't correct.");
            }
        }

        public int GetCount(int x)
        {
            if (x == 0)
            {
                return Size.Columns * Size.Rows - MatrixElements.Values.Count;
            }

            return MatrixElements.Values.Where(v => v == x).Count();
        }

        public IEnumerable<(int, int, int)> GetNotZeroElements()
        {
            for (int i = 0; i < Size.Columns; i++)
            {
                for (int j = 0; j < Size.Rows; j++)
                {
                    if (!IsZeroElement(i, j))
                    {
                        yield return (i, j, this[i, j]);
                    }
                }
            }
        }

        private bool IsZeroElement(int col, int row)
        {
            var elementIndex = (col, row);
            if (MatrixElements.Any(e => e.Key.Equals(elementIndex))) // case when there is no element in such indexes, so the value is zero
            {
                return false;
            }
            return true;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < Size.Columns; i++) 
            {
                for (int j = 0; j < Size.Rows; j++)
                {
                    yield return this[i, j];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            for (int i = 0; i < Size.Columns; i++)
            {
                for (int j = 0; j < Size.Rows; j++)
                {
                    yield return this[i, j].ToString();
                }
            }
        }

        public override string ToString()
        {
            string result = "\n";
            foreach (var item in MatrixElements)
            {
                result += "Element at " + item.Key.Column + "," + item.Key.Row + " is " + item.Value + "\n";
            }
            return result + "of the matrix size - " + Size.Columns + "x" + Size.Rows;
        }
    }
}
