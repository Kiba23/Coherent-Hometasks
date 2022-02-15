
namespace DiagonalMatrix
{
    public static class DiagonalMatrixExtension
    {
        public delegate T MatrixAddition<T>(T element1, T element2);

        public static DiagonalMatrix<T> AddMatrices<T>(this DiagonalMatrix<T> matrix1, DiagonalMatrix<T> matrix2, 
            MatrixAddition<T> addition) // Only for the same dimensional matrices, because there is no such requirement in the task description.
        {
            int newSize = matrix1.Size >= matrix2.Size ? matrix1.Size : matrix2.Size;
            T[] newElementsAfterAddition = new T[newSize];

            for (int i = 0; i < newSize; i++)
            {
                newElementsAfterAddition[i] = addition(matrix1[i, i], matrix2[i, i]);
            }
            return new DiagonalMatrix<T>(newElementsAfterAddition);
        }
    }
}
