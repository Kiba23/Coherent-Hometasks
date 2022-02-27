using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace SparseMatrixOperations.Entities
{
    public class SparseMatrix : IEnumerable<int>
    {
        private Dictionary<(int Column, int Row), int> matrixElements = new Dictionary<(int, int), int>();
        private (int Columns, int Rows) size;


        public SparseMatrix(int columns, int rows)
        {
            if (columns > 0 && rows > 0)
            {
                size = (columns, rows);
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
                return matrixElements[elementIndex]; // returning the value at corresponding indexes
            }
            set
            {
                InputDimensionCheck(col, row);

                var elementIndex = (col, row);
                if (value != 0 && matrixElements.ContainsKey(elementIndex))
                {
                    matrixElements[elementIndex] = value;
                }
                else if (value != 0)
                {
                    matrixElements.Add(elementIndex, value);
                }
            }
        }

        private bool InputDimensionCheck(int col, int row)
        {
            if (col >= 0 && col < size.Columns && row >= 0 && row < size.Rows)
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
                return size.Columns * size.Rows - matrixElements.Values.Count;
            }

            return matrixElements.Values.Where(v => v == x).Count();
        }

        public IEnumerable<(int, int, int)> GetNotZeroElements()
        {
            for (int i = 0; i < size.Columns; i++)
            {
                for (int j = 0; j < size.Rows; j++)
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
            if (matrixElements.Any(e => e.Key.Equals(elementIndex))) // case when there is no element in such indexes, so the value is zero
            {
                return false;
            }
            return true;
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < size.Columns; i++) 
            {
                for (int j = 0; j < size.Rows; j++)
                {
                    yield return this[i, j];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            string result = "\n";
            foreach (var item in matrixElements)
            {
                result += "Element at " + item.Key.Column + "," + item.Key.Row + " is " + item.Value + "\n";
            }
            return result + "of the matrix size - " + size.Columns + "x" + size.Rows;
        }
    }
}
