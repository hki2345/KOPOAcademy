using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_022_Data_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string aStr = "100";
            string bStr = ".123";
            string cStr = "A";

            int a = int.Parse(aStr);
            double b = double.Parse(bStr);
            char c = char.Parse(cStr);

            Console.WriteLine("int.Parse(aStr): {0}", a);
            Console.WriteLine("double.Parse(bStr): {0}", b);
            Console.WriteLine("char.Parse(cStr): {0}", c);
        }
    }
}
