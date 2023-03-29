using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_048_Loop_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for(int j = 2; j <= 9; j++)
                {
                    Console.Write("[ {0} * {1} = {2,2} ]", j, i, i * j);
                }

                Console.WriteLine();
            }
        }
    }
}
