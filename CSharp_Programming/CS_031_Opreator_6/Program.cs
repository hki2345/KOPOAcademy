using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_031_Opreator_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;

            bool result;

            result = (a == b);
            Console.WriteLine("(a == b) = {0}", result);

            result = (a != b);
            Console.WriteLine("(a != b) = {0}", result);

            result = (a > b);
            Console.WriteLine("(a > b) = {0}", result);

            result = (a < b);
            Console.WriteLine("(a < b) = {0}", result);

            result = (a >= b);
            Console.WriteLine("(a >= b) = {0}", result);

            result = (a <= b);
            Console.WriteLine("(a <= b) = {0}", result);
        }
    }
}
