using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dzielnik
{
    class Program
    {
        static void Main(string[] args)
        {
            bool istrue = true;
            long numbercheck = 2520;

            while (istrue)
            {
                istrue = metoda(istrue, numbercheck);
                numbercheck++;

            }
            Console.WriteLine("Szukana liczba to: {0}", numbercheck);
        }
        private static bool isDivide(long numbercheck, int i)
        {
            return numbercheck % i != 0;
        }
        private static bool metoda(bool istrue, long numbercheck)
        {
            istrue = false;
            for (int i = 1; i <= 20; i++)
            {
                if (isDivide(numbercheck, i))
                    istrue = true;
            }
            return istrue;

            Console.ReadKey();
        }
    }
}
