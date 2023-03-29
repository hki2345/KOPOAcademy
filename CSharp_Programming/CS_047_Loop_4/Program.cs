using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_047_Loop_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine("i: {0}", i);

                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("\tj: {0}", j);
                }
            }
        }
    }
}
