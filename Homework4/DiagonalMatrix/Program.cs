using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new DiagonalMatrix<int>(new int[] { 1, 44, 7, 3, 95 });
            var matrix2 = new DiagonalMatrix<int>(new int[] { 9, -7, 0, -3, 5 });

            var result = matrix1.AddMatrices(matrix2, NumericalAddition);

            Console.WriteLine(result);
        }

        static T NumericalAddition<T>(T element1, T element2) // Only for addition between number types.
        {
            dynamic elem1 = element1;
            dynamic elem2 = element2;

            return elem1 + elem2;
        }
    }
}
