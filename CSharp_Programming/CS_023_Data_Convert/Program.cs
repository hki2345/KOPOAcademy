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

            int a = Convert.ToInt32(aStr);
            double b = Convert.ToDouble(bStr);
            char c = Convert.ToChar(cStr);

            Console.WriteLine("Convert.ToInt32(aStr): {0}", a);
            Console.WriteLine("Convert.ToDouble(bStr): {0}", b);
            Console.WriteLine("Convert.ToChar(cStr): {0}", c);
        }
    }
}
