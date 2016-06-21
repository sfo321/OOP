using System;
using System.Text;


namespace Matrix
{
    public class Matrix<T> where T : struct, IComparable
    {
        private T[,] matrix;
        private int cols;
        private int rows;

        public Matrix(int rows, int cols)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.matrix = new T[rows, cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if(value > 0)
                {
                    this.rows = value;
                }
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value > 0)
                {
                    this.cols = value;
                }
            }
        }

        public void RangeCheck(int row, int col)
        {
            if(row < 0 || col < 0 || row > this.matrix.GetLongLength(0) - 1
                || col > this.matrix.GetLongLength(1) - 1)
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public T this[int rows, int cols]
        {
            get
            {
                RangeCheck(rows, cols);
                return this.matrix[rows, cols];
            }
            set
            {
                RangeCheck(rows, cols);
                this.matrix[rows, cols] = value;
            }
        }

        public void TypeCheck()
        {
            if (typeof(T) != typeof(int) && typeof(T) != typeof(long) && typeof(T) != typeof(short) && typeof(T) != typeof(float) &&
                typeof(T) != typeof(double) && typeof(T) != typeof(decimal))
            {
                throw new ArgumentException("Cannot apply this operator on this type of matrix!");
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            matrixOne.TypeCheck();
            matrixTwo.TypeCheck();
            if (matrixOne.Cols != matrixTwo.Cols || matrixOne.Rows != matrixTwo.Rows)
            {
                throw new ArgumentException("Matrices must be with same sizes");
            }

            Matrix<T> result = new Matrix<T>(matrixOne.Rows, matrixOne.Cols);
            for(int i = 0; i < matrixOne.Rows; i++)
            {
                for (int j = 0; j < matrixOne.Cols; j++)
                {
                    result[i, j] = (dynamic)matrixOne[i, j] + matrixTwo[i, j];
                }
            }
            return result;
        }

        public static Matrix<T> operator -(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            matrixOne.TypeCheck();
            matrixTwo.TypeCheck();
            if (matrixOne.Cols != matrixTwo.Cols || matrixOne.Rows != matrixTwo.Rows)
            {
                throw new ArgumentException("Matrices must be with same sizes");
            }

            Matrix<T> result = new Matrix<T>(matrixOne.Rows, matrixOne.Cols);
            for (int i = 0; i < matrixOne.Rows; i++)
            {
                for (int j = 0; j < matrixOne.Cols; j++)
                {
                    result[i, j] = (dynamic)matrixOne[i, j] - matrixTwo[i, j];
                }
            }
            return result;
        }
        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            matrixOne.TypeCheck();
            matrixTwo.TypeCheck();
            if (matrixOne.Cols != matrixTwo.Rows)
            {
                throw new ArgumentException("The matrices cannot be multiplied due to invalid size!");
            }

            var result = new Matrix<T>(matrixOne.Rows, matrixTwo.Cols);
            T sum;
            for (int i = 0; i < result.Rows; i++)
            {
                for (int j = 0; j < result.Cols; j++)
                {
                    sum = (dynamic)0;
                    for (int k = 0; k < matrixOne.Cols; k++)
                    {
                        sum += (dynamic)matrixOne[i, k] * matrixTwo[k, j];
                    }
                    result[i, j] = sum;
                }
            }
            return result;
        }

        private bool ZeroCheck()
        {
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    if (this[i, j] != (dynamic)0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator true(Matrix<T> curentMatrix)
        {
            return curentMatrix.ZeroCheck();
        }

        public static bool operator false(Matrix<T> curentMatrix)
        {
            return curentMatrix.ZeroCheck();
        }

        public static bool operator !(Matrix<T> curentMatrix)
        {
            return !curentMatrix.ZeroCheck();
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    if (j > 0)
                    {
                        result.Append(" ");
                    }
                    result.Append(this[i, j]);
                }
                if (i != this.Rows - 1)
                {
                    result.AppendLine();
                }
            }
            return result.ToString();
        }
    }
}
    