using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_021_Data_ToString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;
            double b = 0.123;
            char c = 'A';

            string aStr = a.ToString();
            string bStr = b.ToString();
            string cStr = c.ToString();

            Console.WriteLine("a.ToString(): {0}", aStr);
            Console.WriteLine("b.ToString(): {0}", bStr);
            Console.WriteLine("c.ToString(): {0}", cStr);
        }
    }
}
