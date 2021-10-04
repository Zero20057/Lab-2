using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Bool = ");
            bool bool1 = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine(bool1);

            Console.Write("Byte = ");
            byte byte1 = Convert.ToByte(Console.ReadLine());
            Console.WriteLine(byte1);

            Console.Write("Sbyte = ");
            sbyte sbyte1 = Convert.ToSByte(Console.ReadLine());
            Console.WriteLine(sbyte1);

            Console.Write("Char = ");
            char char1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine(char1);

            Console.Write("Double = ");
            double double1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(double1);

            Console.Write("Int = ");
            int int1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(int1);

            Console.Write("String = ");
            string string1 = Console.ReadLine();
            Console.WriteLine(string1);

            Console.WriteLine();
            int? null1 = null;
            Console.WriteLine(Convert.ToBoolean(null1));

            Console.WriteLine();
            var var1 = 10.123;
            Console.WriteLine(var1);

            Console.ReadKey();
        }
    }
}
