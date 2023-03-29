using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_015_Data_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object a = 100;
            object b = 0.123;
            object c = true;
            object d = 'A';
            object e = "APPLE";

            Console.WriteLine("object a = {0} (type: {1}", a, a.GetType());
            Console.WriteLine("object b = {0} (type: {1}", b, b.GetType());
            Console.WriteLine("object c = {0} (type: {1}", c, c.GetType());
            Console.WriteLine("object d = {0} (type: {1}", d, d.GetType());
            Console.WriteLine("object e = {0} (type: {1}", e, e.GetType());
        }
    }
}
