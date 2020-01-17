using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 8;

            T1(n);


           
            T11(n); //  11212312
            Console.WriteLine();
            T11_2(n);

        }

        private static void T11_2(int n)
        {
            int contor = 0;

            int i = 1, j = 1;

            while (contor < n)
            {
                Console.Write(j);
                contor++;
                j++;
                if (j > i)
                {
                    i++;
                    j = 1;
                }
            }
        }

        private static void T11(int n)
        {
            int contor = 0;
            for (int i = 1; contor < n; i++)
            {
                for (int j = 1; contor < n && j <= i; j++)
                {
                    Console.Write(j);
                    contor++;
                }
            }
        }

        private static void T1(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
