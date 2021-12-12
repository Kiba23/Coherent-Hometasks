
namespace DiagonalMatrix
{
    public static class MatrixExtensions
    {
        public static Matrix AddMatrix(this Matrix matrix, Matrix matrixToAdd)
        {
            var summedElements = new int[0];

            if (matrix.Size != matrixToAdd.Size)
            {
                // Identyfing which matrix is smaller and which is bigger
                var smallerMatrix = matrix.Size < matrixToAdd.Size ? matrix : matrixToAdd;
                var biggerMatrix = matrix.Size < matrixToAdd.Size ? matrixToAdd : matrix;

                // Creating array with values from smaller matrix and filling with zeroes
                var filledElements = new int[biggerMatrix.Size];
                for (int i = 0; i < biggerMatrix.Size; i++)
                {
                    filledElements[i] = smallerMatrix.DiagonalElements.Length > i ? smallerMatrix.DiagonalElements[i] : 0;
                }

                // Summing with the new created matrix with zeroes
                summedElements = SumElements(biggerMatrix, new Matrix(filledElements));
            }
            else
            {
                summedElements = SumElements(matrix, matrixToAdd);
            }

            // Creating and returning a new matrix with summed elements
            return new Matrix(summedElements);
        }

        private static int[] SumElements(Matrix matrix, Matrix matrixToAdd)
        {
            // Summing elements from both matrices
            var summedElements = new int[matrix.Size];
            for (int i = 0; i < matrix.Size; i++)
            {
                summedElements[i] = matrix.DiagonalElements[i] + matrixToAdd.DiagonalElements[i];
            }

            return summedElements;
        }
    }
}
