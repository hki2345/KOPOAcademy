using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_087_Function_overloading
{
    internal class Program
    {
        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }
        static double Add(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Add(int a, int b): {0}", Add(1, 2));
            Console.WriteLine("Add(int a, int b, int c): {0}", Add(1, 2, 3));
            Console.WriteLine("Add(double a, double b): {0}", Add(.1, .2));
        }
    }
}
