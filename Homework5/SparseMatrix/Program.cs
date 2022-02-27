using System;
using SparseMatrixOperations.Entities;

namespace SparseMatrixOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Initializing objects
            var matrix = new SparseMatrix(3, 3);
            matrix[0, 0] = 3;
            matrix[0, 0] = 5; // Handling case when value changes couple times.
            matrix[1, 2] = 5;
            matrix[2, 2] = 15;
            matrix[1, 1] = 7;
            #endregion

            #region Testing get indexer
            var val = matrix[0, 0];
            var val2 = matrix[1, 2];
            var val3 = matrix[2, 2];
            #endregion

            #region Testing GetEnumerator method
            foreach (var elem in matrix)
            {
                Console.WriteLine(elem);
            }
            #endregion

            #region Testing the output (ToString) and GetCount methods
            Console.WriteLine("0 has occured - " + matrix.GetCount(0) + " times.");
            Console.WriteLine("5 has occured - " + matrix.GetCount(5) + " times.");
            Console.WriteLine(matrix + "\n");
            #endregion

            #region Testing GetNotZeroElements method
            foreach (var elem in matrix.GetNotZeroElements())
            {
                Console.WriteLine(elem);
            }
            #endregion
        }
    }
}
