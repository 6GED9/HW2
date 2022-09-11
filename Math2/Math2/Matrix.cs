using System;
namespace Math2
{
    public class Matrix
    {
        int i, j;
        int[,] matrix;
        public Matrix(int i, int j)
        {
            this.i = i;
            this.j = j;
            matrix = new int [i,j];
            Random random = new Random();
            for (int m = 0; m < this.i; m++)
            {
                for (int n = 0; n < this.j; n++)
                {
                    matrix[m, n] = random.Next(1,3);
                }
            }
        }

        public void MatrixSum(Matrix matrix)
        {
            if (this.matrix.Length <= matrix.matrix.Length)
            {
                for (int i = 0; i < this.i; i++)
                {
                    for (int j = 0; j < this.j; j++)
                    {
                        this.matrix[i, j] += matrix.matrix[i, j];
                    }
                }
            }
            else
            {
                for (int i = 0; i < matrix.i; i++)
                {
                    for (int n = 0; j < matrix.j; j++)
                    {
                        this.matrix[i, j] += matrix.matrix[i, j];
                    }
                }
            }
        }
        public void MultiplyOnNum(int k)
        {
            for(int i = 0; i < this.i; i++)
            {
                for (int j = 0; j < this.j; j++)
                {
                    matrix[i, j] *= k;
                }
            }
        }
        public void PrintMatrix()
        {
            for (int i = 0; i < this.i; i++)
            {
                for (int j = 0; j < this.j; j++)
                {
                    Console.Write(this.matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void MatrixMatrix(Matrix matrix)
        {
                int[,] tempMatrix = new int[this.i, matrix.j];
                for (int i = 0; i < this.i; i++)
                {
                    for (int j = 0; j < matrix.i; j++)
                    {
                        for (int k = 0; k < matrix.j; k++)
                        {
                            tempMatrix[i, j] += this.matrix[i, k] * matrix.matrix[k, j];
                        }
                    }
                }
            this.matrix = tempMatrix;
        }
    }
}

