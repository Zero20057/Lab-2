using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] num2 = { {0, 1, 2}, {3, 4, 5} };
            int rows = num2.GetUpperBound(0) + 1;
            int colums = num2.Length / rows;

            for (int i = 0; i < rows; i++)
            {
                for (int u = 0; u < colums; u++)
                {
                    Console.Write($"{num2[i, u]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            string[] str = { "Hello ", "world", "!!!" };
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();
            Console.WriteLine(str.Length);
            Console.WriteLine();

            Console.WriteLine("Какую позицию заменить?");
            int pos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("На что заменить?");
            string strz = Console.ReadLine();
            str[pos] = strz;
            for (int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]);
            }
            Console.WriteLine();

            int[][] mas = new int[3][];
            mas[0] = new int[2];
            mas[1] = new int[3];
            mas[2] = new int[4];
            Console.WriteLine("Введите первый массив (2)");
            for (int i = 0; i < mas[0].Length; i++)
            {
                mas[0][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите второй массив (3)");
            for (int i = 0; i < mas[1].Length; i++)
            {
                mas[1][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Введите третий массив (4)");
            for (int i = 0; i < mas[2].Length; i++)
            {
                mas[2][i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine();

            for (int i = 0; i < mas.Length; i++)
            {
                for (int u = 0; u < mas[i].Length; u++)
                {
                    Console.Write($"{mas[i][u]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
