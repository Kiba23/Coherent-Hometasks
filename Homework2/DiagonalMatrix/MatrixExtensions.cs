
namespace DiagonalMatrix
{
    public static class MatrixExtensions
    {
        public static Matrix AddMatrix(this Matrix matrix, Matrix matrixToAdd)
        {
            int newMatrixSize = matrix.Size >= matrixToAdd.Size ? matrix.Size : matrixToAdd.Size;
            int[] newMatrixDiagonalElements = new int[newMatrixSize];

            for (int i = 0; i < newMatrixSize; i++)
            {
                newMatrixDiagonalElements[i] = matrix[i, i] + matrixToAdd[i, i];
            }

            return new Matrix(newMatrixDiagonalElements);
        }
    }
}
