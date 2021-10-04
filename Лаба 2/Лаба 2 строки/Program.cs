using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_2_строки
{
    class Program
    {
        static void Main(string[] args)
        {
            string strh = "Hello ";
            string strw = "world";
            string str1 = "!!!";
            string strall = String.Concat(strh, strw, str1);

            Console.WriteLine(String.Compare(strw, strh));
            Console.WriteLine(String.Compare(strw, strw));
            Console.WriteLine(String.Compare(strh, strw));

            Console.WriteLine();

            Console.WriteLine(strall);
            string[] words =  strall.Split(new char[] { ' ' });
            Console.WriteLine(words[0]);
            Console.WriteLine(words[1]);
            Console.WriteLine(strall.Substring(3, 7));
            Console.WriteLine(strh.Insert(3, strw));
            Console.WriteLine(strall.Remove(5, 3));
            Console.WriteLine($"{strh}{strw}{str1}");

            Console.WriteLine();

            string strn = null;
            string stre = "";

            Console.WriteLine(string.IsNullOrEmpty(strn));
            Console.WriteLine(string.IsNullOrEmpty(strall));
            Console.WriteLine(string.IsNullOrEmpty(stre));

            Console.WriteLine();

            StringBuilder strb = new StringBuilder("Hellow world!!!");
            Console.WriteLine(strb);
            Console.WriteLine(strb.Append("End"));
            Console.WriteLine(strb.Insert(0, "Start "));
            Console.WriteLine(strb.Remove(0, 6));

            Console.ReadKey();
        }
    }
}
