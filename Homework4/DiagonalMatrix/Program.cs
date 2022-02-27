using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            #region AddingMatricesTests
            var matrix1 = new DiagonalMatrix<int>(new int[] { 1, 44, 7, 3, 95, 5, 6, 7 });
            var matrix2 = new DiagonalMatrix<int>(new int[] { 9, -7, 0, -3, 5 });

            var result1 = matrix1.AddMatrices(matrix2, NumericalAddition);

            Console.WriteLine($"Matrices after addition - {result1}");


            var matrix3 = new DiagonalMatrix<float>(new float[] { 1.3f, 1.5678f, -3.43f });
            var matrix4 = new DiagonalMatrix<float>(new float[] { -7.12f, 3.4f, 3.43f, 5f, 6.3f, 7.0f });

            var result2 = matrix3.AddMatrices(matrix4, NumericalAddition);

            Console.WriteLine($"Matrices after addition - {result2}");
            #endregion


            #region EventTests
            matrix3[2, 2] = -2.135f;
            var matrix3Tracker = new MatrixTracker<float>(matrix3);
            matrix3[2, 2] = -0.5555f;
            matrix3[2, 2] = -0.5555f; // Works good - it's not calling the event.
            matrix3Tracker.Undo(); // Returning value back to -2.135f, becuase previous event wasn't invoked.


            var matrix2Tracker = new MatrixTracker<int>(matrix2);
            Console.WriteLine($"Matrix before changing - {matrix2}");
            matrix2[1, 1] = 40;
            Console.WriteLine($"Changed matrix - {matrix2}");

            matrix2Tracker.Undo();
            Console.WriteLine($"Undo operation - {matrix2}");
            #endregion


            #region Exceptional case test when matrix elements wasn't changed
            var matrix5 = new DiagonalMatrix<float>(1.5f, 2.0f);
            var matrixTrackerTest = new MatrixTracker<float>(matrix5);
            matrixTrackerTest.Undo(); // Handling this case, value of [0,0] sets to zero.

            Console.WriteLine($"Exceptional Undo operation - {matrix5}");
            #endregion
        }

        static T NumericalAddition<T>(T element1, T element2) // Only for addition between number types.
        {
            dynamic elem1 = element1;
            dynamic elem2 = element2;

            return elem1 + elem2;
        }
    }
}
