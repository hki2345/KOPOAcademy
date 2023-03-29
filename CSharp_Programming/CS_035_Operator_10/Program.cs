using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS__35_Operator_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? a = 100;
            int? b = null;

            int result;

            result = a ?? 300;
            Console.WriteLine("a ?? 300 = {0}", result);
            
            result = b ?? 300;
            Console.WriteLine("b ?? 300 = {0}", result);
        }
    }
}
