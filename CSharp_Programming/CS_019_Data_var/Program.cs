using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_019_Data_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var a = 100;
            var b = 0.123;
            var c = true;
            var d = 'A';
            var e = "APPLE";

            Console.WriteLine("var a = {0} (type: {1})", a, a.GetType());
            Console.WriteLine("var b = {0} (type: {1})", b, b.GetType());
            Console.WriteLine("var c = {0} (type: {1})", c, c.GetType());
            Console.WriteLine("var d = {0} (type: {1})", d, d.GetType());
            Console.WriteLine("var e = {0} (type: {1})", e, e.GetType());
        }
    }
}
