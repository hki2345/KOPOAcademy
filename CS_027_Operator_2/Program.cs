using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_027_Operator_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 3;
            double c = 10.5, d = 3.5;

            Console.WriteLine("a: {0}, b: {1}", a, b);
            Console.WriteLine("c: {0}, d: {1}", c, d);

            Console.WriteLine();

            Console.WriteLine("# 정수의 계산");
            Console.WriteLine("a + b = {0}", a + b);
            Console.WriteLine("a - b = {0}", a - b);
            Console.WriteLine("a * b = {0}", a * b);
            Console.WriteLine("a / b = {0}", a / b);
            Console.WriteLine("a + b = {0}", a + b);

            Console.WriteLine();

            Console.WriteLine("# 실수의 계산");
            Console.WriteLine("c + d = {0}", c + d);
            Console.WriteLine("c - d = {0}", c - d);
            Console.WriteLine("c * d = {0}", c * d);
            Console.WriteLine("c / d = {0}", c / d);
            Console.WriteLine("c % d = {0}", c % d);

            Console.WriteLine();

            Console.WriteLine("10 / 3 = {0}", 10 / 3);
            Console.WriteLine("10.0 / 3 = {0}", 10.0 / 3);

            Console.WriteLine();

            Console.WriteLine("a / b = {0}", a / b);
            Console.WriteLine("(double)a / b = {0}", (double)a / b);
        }
    }
}
