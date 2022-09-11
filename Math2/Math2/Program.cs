using System;

namespace Math2
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(3, 3);
            Matrix matrix2 = new Matrix(2, 2);
            Matrix matrix3 = new Matrix(2, 2);
            Matrix matrix4 = new Matrix(3, 3);
            matrix1.MatrixSum(matrix2);
            matrix1.PrintMatrix();
            Console.WriteLine();
            matrix4.MultiplyOnNum(3);
            matrix4.PrintMatrix();
            Console.WriteLine();
            matrix2.PrintMatrix();
            Console.WriteLine();
            matrix3.PrintMatrix();
            Console.WriteLine();
            matrix2.MatrixMatrix(matrix3);
            matrix2.PrintMatrix();
            Console.ReadLine();
        }
    }
}