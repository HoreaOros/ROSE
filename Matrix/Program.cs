using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int dim; // dimensiunea matricii

            string line;

            Console.WriteLine("Introduceti dimensiunea matricii:");
            line = Console.ReadLine();

            bool ret = int.TryParse(line, out dim);
            if(ret == false)
            {
                Console.WriteLine("Nu ati introdus un numar corect");
                return;
            }


            int[,] matrix;

            matrix = new int[dim, dim];

            InitMatrix(matrix);

            PrintMatrix(matrix);


            // Suma elementelor de pe DP
            Console.WriteLine($"Suma elementelor de pe diagonala principala este: {SumaDP(matrix)}");


            // Suma elementelor de pe diagonala secundara
            Console.WriteLine($"Suma elementelor de pe diagonala secundara este: {SumaDS(matrix)}");

            // Suma elementelor de deasupra diagonalei principale
            Console.WriteLine($"Suma elementelor de deasupra diagonalei principale: {SumaDDP(matrix)}");

            // Suma elementelor de sub diagonala principala
            Console.WriteLine($"Suma elementelor de sub diagonala principala: {SumaSDP(matrix)}");
        }

        private static object SumaSDP(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int suma = 0;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < i - 1; j++)
                {
                    suma += matrix[i, j];
                }
            }
            return suma;
        }

        private static object SumaDDP(int[,] matrix)
        {
            int n = matrix.GetLength(0);
            int suma = 0;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    suma += matrix[i, j];
                }
            }
            return suma;
        }

        ///     0 1 2 3
        /// ------------   
        /// 0 | 1 2 3 0
        /// 1 | 4 5 6 0
        /// 2 | 7 8 9 0
        /// 3 | 0 0 0 0
        /// pentru o matrice de dim n;
        /// daca i + j == n - 1 atunci matrix[i, j] este pe DS
        private static object SumaDS(int[,] matrix)
        {
            int suma = 0;
            int n = matrix.GetLength(0);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                suma += matrix[i, n - 1 - i];
            }
            return suma;
        }

        private static object SumaDP(int[,] matrix)
        {
            int suma = 0;
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                suma += matrix[i, i];
            }
            return suma;
        }

        private static void InitMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    int.TryParse(Console.ReadLine(), out matrix[i, j]);
                }
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
