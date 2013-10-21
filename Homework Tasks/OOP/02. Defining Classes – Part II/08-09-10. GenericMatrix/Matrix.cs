using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericMatrix
{
    // Task 08 - Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 

    public class Matrix<T>
        where T : struct, IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
    {
        private readonly T[,] matrix;
        
        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
        }

        public int Rows
        { 
            get { return this.matrix.GetLength(0); } 
        }

        public int Cols
        {
            get { return this.matrix.GetLength(1); }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            for (int r = 0; r < this.matrix.GetLength(0); r++)
            {
                for (int c = 0; c < this.matrix.GetLength(1); c++)
                {
                    Console.Write(" {0, 3} |", this.matrix[r, c]);
                }
                Console.WriteLine();
            }
            
            return output.ToString();
        }

        // Task 09 - Implement an indexer this[row, col] to access the inner matrix cells.

        public T this[int row, int col]
        {
            get 
            {
                CheckIndexRange(row, col);

                return matrix[row, col];
            }

            set
            {
                CheckIndexRange(row, col);

                matrix[row, col] = value;
            }
        }

        private void CheckIndexRange(int row, int col)
        {
            if (row < 0 || col < 0 || row >= this.Rows || col >= this.Cols)
            {
                throw new IndexOutOfRangeException(String.Format("Invalid index! Row [0 - {0}], Col [0 - {1}]", this.Rows, this.Cols));
            }
        }

        // Task 10 - Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
        // Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {
            CheckMatrixesForEqualSizes(m1, m2);

            Matrix<T> result = new Matrix<T>(m1.Rows, m1.Cols);

            for (int r = 0; r < m1.Rows; r++)
            {
                for (int c = 0; c < m1.Cols; c++)
                {
                    result[r, c] = (dynamic)m1[r, c] + (dynamic)m2[r, c];
                }
            }

            return result;
        }

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {
            CheckMatrixesForEqualSizes(m1, m2);

            Matrix<T> result = new Matrix<T>(m1.Rows, m1.Cols);

            for (int r = 0; r < m1.Rows; r++)
            {
                for (int c = 0; c < m1.Cols; c++)
                {
                    result[r, c] = (dynamic)m1[r, c] - (dynamic)m2[r, c];
                }
            }

            return result;
        }

        private static void CheckMatrixesForEqualSizes(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Rows != m2.Rows || m1.Cols != m2.Cols)
            {
                throw new OperationCanceledException("Matrixes should have equal sizes for this operation!");
            }
        }

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {
            if (m1.Cols != m2.Rows)
            {
                throw new OperationCanceledException("Multiplication requires that matrix A's columns are equal to matrix B's rows");
            }

            Matrix<T> result = new Matrix<T>(m1.Rows, m2.Cols);

            for (int r = 0; r < result.Rows; r++)
            {
                for (int c = 0; c < result.Cols; c++)
                {
                    for (int i = 0; i < m1.Cols; i++)
                    {
                        result[r, c] += (dynamic)m1[r, i] * (dynamic)m2[i, c];
                    }
                }
            }

            return result;
        }

        public static bool operator true(Matrix<T> matrix)
        {
            bool result = true;

            for (int r = 0; r < matrix.Rows; r++)
            {
                for (int c = 0; c < matrix.Cols; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        result = false;
                    }
                }
            }

            return result;
        }

        public static bool operator false(Matrix<T> matrix)
        {
            bool result = true;

            for (int r = 0; r < matrix.Rows; r++)
            {
                for (int c = 0; c < matrix.Cols; c++)
                {
                    if ((dynamic)matrix[r, c] == 0)
                    {
                        result = false;
                    }
                }
            }

            return result;
        }
    }
}
