using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_030_Operator_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;

            a += 20;
            Console.WriteLine("a: {0}", a);

            a -= 30;
            Console.WriteLine("a: {0}", a);

            a *= 2;
            Console.WriteLine("a: {0}", a);

            a /= 3;
            Console.WriteLine("a: {0}", a);

            a %= 4;
            Console.WriteLine("a: {0}", a);
        }
    }
}
