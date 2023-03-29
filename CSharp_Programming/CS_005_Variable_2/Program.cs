using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_005_Variable_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            a = 100;
            Console.WriteLine(a);

            int b = 200;
            Console.WriteLine(b);

            a = 300;
            a = 400;
            a = 500;

            Console.WriteLine(a);

            a = b;

            Console.WriteLine(a);

            int x = 300, y = 400;

            Console.WriteLine("{0}, {1}", x, y);
        }
    }
}
