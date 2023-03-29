using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_012_Data_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool a = true;
            bool b = false;

            Console.WriteLine("bool a = {0}", a);
            Console.WriteLine("bool b = {0}", b);

            bool c = 100 < 200;
            bool d = 100 > 200;
         
            Console.WriteLine("100 < 200 결과: {0}", c);
            Console.WriteLine("100 > 200 결과: {0}", d);
        }
    }
}
