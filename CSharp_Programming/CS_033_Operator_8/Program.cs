using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_033_Operat_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;

            string result;

            result = (a == 100) ? "참" : "거짓";
            Console.WriteLine("(a == 100) ? 참 : 거짓 = {0}", result);

            result = (a == 300) ? "참" : "거짓";
            Console.WriteLine("(a == 300) ? 참 : 거짓 = {0}", result);

            int b = 200;

            int c = (a > b) ? a : b;
            Console.WriteLine("(a > b) ? a : b = {0}", c);
        }
    }
}
