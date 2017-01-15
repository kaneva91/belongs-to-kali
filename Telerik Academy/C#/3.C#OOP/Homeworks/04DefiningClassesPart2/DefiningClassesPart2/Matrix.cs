using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClassesPart2
{
    class Matrix<T>
    {
        private int row;
        private int col;

        public Matrix(int row, int col)
        {
            this.Row = row;
            this.Col = col;
            this.MatrixArray = new T[row, col];
        }

        public int Row
        {
            get
            {
                return this.row;
            }
            private set
            {
                if (row < 0)
                {
                    throw new ArgumentException("Row value cannot be less than zero!");
                }
                this.row = value;
            }
        }

        public int Col
        {
            get
            {
                return this.col;
            }
            private set
            {
                if (col < 0)
                {
                    throw new ArgumentException("Column value cannot be less than zero!");
                }
                this.col = value;
            }
        }

        public T[,] MatrixArray { get; set; }

        public T this[int row, int col]
        {
            get
            {
                return this.MatrixArray[row, col];
            }
            set
            {
                this.MatrixArray[row, col] = value;
            }
        }

        
        public static Matrix<T> operator+ (Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Row != matrixTwo.Row && matrixOne.Col != matrixTwo.Col)
            {
                throw new ArgumentException("Cannot apply addintion on unequal operands!");
            }

            var newMatrix = new Matrix<T>(matrixOne.row, matrixOne.col);
            dynamic sum = 0;

            for (int row = 0; row < newMatrix.Row; row++)
            {
                for (int col = 0; col < newMatrix.Col; col++)
                {
                    sum = (dynamic)matrixOne[row, col] + matrixTwo[row, col];
                    newMatrix[row, col] = sum;
                    sum = 0;
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator- (Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Row != matrixTwo.Row && matrixOne.Col != matrixTwo.Col)
            {
                throw new ArgumentException("Cannot apply substraction on unequal operands!");
            }
            var newMatrix = new Matrix<T>(matrixOne.row, matrixOne.col);
            dynamic sum = 0;

            for (int row = 0; row < newMatrix.Row; row++)
            {
                for (int col = 0; col < newMatrix.Col; col++)
                {
                    sum = (dynamic)matrixOne[row, col] - matrixTwo[row, col];
                    newMatrix[row, col] = sum;
                    sum = 0;
                }
            }
            return newMatrix;
        }

        public static Matrix<T> operator *(Matrix<T> matrixOne, Matrix<T> matrixTwo)
        {
            if (matrixOne.Col != matrixTwo.Row)
            {
                throw new ArgumentException("Operands are not compatible!");
            }

            Matrix<T> resultMatrix = new Matrix<T>(matrixOne.Row, matrixTwo.Col);
            dynamic result = 0;
            int counter = 0;

            for (int i = 0; i < matrixOne.Row; i++)
            {
                for (int j = 0; j <= matrixTwo.Col; j++)
                {
                    result += (dynamic)matrixOne[i, j] * matrixTwo[j, counter];

                    if (j == matrixTwo.Col)
                    {
                        resultMatrix[i, counter] = result;
                        counter++;
                        i--;

                        if (counter == matrixTwo.Col)
                        {
                            counter = 0;
                            i++;
                        }
                    }
                }

                result = 0;
            }

            return resultMatrix;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            var boolMatrix = new Matrix<bool>(matrix.Row, matrix.Col);
            bool zero = false;

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] != 0)
                    {
                        boolMatrix[i, j] = true;
                    }
                    else
                    {
                        boolMatrix[i, j] = false;
                    }
                }
            }

            return zero;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            var boolMatrix = new Matrix<bool>(matrix.Row, matrix.Col);
            bool zero = false;

            for (int i = 0; i < matrix.Row; i++)
            {
                for (int j = 0; j < matrix.Col; j++)
                {
                    if ((dynamic)matrix[i, j] != 0)
                    {
                        boolMatrix[i, j] = false;
                    }
                    else
                    {
                        boolMatrix[i, j] = true;
                    }
                }
            }

            return zero;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();

            for (int i = 0; i < this.Row; i++)
            {
                for (int j = 0; j < this.Col; j++)
                {
                    builder.Append(this.MatrixArray[i, j] + " ");
                }

                builder.AppendLine();
            }

            return builder.ToString();
        }

    }
}
