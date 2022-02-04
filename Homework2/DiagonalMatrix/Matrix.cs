using System;

namespace DiagonalMatrix
{
    public class Matrix
    {
        private int[] DiagonalElements { get; set; }
        public readonly int Size;

        public Matrix(params int[] inputElements)
        {
            if (inputElements.Length == default || inputElements == null)
            {
                Size = 0;
            }
            else
            {
                DiagonalElements = inputElements;
                Size = inputElements.Length;
            }
        }

        public int this[int i, int j]
        {
            get
            {
                if (i < 0 || j < 0)
                {
                    throw new Exception("Invalid indexes.");
                }
                if (i != j || i >= Size || j >= Size)
                {
                    return 0;
                }
                return DiagonalElements[i];
            }
        }

        public int Track()
        {
            int sum = 0;
            foreach (var elem in DiagonalElements)
            {
                sum += elem;
            }
            return sum;
        }

        public override bool Equals(object obj)
        {
            if (obj is Matrix)
            {
                var compareMatrix = obj as Matrix;
                if (this.Size == compareMatrix.Size)
                {
                    for (int i = 0; i < this.Size; i++)
                    {
                        if (this.DiagonalElements[i] != compareMatrix.DiagonalElements[i])
                        {
                            return false;
                        }
                    }
                    return true;
                }
            }
            else if (obj is null)
            {
                throw new Exception("Object is null.");
            }
            return false;
        }

        public override string ToString()
        {
            string elementsToString = "";
            foreach (var elem in DiagonalElements)
            {
                elementsToString += elem.ToString() + " ";
            }
            return elementsToString;
        }
    }
}
