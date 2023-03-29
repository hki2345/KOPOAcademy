using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_068_Boxing_Unboxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 123;
            object o = i;

            Console.WriteLine("i: {0}, o: {1}, ReferenceEquals: {2}", i, o, ReferenceEquals(i, o));

            int j = (int)o;
            Console.WriteLine("i: {0}, o: {1}, ReferenceEquals: {2}", j, o, ReferenceEquals(j, o));

            j = 456;
            Console.WriteLine("i, {0}, o: {1}, j: {2}", i, o, j);
        }
    }
}
