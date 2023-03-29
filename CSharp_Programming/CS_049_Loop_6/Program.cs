using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_049_Loop_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++) 
            {
                Console.WriteLine(i);
            }

            int j = 0;
            while (j < 5)
            {
                Console.WriteLine(j);
                j++;
            }
        }
    }
}
