using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var matrix1 = new DiagonalMatrix<int>(new int[] { 1, 44, 7, 3, 95, 5, 6, 7 });
            var matrix2 = new DiagonalMatrix<int>(new int[] { 9, -7, 0, -3, 5 });

            var result = matrix1.AddMatrices(matrix2, NumericalAddition);

            Console.WriteLine(result);

            var matrix3 = new DiagonalMatrix<float>(new float[] { 1.3f, 1.5678f, -3.43f });
            var matrix4 = new DiagonalMatrix<float>(new float[] { -7.12f, 3.4f, 3.43f, 5f, 6.3f, 7.0f });

            var result2 = matrix3.AddMatrices(matrix4, NumericalAddition);

            Console.WriteLine(result2);
        }

        static T NumericalAddition<T>(T element1, T element2) // Only for addition between number types.
        {
            dynamic elem1 = element1;
            dynamic elem2 = element2;

            return elem1 + elem2;
        }
    }
}
