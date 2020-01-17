using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1001
{
    class Program
    {
        /// <summary>
        /// Se dă o secvența de n numere. 
        /// Să se spună care este numărul maxim 
        /// de numere identice consecutive în secvență. 
        ///
        /// </summary>
        /// <param name="args"></param>
        /// <example>
        /// 10
        /// 6 2 2 5 8 8 8 2 2 5 => 3
        /// 14
        /// 8 8 3 3 3 3 1 1 1 5 5 5 5 2 => 4
        /// </example>
        static void F(int[] v, out int maxLen, out int maxIndex, out int value)
        {
            
            int currentLen = 1;
            
            int currentIndex = 0;

            maxLen = 1;
            maxIndex = 0;
            value = v[0];

            for (int i = 1; i < v.Length; i++)
            {
                if (v[i] == v[i - 1])
                {
                    currentLen++;
                }
                else
                {
                    if (currentLen > maxLen)
                    {
                        maxLen = currentLen;
                        maxIndex = currentIndex;
                        value = v[i - 1];
                    }
                    else if(currentLen == maxLen)
                    {
                        if(v[i - 1] > value)
                        {
                            maxIndex = currentIndex;
                            value = v[i - 1];
                        }
                    }
                    currentLen = 1;
                    currentIndex = i;
                }
            }
            if (currentLen > maxLen)
            {
                maxLen = currentLen;
            }
        }
        static void Main(string[] args)
        {
            int[] v1 = {6, 2, 2, 5, 8, 8, 8, 2, 2, 5 };
            int[] v2 = {1, 2, 3, 4 };
            int[] v3 = {1, 1, 1, 1};
            int[] v4 = {1};
            int[] v5 = {1, 2, 3, 3, 3};
            int[] v6 = {8, 8, 5, 5, 5, 5,  1, 1, 1, 9, 9, 9, 9, 2 };


            int maxLen, maxIndex, value;
            F(v6, out maxLen, out maxIndex, out value);
            Console.WriteLine($"Length = {maxLen}, Index = {maxIndex}, value = {value}");
        }
    }
}
