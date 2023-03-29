using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_082_Function_ref
{
    internal class Program
    {
        static void InitVal(int num)
        {
            num = 200;
        }

        static void InitRef(ref int num) 
        {
            num = 200;
        }
        static void InitOut(out int num)
        {
            num = 200;
        }

        static void Main(string[] args)
        {
            int a = 100;
            InitVal(a);
            Console.WriteLine("a: {0}", a);

            int b = 100;
            InitRef(ref b);
            Console.WriteLine("b: {0}", b);

            int c;
            InitOut(out c);
            Console.WriteLine("c: {0}", c);
        }
    }
}
