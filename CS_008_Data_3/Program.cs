using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_008_Data_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1000000000;
            short s = 1000;

            i = s;

            unchecked
            {
                byte b;
                b = (byte)256;
                Console.WriteLine(b);
            }
        }
    }
}
