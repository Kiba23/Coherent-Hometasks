using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstMatrix = new Matrix(0, 1, 2, 3, 4, -5, 100, 0);
            var secondMatrix = new Matrix(0, 5, 6);
            var thirdMatrix = new Matrix(0, 5, 6);

            // Testing
            Console.WriteLine(firstMatrix[6, 6]);
            Console.WriteLine(firstMatrix.Track());
            Console.WriteLine(secondMatrix.Equals(thirdMatrix));
            Console.WriteLine(firstMatrix);
            // Adding  matrices of the same size
            Console.WriteLine(secondMatrix.AddMatrix(thirdMatrix));
            // Adding matrices of the different size
            Console.WriteLine(firstMatrix.AddMatrix(secondMatrix));
            Console.WriteLine(secondMatrix.AddMatrix(firstMatrix));
        }
    }
}
