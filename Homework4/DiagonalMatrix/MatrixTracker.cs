
namespace DiagonalMatrix
{
    public class MatrixTracker<T>
    {
        int IndexI { get; set; }
        int IndexJ { get; set; }
        T OldValue { get; set; }
        T NewValue { get; set; }
        DiagonalMatrix<T> MatrixToTrack { get; }


        public MatrixTracker(DiagonalMatrix<T> matrix)
        {
            matrix.ElementChanged += MatrixElementChanged;
            MatrixToTrack = matrix; // To know which matrix needs Undo method.
        }

        private void MatrixElementChanged(int indexI, int indexJ, T oldValue, T newValue)
        {
            IndexI = indexI;
            IndexJ = indexJ;
            OldValue = oldValue;
            NewValue = newValue;
        }

        public void Undo()
        {
            MatrixToTrack[IndexI, IndexJ] = OldValue;
        }
    }
}
