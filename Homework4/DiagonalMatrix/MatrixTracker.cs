using DiagonalMatrix.EventArguments;

namespace DiagonalMatrix
{
    public class MatrixTracker<T>
    {
        private int IndexI { get; set; }
        private int IndexJ { get; set; }
        private T OldValue { get; set; }
        private T NewValue { get; set; }
        private DiagonalMatrix<T> MatrixToTrack { get; }
        private bool WasInvoked { get; set; }


        public MatrixTracker(DiagonalMatrix<T> matrix)
        {
            matrix.ElementChanged += MatrixElementChanged;
            MatrixToTrack = matrix; // To know which matrix needs Undo method.
        }

        private void MatrixElementChanged(object sender, MatrixElementChangedArgs<T> matrixChangedEvent)
        {
            IndexI = matrixChangedEvent.IndexI;
            IndexJ = matrixChangedEvent.IndexJ;
            OldValue = matrixChangedEvent.OldValue;
            NewValue = matrixChangedEvent.NewValue;

            WasInvoked = true;
        }

        public void Undo()
        {
            if (WasInvoked)
            {
                MatrixToTrack[IndexI, IndexJ] = OldValue;
            }
            else
            {
                MatrixToTrack[0, 0] = default(T);
            }
        }
    }
}
