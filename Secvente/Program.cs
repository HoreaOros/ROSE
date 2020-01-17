using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Secvente
{
    class Program
    {
        // 1. Se dă un vector format din n elemente, numere naturale. Calculați suma elementelor din secvența determinată de primul și ultimul element impar.
        //vectorul va conţine cel puțin un element impar

        //8
        // 12 10 15 6 7 10 19 14
        //Explicație
        // 15 + 6 + 7 + 10 + 19 = 57


        // 2. Se dau n numere naturale. Determinaţi lungimea maximă a unei secvenţe de numere din şir cu proprietatea că în scrierea binară sunt formate doar din cifre de 1.
        // 5
        // 4 6 7 15 88
        // 2
        // Explicație
        // Numerele 7 şi 15 au în scrierea în baza 2 numai cifra 1 şi ele formează o secvenţă de lungime 2.



        // 3. Se dă un vector cu n elemente, 
        // numere naturale și două numere t și k. 
        //Să se determine câte secvențe din șir 
        // au lungimea k și sunt formate din valori 
        // mai mici sau egale cu t.


        static void Main(string[] args)
        {
            int[] v = { 12, 10, 14, 6, 4,  10,  14 };



            int suma = Suma1(v);


            if (suma == 0)
            {
                Console.WriteLine("secventa nu contine numere impare");
            }
            else
                Console.WriteLine("suma numerelor este: {0}", suma);


            int[] w = {15, 15, 2, 7, 3, 1 };

            int lng;

            lng = F11(w);
            Console.WriteLine("Lungime = {0}", lng);

        }

        private static int F11(int[] w)
        {
            int maxLng = 0;
            int currentLng = 0;

            for (int i = 0; i < w.Length; i++)
            {
                if (AllOnesBinary(w[i]))
                {
                    currentLng++;
                    if (maxLng < currentLng)
                    {
                        maxLng = currentLng;
                    }
                }
                else
                {
                    currentLng = 0;
                }
            }

            return maxLng;
        }

        private static bool AllOnesBinary2(int v)
        {
            int p = 2;
            while (v > p - 1)
            {
                p = p * 2;
            }

            return v == p - 1;

        }

        private static bool AllOnesBinary(int v)
        {
            while (v > 0 && v % 2 == 1)
                v /= 2;

            return v == 0;
        }

        private static int Suma1(int[] v)
        {
            int indexStg, indexDr;

            int i = 0;

            while (i < v.Length && v[i] % 2 == 0)
            {
                i++;
            }

            if (i < v.Length)
            {
                indexStg = i;
            }
            else
                return 0;



            i = v.Length - 1;

            while (i >= 0 && v[i] % 2 == 0)
            {
                i--;
            }

            if (i >= 0)
            {
                indexDr = i;
            }
            else
                return 0;


            int suma = 0;

            for (i = indexStg; i <= indexDr; i++)
            {
                suma += v[i];
            }


            return suma;
        }
    }
}
