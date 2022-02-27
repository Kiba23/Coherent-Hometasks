
namespace DiagonalMatrix
{
    public static class DiagonalMatrixExtension
    {
        public delegate T MatrixAddition<T>(T element1, T element2);

        public static DiagonalMatrix<T> AddMatrices<T>(this DiagonalMatrix<T> matrix1, DiagonalMatrix<T> matrix2,
            MatrixAddition<T> addition) // For the matrices with any dimension
        {
            T[] newElementsAfterAddition;
            
            var biggerMatrix = matrix1.Size >= matrix2.Size ? matrix1 : matrix2;
            var smallerMatrix = matrix1.Size < matrix2.Size ? matrix1 : matrix2;
            newElementsAfterAddition = new T[biggerMatrix.Size];

            for (int i = 0; i < smallerMatrix.Size; i++)
            {
                newElementsAfterAddition[i] = addition(matrix1[i, i], matrix2[i, i]);
            }

            for (int i = smallerMatrix.Size; i < biggerMatrix.Size; i++)
            {
                newElementsAfterAddition[i] = biggerMatrix[i, i];
            }

            return new DiagonalMatrix<T>(newElementsAfterAddition);
        }
    }
}
