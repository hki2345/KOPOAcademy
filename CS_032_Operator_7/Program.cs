using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_032_Operator_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            int b = 200;

            bool result;

            result = (a == 100) && (b == 200); // true, true
            Console.WriteLine("(a == 100) && (b == 200): {0}", result);
            
            result = (a == 100) || (b == 200); // true, true
            Console.WriteLine("(a == 100) || (b == 200): {0}", result);

            result = (a == 100) && (b == 300); // true, false
            Console.WriteLine("(a == 100) && (b == 300): {0}", result);

            result = (a == 100) || (b == 300); // false, false
            Console.WriteLine("(a == 100) || (b == 200): {0}", result);

            Console.WriteLine();

            result = true;

            result = !result;
            Console.WriteLine("result: {0}", result);

            result = !result;
            Console.WriteLine("result: {0}", result);
        }
    }
}
