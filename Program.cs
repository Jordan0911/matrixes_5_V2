using System.Runtime.InteropServices;

namespace matrixes_5_V2
{
    internal class Program
    {
        static int Total_sum(int[,] matrix)
        {
            int sum = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
        static int[] Column_sum(int[,] matrix)
        {
            int[] sum = new int[matrix.GetLength(1)];
            for(int i = 0; i < matrix.GetLength(1); i++)
            {
                for (int j = 0; i < matrix.GetLength(0); i++)
                {
                    sum[i] += matrix[j, i];
                }
            }
           
            return sum;
        }
        static int[] Row_sum(int[,] matrix)
        {
           
            int[] sum = new int[matrix.GetLength(1)];

           
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; i < matrix.GetLength(1); i++)
                {
                    sum[i] += matrix[i, j];
                }
            }
            return sum;
        }
        static int[,] Rook_sum(int[,] matrix)
        {
            int total_sum=Total_sum(matrix);             
            int[,] result = new int[matrix.GetLength(0), matrix.GetLength(1)];
            int[] row_sums=Row_sum(matrix);
            int[] column_sum=Column_sum(matrix);    
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                    result[i, j] = total_sum - (row_sums[i] + column_sum[j]) + matrix[i , j];
                    }
                }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
