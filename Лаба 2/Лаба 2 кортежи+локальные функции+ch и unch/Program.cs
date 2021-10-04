using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2_кортежи
{
    class Program
    {
        static void Main(string[] args)
        {
            (int a, string b, char c, string d, ulong e) cor = (5, "Hellow", '!', "world", 1231624);
            (int a, string b, char c, string d, ulong e) tor = (5, "Hellow", '!', "world", 1231624);

            Console.WriteLine(cor);
            Console.WriteLine(cor.Item1);
            Console.WriteLine(cor.Item3);
            Console.WriteLine(cor.d);
            Console.WriteLine(cor.b);
            Console.WriteLine(cor == tor);

            int[] dab = {5, 1, 2, 521, 0};
            string stre = "Hellow world!!!";

            Console.WriteLine(loc(dab, stre));

            (int, int, int, string) loc(int[] mas, string str)
            {
                int sum = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    sum += mas[i];
                }
                (int, int, int, string) fot = (mas.Max(), mas.Min(), sum, str.Substring(0, 1));
                return fot;
            }

            int jas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(che(jas));
            Console.WriteLine(unche(jas));

            int che(int w)
            {
                checked
                {
                    int ch = 2147483646 + w;
                    return ch;
                }
            }

            int unche(int w)
            {
                unchecked
                {
                    int unch = 2147483647 + w;
                    return unch;
                }
            }

            Console.ReadKey();
        }
    }
}
