using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_089_Function_Recursion
{
    internal class Program
    {
        static void Func(int i)
        {
            Console.WriteLine("i: {0}", i);

            i--;

            if(i > 0) Func(i);
        }
        static void Main(string[] args)
        {
            Func(5);
        }
    }
}
